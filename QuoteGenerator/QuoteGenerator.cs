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
using MySql.Data.MySqlClient;

namespace QuoteGenerator
{
    public partial class QuoteGenerator : Form
    {
        public static string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;
        //public static string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

        public static List<string> listofequipmentName = new List<string>();
        public static List<string> listofequipmentPrice = new List<string>();

        public static List<string> listofClientName = new List<string>();
        public static List<string> listofContactPerson = new List<string>();
        public static List<string> listofContactAddress = new List<string>();
        public static List<string> listofContactNumber = new List<string>();
        public static List<string> listofContactEmail = new List<string>();


        public bool YesNoSaveDestination;
        public static string saveDestination;
        public static string sqlConnectionString = "server=45.32.188.225; uid=rommel;" +
                                                    "pwd=sql2303;" +
                                                    "database=quotegeneratorDB;" +
                                                    "convert zero datetime=True";

        public static bool networkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

        public QuoteGenerator()
        {
            InitializeComponent();
            this.dataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceBox.Text = "$0.00";

            todayDate.Text = DateTime.Now.ToShortDateString();
            endDate.Text = DateTime.Now.AddMonths(1).ToShortDateString();

            if (networkUp)
            {
                GetDataForItemsSQL();
                GetDataforClientDetailsSQL();
            }
            else if(!networkUp)
            {
                //add the function to use local CSV
                MessageBox.Show("Internet is not connected, Please connect to the internet and try again");
            }

        }

        private void AddItemsSQL()
        {
            string query = "INSERT INTO DescriptionPriceTbl(Description,Price) VALUES(@description, @price)";

            MySqlConnection SQLConnection = new MySqlConnection(sqlConnectionString);
            MySqlCommand command = SQLConnection.CreateCommand();
            SQLConnection.Open();
            command.CommandText = query;
            command.Parameters.AddWithValue("@description", descriptionBox.Text);
            command.Parameters.AddWithValue("@price", priceBox.Text);
            command.ExecuteNonQuery();
            SQLConnection.Close();
        }

        private void GetDataForItemsSQL()
        {
            string query = "SELECT * FROM DescriptionPriceTbl ORDER BY Description";

            MySqlConnection SQLConnection = new MySqlConnection(sqlConnectionString);
            MySqlCommand command = new MySqlCommand(query, SQLConnection);
            
            SQLConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            
            try
            {
                while (reader.Read())
                {
                    listofequipmentName.Add(reader["Description"].ToString());
                    listofequipmentPrice.Add(reader["Price"].ToString());
                }
            }
            finally
            {
                // 3. close the reader
                if (reader != null)
                {
                    reader.Close();
                }

                // close the connection
                if (SQLConnection != null)
                {
                    SQLConnection.Close();
                }
            }

            //setup the descriptionbox clear first everytime.

            foreach (string item in listofequipmentName)
            {
                descriptionBox.Items.Add(item);
            }

        }
        private void GetDataforClientDetailsSQL()
        {
            string query = "SELECT * FROM ClientDetailsTbl ORDER BY ClientName";

            MySqlConnection SQLConnection = new MySqlConnection(sqlConnectionString);
            MySqlCommand command = new MySqlCommand(query, SQLConnection);

            SQLConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    listofClientName.Add(reader["ClientName"].ToString());
                    listofContactPerson.Add(reader["ContactPerson"].ToString());
                    listofContactNumber.Add(reader["ContactNumber"].ToString());
                    listofContactAddress.Add(reader["ContactAddress"].ToString());
                    listofContactEmail.Add(reader["ContactEmail"].ToString());
                }
            }
            finally
            {
                // 3. close the reader
                if (reader != null)
                {
                    reader.Close();
                }

                // close the connection
                if (SQLConnection != null)
                {
                    SQLConnection.Close();
                }
            }

            //setup the descriptionbox clear first everytime.

