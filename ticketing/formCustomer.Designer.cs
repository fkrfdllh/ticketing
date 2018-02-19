namespace ticketing {
    partial class formCustomer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.biodataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBiodata = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.txtGenderCustomer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneCustomer = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.idCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgBiodata = new System.Windows.Forms.DataGridView();
            this.pnlReservation = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshReservation = new System.Windows.Forms.Button();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.idRute = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDepartAt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSeatCode = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.idTransportationName = new System.Windows.Forms.Label();
            this.txtTransportationName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.idTransportationType = new System.Windows.Forms.Label();
            this.txtTransportationType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDCustomer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReservationAt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReservationCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.idUser = new System.Windows.Forms.Label();
            this.dgReservation = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.pnlBiodata.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBiodata)).BeginInit();
            this.pnlReservation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biodataToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // biodataToolStripMenuItem
            // 
            this.biodataToolStripMenuItem.Name = "biodataToolStripMenuItem";
            this.biodataToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.biodataToolStripMenuItem.Text = "Biodata";
            this.biodataToolStripMenuItem.Click += new System.EventHandler(this.biodataToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // pnlBiodata
            // 
            this.pnlBiodata.Controls.Add(this.label1);
            this.pnlBiodata.Controls.Add(this.txtSearchCustomer);
            this.pnlBiodata.Controls.Add(this.groupBox1);
            this.pnlBiodata.Controls.Add(this.dgBiodata);
            this.pnlBiodata.Location = new System.Drawing.Point(0, 27);
            this.pnlBiodata.Name = "pnlBiodata";
            this.pnlBiodata.Size = new System.Drawing.Size(484, 334);
            this.pnlBiodata.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(381, 160);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCustomer.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshCustomer);
            this.groupBox1.Controls.Add(this.btnUpdateCustomer);
            this.groupBox1.Controls.Add(this.btnCreateCustomer);
            this.groupBox1.Controls.Add(this.txtGenderCustomer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhoneCustomer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddressCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNameCustomer);
            this.groupBox1.Controls.Add(this.idCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Location = new System.Drawing.Point(0, 123);
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(478, 23);
            this.btnRefreshCustomer.TabIndex = 16;
            this.btnRefreshCustomer.Text = "Refresh";
            this.btnRefreshCustomer.UseVisualStyleBackColor = true;
            this.btnRefreshCustomer.Click += new System.EventHandler(this.btnRefreshCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(277, 89);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCustomer.TabIndex = 15;
            this.btnUpdateCustomer.Text = "Edit";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.Location = new System.Drawing.Point(358, 88);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCustomer.TabIndex = 14;
            this.btnCreateCustomer.Text = "Submit";
            this.btnCreateCustomer.UseVisualStyleBackColor = true;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // txtGenderCustomer
            // 
            this.txtGenderCustomer.FormattingEnabled = true;
            this.txtGenderCustomer.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGenderCustomer.Location = new System.Drawing.Point(294, 55);
            this.txtGenderCustomer.Name = "txtGenderCustomer";
            this.txtGenderCustomer.Size = new System.Drawing.Size(139, 21);
            this.txtGenderCustomer.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender";
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Location = new System.Drawing.Point(294, 29);
            this.txtPhoneCustomer.Mask = "+62 000-0000-0000";
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(139, 20);
            this.txtPhoneCustomer.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Location = new System.Drawing.Point(96, 55);
            this.txtAddressCustomer.Multiline = true;
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(139, 56);
            this.txtAddressCustomer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(96, 29);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(139, 20);
            this.txtNameCustomer.TabIndex = 6;
            // 
            // idCustomer
            // 
            this.idCustomer.AutoSize = true;
            this.idCustomer.Location = new System.Drawing.Point(39, 0);
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.Size = new System.Drawing.Size(0, 13);
            this.idCustomer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID :";
            // 
            // dgBiodata
            // 
            this.dgBiodata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBiodata.Location = new System.Drawing.Point(3, 3);
            this.dgBiodata.Name = "dgBiodata";
            this.dgBiodata.Size = new System.Drawing.Size(478, 150);
            this.dgBiodata.TabIndex = 0;
            this.dgBiodata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBiodata_CellClick);
            // 
            // pnlReservation
            // 
            this.pnlReservation.Controls.Add(this.groupBox2);
            this.pnlReservation.Controls.Add(this.dgReservation);
            this.pnlReservation.Location = new System.Drawing.Point(0, 27);
            this.pnlReservation.Name = "pnlReservation";
            this.pnlReservation.Size = new System.Drawing.Size(484, 334);
            this.pnlReservation.TabIndex = 2;
            this.pnlReservation.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshReservation);
            this.groupBox2.Controls.Add(this.btnCreateReservation);
            this.groupBox2.Controls.Add(this.idRute);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtDepartAt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtSeatCode);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.idTransportationName);
            this.groupBox2.Controls.Add(this.txtTransportationName);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.idTransportationType);
            this.groupBox2.Controls.Add(this.txtTransportationType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtIDCustomer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtReservationAt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtReservationCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.idUser);
            this.groupBox2.Location = new System.Drawing.Point(3, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 174);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnRefreshReservation
            // 
            this.btnRefreshReservation.Location = new System.Drawing.Point(142, 132);
            this.btnRefreshReservation.Name = "btnRefreshReservation";
            this.btnRefreshReservation.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshReservation.TabIndex = 39;
            this.btnRefreshReservation.Text = "Refresh";
            this.btnRefreshReservation.UseVisualStyleBackColor = true;
            this.btnRefreshReservation.Click += new System.EventHandler(this.btnRefreshReservation_Click);
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Location = new System.Drawing.Point(223, 132);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(75, 23);
            this.btnCreateReservation.TabIndex = 38;
            this.btnCreateReservation.Text = "Submit";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // idRute
            // 
            this.idRute.AutoSize = true;
            this.idRute.Location = new System.Drawing.Point(429, 157);
            this.idRute.Name = "idRute";
            this.idRute.Size = new System.Drawing.Size(50, 13);
            this.idRute.TabIndex = 37;
            this.idRute.Text = "ID Route";
            this.idRute.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(301, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Price";
            // 
            // txtDepartAt
            // 
            this.txtDepartAt.Enabled = false;
            this.txtDepartAt.Location = new System.Drawing.Point(303, 91);
            this.txtDepartAt.Name = "txtDepartAt";
            this.txtDepartAt.Size = new System.Drawing.Size(121, 20);
            this.txtDepartAt.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Depart At";
            // 
            // txtSeatCode
            // 
            this.txtSeatCode.FormattingEnabled = true;
            this.txtSeatCode.Location = new System.Drawing.Point(175, 91);
            this.txtSeatCode.Name = "txtSeatCode";
            this.txtSeatCode.Size = new System.Drawing.Size(121, 21);
            this.txtSeatCode.TabIndex = 32;
            this.txtSeatCode.Click += new System.EventHandler(this.txtSeatCode_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Seat Code";
            // 
            // idTransportationName
            // 
            this.idTransportationName.AutoSize = true;
            this.idTransportationName.Location = new System.Drawing.Point(49, 115);
            this.idTransportationName.Name = "idTransportationName";
            this.idTransportationName.Size = new System.Drawing.Size(120, 13);
            this.idTransportationName.TabIndex = 30;
            this.idTransportationName.Text = "ID Transportation Name";
            this.idTransportationName.Visible = false;
            this.idTransportationName.TextChanged += new System.EventHandler(this.idTransportationName_TextChanged);
            // 
            // txtTransportationName
            // 
            this.txtTransportationName.FormattingEnabled = true;
            this.txtTransportationName.Location = new System.Drawing.Point(48, 91);
            this.txtTransportationName.Name = "txtTransportationName";
            this.txtTransportationName.Size = new System.Drawing.Size(121, 21);
            this.txtTransportationName.TabIndex = 29;
            this.txtTransportationName.TextChanged += new System.EventHandler(this.txtTransportationName_TextChanged);
            this.txtTransportationName.Click += new System.EventHandler(this.txtTransportationName_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Transportation Name";
            // 
            // idTransportationType
            // 
            this.idTransportationType.AutoSize = true;
            this.idTransportationType.Location = new System.Drawing.Point(356, 13);
            this.idTransportationType.Name = "idTransportationType";
            this.idTransportationType.Size = new System.Drawing.Size(116, 13);
            this.idTransportationType.TabIndex = 27;
            this.idTransportationType.Text = "ID Transportation Type";
            this.idTransportationType.Visible = false;
            this.idTransportationType.TextChanged += new System.EventHandler(this.idTransportationType_TextChanged);
            // 
            // txtTransportationType
            // 
            this.txtTransportationType.FormattingEnabled = true;
            this.txtTransportationType.Location = new System.Drawing.Point(303, 45);
            this.txtTransportationType.Name = "txtTransportationType";
            this.txtTransportationType.Size = new System.Drawing.Size(121, 21);
            this.txtTransportationType.TabIndex = 26;
            this.txtTransportationType.TextChanged += new System.EventHandler(this.txtTransportationType_TextChanged);
            this.txtTransportationType.Click += new System.EventHandler(this.txtTransportationType_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Transportation Type";
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.FormattingEnabled = true;
            this.txtIDCustomer.Location = new System.Drawing.Point(175, 46);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.Size = new System.Drawing.Size(121, 21);
            this.txtIDCustomer.TabIndex = 24;
            this.txtIDCustomer.Click += new System.EventHandler(this.txtIDCustomer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID Customer";
            // 
            // txtReservationAt
            // 
            this.txtReservationAt.Location = new System.Drawing.Point(48, 47);
            this.txtReservationAt.Name = "txtReservationAt";
            this.txtReservationAt.Size = new System.Drawing.Size(121, 20);
            this.txtReservationAt.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Reservation At";
            // 
            // txtReservationCode
            // 
            this.txtReservationCode.AutoSize = true;
            this.txtReservationCode.Location = new System.Drawing.Point(107, -1);
            this.txtReservationCode.Name = "txtReservationCode";
            this.txtReservationCode.Size = new System.Drawing.Size(0, 13);
            this.txtReservationCode.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Reservation Code";
            // 
            // idUser
            // 
            this.idUser.AutoSize = true;
            this.idUser.Location = new System.Drawing.Point(6, 157);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(43, 13);
            this.idUser.TabIndex = 18;
            this.idUser.Text = "ID User";
            this.idUser.Visible = false;
            // 
            // dgReservation
            // 
            this.dgReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservation.Location = new System.Drawing.Point(3, 3);
            this.dgReservation.Name = "dgReservation";
            this.dgReservation.Size = new System.Drawing.Size(478, 150);
            this.dgReservation.TabIndex = 19;
            this.dgReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReservation_CellClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(304, 135);
            this.txtPrice.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 36;
            this.txtPrice.ThousandsSeparator = true;
            // 
            // formCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlReservation);
            this.Controls.Add(this.pnlBiodata);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBiodata.ResumeLayout(false);
            this.pnlBiodata.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBiodata)).EndInit();
            this.pnlReservation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem biodataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBiodata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.ComboBox txtGenderCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPhoneCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label idCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgBiodata;
        private System.Windows.Forms.Panel pnlReservation;
        private System.Windows.Forms.Label idUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgReservation;
        private System.Windows.Forms.ComboBox txtIDCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReservationAt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtReservationCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDepartAt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtSeatCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label idTransportationName;
        private System.Windows.Forms.ComboBox txtTransportationName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label idTransportationType;
        private System.Windows.Forms.ComboBox txtTransportationType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label idRute;
        private System.Windows.Forms.Button btnRefreshReservation;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.NumericUpDown txtPrice;
    }
}