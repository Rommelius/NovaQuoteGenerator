using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace QuoteGenerator
{
    public partial class QuoteGenerator : Form
    {
        //public static string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
        public static string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

        public bool YesNoSaveDestination;
        public static string saveDestination;

        public QuoteGenerator()
        {
            InitializeComponent();
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceBox.Text = "$0.00";

            todayDate.Text = DateTime.Now.ToShortDateString();
            endDate.Text = DateTime.Now.AddMonths(1).ToShortDateString();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(descriptionBox.Text, quantityBox.Text, priceBox.Text.Substring(1));
            descriptionBox.Text = "";
            quantityBox.Value = 0;
            priceBox.Text = "$0.00";
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            EditDocument();
        }

        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void EditDocument()
        {


            if (YesNoSaveDestination != true)
            {
                while (YesNoSaveDestination != true)
                {
                    DialogResult drbox = MessageBox.Show("Please select the folder to save your files");

                    if (drbox == DialogResult.OK)
                    {

                        FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                        folderDlg.ShowNewFolderButton = true;
                        // Show the FolderBrowserDialog.

                        DialogResult result = folderDlg.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            YesNoSaveDestination = true;
                            saveDestination = folderDlg.SelectedPath;
                        }
                    }
                }
            }


            //Setup the Word.Application class.
            Word.Application wordApp =
                new Word.Application();

            object missing = System.Reflection.Missing.Value;
            object moveUnit = Word.WdUnits.wdCell;
            object moveExend = Word.WdMovementType.wdMove;

            wordApp.Visible = true;
            Word.Document wDoc = wordApp.Documents.Open(appRootDir + "/Nova Biomedical Quote TEMPLATE.docx"); ;

            // Activate the document
            wDoc.Activate();

            wDoc.Bookmarks["start"].Select();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    wordApp.Selection.TypeText(row.Cells[0].Value.ToString());
                    wordApp.Selection.MoveRight(moveUnit, 1, moveExend);
                    wordApp.Selection.TypeText(row.Cells[1].Value.ToString());
                    wordApp.Selection.MoveRight(moveUnit, 1, moveExend);
                }
            }

            //Date and etc
            FindAndReplace(wordApp, "<Date>", todayDate.Text);
            FindAndReplace(wordApp, "<ValidUntil>", endDate.Text);
            FindAndReplace(wordApp, "<Quote#>", quoteNumber.Text);
            FindAndReplace(wordApp, "<EmployeeName>", preparedByName.Text);
            //Client Details
            FindAndReplace(wordApp, "<Client>", locationBox.Text);
            FindAndReplace(wordApp, "<ClientName>", contactPersonBox.Text);
            FindAndReplace(wordApp, "<ClientNumber>", contactNumberBox.Text);
            FindAndReplace(wordApp, "<ClientAddress>", contactAddressBox.Text);
            FindAndReplace(wordApp, "<ClientEmail>", contactEmailBox.Text);
            //Prices
            FindAndReplace(wordApp, "<Subtotal>", subTotalPriceBox.Text.Substring(1));
            FindAndReplace(wordApp, "<GST>", string.Format("{0:F2}", Convert.ToDouble(subTotalPriceBox.Text.Substring(1)) * 10 / 100));
            FindAndReplace(wordApp, "<TotalPrice>", string.Format("{0:F2}", ( Convert.ToDouble(subTotalPriceBox.Text.Substring(1)) * 10 / 100) + Convert.ToDouble(subTotalPriceBox.Text.Substring(1))));

            wDoc.ExportAsFixedFormat(saveDestination + "/" + quoteNumber.Text+ "-" +  locationBox.Text + "-QUOTE" + ".pdf", Word.WdExportFormat.wdExportFormatPDF);
                        

            GC.Collect();
            wDoc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
            wordApp.Quit();
            MessageBox.Show("Quote Generated");
            ExitWord();
        }
        private void ExitWord()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("WINWORD"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FindAndReplace(Word.Application WordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object nmatchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            WordApp.Selection.Find.Execute(ref findText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike,
                ref nmatchAllWordForms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiacritics, ref matchAlefHamza,
                ref matchControl);
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            //Remove previous formatting, or the decimal check will fail including leading zeros
            string value = priceBox.Text.Replace(",", "")
                .Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                priceBox.TextChanged -= priceBox_TextChanged;
                //Format the text as currency
                priceBox.Text = string.Format(CultureInfo.CreateSpecificCulture("en-AU"), "{0:C2}", ul);
                priceBox.TextChanged += priceBox_TextChanged;
                priceBox.Select(priceBox.Text.Length, 0);
            }
            bool goodToGo = TextisValid(priceBox.Text);
            if (!goodToGo)
            {
                priceBox.Text = "$0.00";
                priceBox.Select(priceBox.Text.Length, 0);
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double a = 0, b = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                a = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[1].Value);
                b = b + a;
            }
            subTotalPriceBox.Text = "$"+string.Format("{0:F2}", b);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double a = 0, b = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                a = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[1].Value);
                b = b + a;
            }
            subTotalPriceBox.Text = "$" + string.Format("{0:F2}", b);
        }

        public static int WordsCount(string str)
        {

            string pattern = "[^\\w]";
            //get all spaces and other signs, like: '.' '?' '!'
            string[] words = null;
            int i = 0;
            int count = 0;
            words = Regex.Split(str, pattern, RegexOptions.IgnoreCase);
            for (i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
            {
                if (words[i].ToString() == string.Empty)
                    count = count - 1;
                count = count + 1;
            }
            return count;
        }

        private void locationBox_Leave(object sender, EventArgs e)
        {
            if (locationBox.Text != "" && preparedByName.Text != "")
            {
                int wc = WordsCount(locationBox.Text);
                if (wc <= 1)
                {
                    string s = new string(preparedByName.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());

                    quoteNumber.Text = s.ToUpper() + locationBox.Text.Substring(0, 3).ToUpper() + DateTime.Now.Day.ToString() +DateTime.Now.Month.ToString();
                }
                else
                {
                    string s = new string(locationBox.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());
                    string employeename = new string(preparedByName.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());


                    quoteNumber.Text = employeename.ToUpper() + s.ToUpper() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
                }
            }
           
        }

        private void preparedByName_Leave(object sender, EventArgs e)
        {
            if (locationBox.Text != "" && preparedByName.Text != "")
            {
                int wc = WordsCount(locationBox.Text);
                if (wc <= 1)
                {
                    string s = new string(preparedByName.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());

                    quoteNumber.Text = s.ToUpper() + locationBox.Text.Substring(0, 3).ToUpper() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
                }
                else
                {
                    string s = new string(locationBox.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());
                    string employeename = new string(preparedByName.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());


                    quoteNumber.Text = employeename.ToUpper() + s.ToUpper() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
                }
            }

        }

        private void totalPriceBox_TextChanged(object sender, EventArgs e)
        {
            gstBox.Text = "$" + string.Format("{0:F2}", Convert.ToDouble(subTotalPriceBox.Text.Substring(1)) * 10 / 100);
        }

        private void gstBox_TextChanged(object sender, EventArgs e)
        {
            totalPriceBox.Text = "$" + string.Format("{0:F2}", ((Convert.ToDouble(subTotalPriceBox.Text.Substring(1)) * 10 / 100)+ Convert.ToDouble(subTotalPriceBox.Text.Substring(1))));
        }
    }
}
