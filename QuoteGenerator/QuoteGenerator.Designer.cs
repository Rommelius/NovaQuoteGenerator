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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.locationBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescriptionColumn,
            this.QuantityColumn,
            this.PriceColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 311);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
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
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prepared by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quote No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valid Until";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Client Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contact Person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Contact Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Contact Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(347, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Contact Email";
            // 
            // preparedByName
            // 
            this.preparedByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparedByName.FormattingEnabled = true;
            this.preparedByName.Items.AddRange(new object[] {
            "Sean Welch",
            "Ken Welch",
            "Luke Brogan",
            "Rommel Lapuz",
            "Scott Monk",
            "Tonya Gillard"});
            this.preparedByName.Location = new System.Drawing.Point(112, 6);
            this.preparedByName.Name = "preparedByName";
            this.preparedByName.Size = new System.Drawing.Size(157, 28);
            this.preparedByName.TabIndex = 4;
            this.preparedByName.Leave += new System.EventHandler(this.preparedByName_Leave);
            // 
            // quoteNumber
            // 
            this.quoteNumber.AutoSize = true;
            this.quoteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteNumber.Location = new System.Drawing.Point(108, 39);
            this.quoteNumber.Name = "quoteNumber";
            this.quoteNumber.Size = new System.Drawing.Size(171, 20);
            this.quoteNumber.TabIndex = 3;
            this.quoteNumber.Text = "Client Details Required";
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(475, 39);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(80, 20);
            this.endDate.TabIndex = 3;
            this.endDate.Text = "Valid Until";
            // 
            // todayDate
            // 
            this.todayDate.AutoSize = true;
            this.todayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDate.Location = new System.Drawing.Point(475, 9);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(44, 20);
            this.todayDate.TabIndex = 3;
            this.todayDate.Text = "Date";
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBox.Location = new System.Drawing.Point(146, 108);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(181, 26);
            this.locationBox.TabIndex = 5;
            this.locationBox.Leave += new System.EventHandler(this.locationBox_Leave);
            // 
            // contactPersonBox
            // 
            this.contactPersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPersonBox.Location = new System.Drawing.Point(146, 136);
            this.contactPersonBox.Name = "contactPersonBox";
            this.contactPersonBox.Size = new System.Drawing.Size(181, 26);
            this.contactPersonBox.TabIndex = 5;
            // 
            // contactAddressBox
            // 
            this.contactAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactAddressBox.Location = new System.Drawing.Point(146, 164);
            this.contactAddressBox.Name = "contactAddressBox";
            this.contactAddressBox.Size = new System.Drawing.Size(477, 26);
            this.contactAddressBox.TabIndex = 5;
            // 
            // contactNumberBox
            // 
            this.contactNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberBox.Location = new System.Drawing.Point(461, 108);
            this.contactNumberBox.Name = "contactNumberBox";
            this.contactNumberBox.Size = new System.Drawing.Size(162, 26);
            this.contactNumberBox.TabIndex = 5;
            // 
            // contactEmailBox
            // 
            this.contactEmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactEmailBox.Location = new System.Drawing.Point(461, 136);
            this.contactEmailBox.Name = "contactEmailBox";
            this.contactEmailBox.Size = new System.Drawing.Size(162, 26);
            this.contactEmailBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Item Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Description";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBox.Location = new System.Drawing.Point(107, 295);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(305, 26);
            this.priceBox.TabIndex = 5;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.FormattingEnabled = true;
            this.descriptionBox.Location = new System.Drawing.Point(107, 238);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(516, 28);
            this.descriptionBox.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(418, 267);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(205, 54);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(107, 268);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(305, 26);
            this.quantityBox.TabIndex = 8;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(418, 745);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(205, 33);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Generate Quote";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(388, 651);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Sub Total:";
            // 
            // subTotalPriceBox
            // 
            this.subTotalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalPriceBox.Location = new System.Drawing.Point(478, 648);
            this.subTotalPriceBox.Name = "subTotalPriceBox";
            this.subTotalPriceBox.Size = new System.Drawing.Size(145, 26);
            this.subTotalPriceBox.TabIndex = 14;
            this.subTotalPriceBox.Text = "$0.00";
            this.subTotalPriceBox.TextChanged += new System.EventHandler(this.totalPriceBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(423, 686);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "GST:";
            // 
            // gstBox
            // 
            this.gstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstBox.Location = new System.Drawing.Point(478, 680);
            this.gstBox.Name = "gstBox";
            this.gstBox.Size = new System.Drawing.Size(145, 26);
            this.gstBox.TabIndex = 16;
            this.gstBox.Text = "$0.00";
            this.gstBox.TextChanged += new System.EventHandler(this.gstBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(382, 716);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Total Price:";
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceBox.Location = new System.Drawing.Point(478, 713);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.Size = new System.Drawing.Size(145, 26);
            this.totalPriceBox.TabIndex = 18;
            this.totalPriceBox.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 790);
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
            this.Controls.Add(this.locationBox);
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
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nova Biomedical Quote Generator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.TextBox locationBox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox subTotalPriceBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox gstBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox totalPriceBox;
    }
}

