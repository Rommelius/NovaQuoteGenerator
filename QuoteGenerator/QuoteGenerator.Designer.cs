namespace QuoteGenerator
{
    partial class QuoteGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuoteGenerator));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.preparedByName = new System.Windows.Forms.ComboBox();
            this.quoteNumber = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.Label();
            this.todayDate = new System.Windows.Forms.Label();
            this.contactPersonBox = new System.Windows.Forms.TextBox();
            this.contactAddressBox = new System.Windows.Forms.TextBox();
            this.contactNumberBox = new System.Windows.Forms.TextBox();
            this.contactEmailBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.subTotalPriceBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gstBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.totalPriceBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescriptionColumn,
            this.QuantityColumn,
            this.PriceColumn});
            this.dataGrid.Location = new System.Drawing.Point(16, 411);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(815, 383);
            this.dataGrid.TabIndex = 12;
            this.dataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prepared by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quote No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valid Until";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Client Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contact Person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Contact Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Contact Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(463, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Contact Email";
            // 
            // preparedByName
            // 
            this.preparedByName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.preparedByName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.preparedByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparedByName.FormattingEnabled = true;
            this.preparedByName.Items.AddRange(new object[] {
            "Sean Welch",
            "Ken Welch",
            "Luke Brogan",
            "Rommel Lapuz",
            "Scott Monk",
            "Tonya Gillard"});
            this.preparedByName.Location = new System.Drawing.Point(149, 8);
            this.preparedByName.Margin = new System.Windows.Forms.Padding(4);
            this.preparedByName.Name = "preparedByName";
            this.preparedByName.Size = new System.Drawing.Size(208, 33);
            this.preparedByName.TabIndex = 1;
            this.preparedByName.Leave += new System.EventHandler(this.preparedByName_Leave);
            // 
            // quoteNumber
            // 
            this.quoteNumber.AutoSize = true;
            this.quoteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteNumber.Location = new System.Drawing.Point(144, 48);
            this.quoteNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoteNumber.Name = "quoteNumber";
            this.quoteNumber.Size = new System.Drawing.Size(209, 25);
            this.quoteNumber.TabIndex = 3;
            this.quoteNumber.Text = "Client Details Required";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(633, 48);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(99, 25);
            this.endDate.TabIndex = 3;
            this.endDate.Text = "Valid Until";
            // 
            // todayDate
            // 
            this.todayDate.AutoSize = true;
            this.todayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDate.Location = new System.Drawing.Point(633, 11);
            this.todayDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(53, 25);
            this.todayDate.TabIndex = 3;
            this.todayDate.Text = "Date";
            // 
            // contactPersonBox
            // 
            this.contactPersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPersonBox.Location = new System.Drawing.Point(195, 167);
            this.contactPersonBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactPersonBox.Name = "contactPersonBox";
            this.contactPersonBox.Size = new System.Drawing.Size(240, 30);
            this.contactPersonBox.TabIndex = 3;
            // 
            // contactAddressBox
            // 
            this.contactAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactAddressBox.Location = new System.Drawing.Point(195, 202);
            this.contactAddressBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactAddressBox.Name = "contactAddressBox";
            this.contactAddressBox.Size = new System.Drawing.Size(635, 30);
            this.contactAddressBox.TabIndex = 4;
            // 
            // contactNumberBox
            // 
            this.contactNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberBox.Location = new System.Drawing.Point(615, 133);
            this.contactNumberBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumberBox.Name = "contactNumberBox";
            this.contactNumberBox.Size = new System.Drawing.Size(215, 30);
            this.contactNumberBox.TabIndex = 5;
            // 
            // contactEmailBox
            // 
            this.contactEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactEmailBox.Location = new System.Drawing.Point(615, 167);
            this.contactEmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactEmailBox.Name = "contactEmailBox";
            this.contactEmailBox.Size = new System.Drawing.Size(215, 30);
            this.contactEmailBox.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 31);
            this.label11.TabIndex = 3;
            this.label11.Text = "Item Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 297);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Description";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 332);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 367);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(143, 363);
            this.priceBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(405, 30);
            this.priceBox.TabIndex = 9;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // descriptionBox
            // 
            this.descriptionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.descriptionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.FormattingEnabled = true;
            this.descriptionBox.Location = new System.Drawing.Point(143, 293);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(687, 33);
            this.descriptionBox.TabIndex = 7;
            this.descriptionBox.SelectedIndexChanged += new System.EventHandler(this.descriptionBox_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(557, 329);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(129, 66);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(143, 330);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(407, 30);
            this.quantityBox.TabIndex = 8;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(514, 917);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(316, 41);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Generate Quote";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(517, 801);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 25);
            this.label17.TabIndex = 13;
            this.label17.Text = "Sub Total:";
            // 
            // subTotalPriceBox
            // 
            this.subTotalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalPriceBox.Location = new System.Drawing.Point(637, 798);
            this.subTotalPriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.subTotalPriceBox.Name = "subTotalPriceBox";
            this.subTotalPriceBox.Size = new System.Drawing.Size(192, 30);
            this.subTotalPriceBox.TabIndex = 14;
            this.subTotalPriceBox.Text = "$0.00";
            this.subTotalPriceBox.TextChanged += new System.EventHandler(this.totalPriceBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(564, 844);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 25);
            this.label15.TabIndex = 15;
            this.label15.Text = "GST:";
            // 
            // gstBox
            // 
            this.gstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstBox.Location = new System.Drawing.Point(637, 837);
            this.gstBox.Margin = new System.Windows.Forms.Padding(4);
            this.gstBox.Name = "gstBox";
            this.gstBox.Size = new System.Drawing.Size(192, 30);
            this.gstBox.TabIndex = 16;
            this.gstBox.Text = "$0.00";
            this.gstBox.TextChanged += new System.EventHandler(this.gstBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(509, 881);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "Total Price:";
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceBox.Location = new System.Drawing.Point(637, 878);
            this.totalPriceBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.Size = new System.Drawing.Size(192, 30);
            this.totalPriceBox.TabIndex = 18;
            this.totalPriceBox.Text = "$0.00";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(701, 329);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(129, 66);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clientBox
            // 
            this.clientBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.clientBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.clientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBox.FormattingEnabled = true;
            this.clientBox.IntegralHeight = false;
            this.clientBox.ItemHeight = 25;
            this.clientBox.Location = new System.Drawing.Point(195, 130);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(240, 33);
            this.clientBox.TabIndex = 2;
            this.clientBox.SelectedIndexChanged += new System.EventHandler(this.clientBox_SelectedIndexChanged);
            this.clientBox.Leave += new System.EventHandler(this.clientBox_Leave);
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PriceColumn.HeaderText = "Price (each)";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // QuoteGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 972);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.totalPriceBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gstBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.subTotalPriceBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.contactAddressBox);
            this.Controls.Add(this.contactPersonBox);
            this.Controls.Add(this.contactEmailBox);
            this.Controls.Add(this.contactNumberBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.preparedByName);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.todayDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quoteNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuoteGenerator";
            this.Text = "Nova Biomedical Quote Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox preparedByName;
        private System.Windows.Forms.Label quoteNumber;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Label todayDate;
        private System.Windows.Forms.TextBox contactPersonBox;
        private System.Windows.Forms.TextBox contactAddressBox;
        private System.Windows.Forms.TextBox contactNumberBox;
        private System.Windows.Forms.TextBox contactEmailBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.ComboBox descriptionBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox subTotalPriceBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox gstBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox totalPriceBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
    }
}