            foreach (string item in listofClientName)
            {
                clientBox.Items.Add(item);
            }
        }

        private void UpdateClientSQL()
        {
            string query = "UPDATE ClientDetailsTbl SET ContactPerson=@contactperson,ContactAddress=@contactaddrress,ContactNumber=@contactnumber,ContactEmail=@contactemail WHERE ClientName=@clientname";
            
            MySqlConnection SQLConnection = new MySqlConnection(sqlConnectionString);
            MySqlCommand command = SQLConnection.CreateCommand();
            SQLConnection.Open();
            command.CommandText = query;
            command.Parameters.AddWithValue("@clientname", clientBox.Text);
            command.Parameters.AddWithValue("@contactperson", contactPersonBox.Text);
            command.Parameters.AddWithValue("@contactaddrress", contactAddressBox.Text);
            command.Parameters.AddWithValue("@contactnumber", contactNumberBox.Text);
            command.Parameters.AddWithValue("@contactemail", contactEmailBox.Text);
            command.ExecuteNonQuery();
            SQLConnection.Close();
        }
        private void AddClientSQL()
        {
            string query = "INSERT INTO ClientDetailsTbl(ClientName,ContactPerson,ContactAddress,ContactNumber,ContactEmail) " +
                            "VALUES(@clientname, @contactperson, @contactaddrress, @contactnumber, @contactemail)";
            MySqlConnection SQLConnection = new MySqlConnection(sqlConnectionString);
            MySqlCommand command = SQLConnection.CreateCommand();
            SQLConnection.Open();
            command.CommandText = query;
            command.Parameters.AddWithValue("@clientname", clientBox.Text);
            command.Parameters.AddWithValue("@contactperson", contactPersonBox.Text);
            command.Parameters.AddWithValue("@contactaddrress", contactAddressBox.Text);
            command.Parameters.AddWithValue("@contactnumber", contactNumberBox.Text);
            command.Parameters.AddWithValue("@contactemail", contactEmailBox.Text);
            command.ExecuteNonQuery();
            SQLConnection.Close();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
           if (descriptionBox.Text != "" && priceBox.Text != "$0.00")
            {
                if (!listofequipmentName.Contains(descriptionBox.Text))
                {
                    DialogResult dg = MessageBox.Show("Would you like to add this item on the database?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dg == DialogResult.OK)
                    {
                        //clear first
                        descriptionBox.Items.Clear();
                        listofequipmentName.Clear();
                        listofequipmentPrice.Clear();

                        if (networkUp)
                        {
                            //add to the database
                            AddItemsSQL();
                            GetDataForItemsSQL();
                            MessageBox.Show("Item added successfully to the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else if (!networkUp)
                        {
                            //add the function to use local CSV
                            MessageBox.Show("Internet is not connected","Error adding item to the database",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    if (dg == DialogResult.Cancel)
                    {
                        descriptionBox.Text = "";
                        quantityBox.Value = 0;
                        priceBox.Text = "$0.00";
                        descriptionBox.Focus();
                    }
                }
                this.dataGrid.Rows.Add(descriptionBox.Text, quantityBox.Text, priceBox.Text.Substring(1));
                descriptionBox.Text = "";
                quantityBox.Value = 0;
                priceBox.Text = "$0.00";
                descriptionBox.Focus();
            }
            else
            {
                MessageBox.Show("Please Fill in the Description and Price of the item you want to add on the quote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                descriptionBox.Focus();
            }
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (clientBox.Text != "" && contactPersonBox.Text != "" && contactNumberBox.Text != "")
            {
                if (listofClientName.Contains(clientBox.Text))
                {
                    if (!listofContactPerson.Contains(contactPersonBox.Text) ||
                        !listofContactAddress.Contains(contactAddressBox.Text) || !listofContactNumber.Contains(contactNumberBox.Text) ||
                        !listofContactEmail.Contains(contactEmailBox.Text))
                    {
                        DialogResult dgUpdate = MessageBox.Show("Would you like to update this client on the database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dgUpdate == DialogResult.Yes)
                        {
                            //clear first
                            clientBox.Items.Clear();
                            listofClientName.Clear();
                            listofContactAddress.Clear();
                            listofContactPerson.Clear();
                            listofContactNumber.Clear();
                            listofContactEmail.Clear();

                            if (networkUp)
                            {
                                //add to the database
                                UpdateClientSQL();
                                GetDataforClientDetailsSQL();
                                MessageBox.Show("Client updated successfully to the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else if (!networkUp)
                            {
                                //add the function to use local CSV
                                MessageBox.Show("Internet is not connected", "Error updating client to the database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (!listofClientName.Contains(clientBox.Text))
                {
                    DialogResult dgAdd = MessageBox.Show("Would you like to add this client on the database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dgAdd == DialogResult.Yes)
                    {
                        //clear first
                        clientBox.Items.Clear();
                        listofClientName.Clear();
                        listofContactAddress.Clear();
                        listofContactPerson.Clear();
                        listofContactNumber.Clear();
                        listofContactEmail.Clear();

                        if (networkUp)
                        {
                            //add to the database
                            AddClientSQL();
                            GetDataforClientDetailsSQL();
                            MessageBox.Show("Client added successfully to the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else if (!networkUp)
                        {
                            //add the function to use local CSV
                            MessageBox.Show("Internet is not connected", "Error adding client to the database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                EditDocument();
                System.Diagnostics.Process.Start(saveDestination + "/" + quoteNumber.Text + "-" + clientBox.Text + "-QUOTE" + ".pdf");
                DialogResult dgRestart = MessageBox.Show("Would you like to create another quote?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dgRestart == DialogResult.Yes)
                {
                    Application.Restart();
                }
                if (dgRestart == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Fill in the Client Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientBox.Focus();
            }



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

            wordApp.Visible = false;
            Word.Document wDoc = wordApp.Documents.Open(appRootDir + "/Nova Biomedical Quote TEMPLATE.docx"); ;

            // Activate the document
            wDoc.Activate();

            wDoc.Bookmarks["start"].Select();
            foreach (DataGridViewRow row in dataGrid.Rows)
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
            FindAndReplace(wordApp, "<Client>", clientBox.Text);
            FindAndReplace(wordApp, "<ClientName>", contactPersonBox.Text);
            FindAndReplace(wordApp, "<ClientNumber>", contactNumberBox.Text);
            FindAndReplace(wordApp, "<ClientAddress>", contactAddressBox.Text);
            FindAndReplace(wordApp, "<ClientEmail>", contactEmailBox.Text);
            //Prices
            FindAndReplace(wordApp, "<Subtotal>", subTotalPriceBox.Text.Substring(1));
            FindAndReplace(wordApp, "<GST>", string.Format("{0:F2}", Convert.ToDouble(subTotalPriceBox.Text.Substring(1)) * 10 / 100));
            FindAndReplace(wordApp, "<TotalPrice>", string.Format("{0:F2}", ( Convert.ToDouble(subTotalPriceBox.Text.Substring(1)) * 10 / 100) + Convert.ToDouble(subTotalPriceBox.Text.Substring(1))));

            wDoc.ExportAsFixedFormat(saveDestination + "/" + quoteNumber.Text+ "-" +  clientBox.Text + "-QUOTE" + ".pdf", Word.WdExportFormat.wdExportFormatPDF);
                        

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
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                a = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[1].Value);
                b = b + a;
            }
            subTotalPriceBox.Text = "$"+string.Format("{0:F2}", b);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double a = 0, b = 0;
            foreach (DataGridViewRow row in dataGrid.Rows)
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
            if (clientBox.Text != "" && preparedByName.Text != "")
            {
                int wc = WordsCount(clientBox.Text);
                if (wc <= 1)
                {
                    string s = new string(preparedByName.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());

                    quoteNumber.Text = s.ToUpper() + clientBox.Text.Substring(0, 3).ToUpper() + DateTime.Now.Day.ToString() +DateTime.Now.Month.ToString();
                }
                else
                {
                    string s = new string(clientBox.Text
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
            if (clientBox.Text != "" && preparedByName.Text != "")
            {
                int wc = WordsCount(clientBox.Text);
                if (wc <= 1)
                {
                    string s = new string(preparedByName.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());

                    quoteNumber.Text = s.ToUpper() + clientBox.Text.Substring(0, 3).ToUpper() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
                }
                else
                {
                    string s = new string(clientBox.Text
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

        private void descriptionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //starts at 0
            int indexPosition = descriptionBox.SelectedIndex;

            priceBox.Text = listofequipmentPrice[indexPosition].ToString();
            quantityBox.Value = 1;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewCell oneCell in dataGrid.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataGrid.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGrid.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGrid.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void clientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexPosition = clientBox.SelectedIndex;

            contactPersonBox.Text = listofContactPerson[indexPosition];
            contactAddressBox.Text = listofContactAddress[indexPosition];
            contactNumberBox.Text = listofContactNumber[indexPosition];
            contactEmailBox.Text = listofContactEmail[indexPosition];



        }

        private void clientBox_Leave(object sender, EventArgs e)
        {
            if (clientBox.Text != "" && preparedByName.Text != "")
            {
                int wc = WordsCount(clientBox.Text);
                if (wc <= 1)
                {
                    string s = new string(preparedByName.Text
                         .Split(' ')
                         .Select(x => x.First())
                         .ToArray());

                    quoteNumber.Text = s.ToUpper() + clientBox.Text.Substring(0, 3).ToUpper() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString();
                }
                else
                {
                    string s = new string(clientBox.Text
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
    }
}
