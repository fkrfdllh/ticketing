namespace ticketing {
    partial class formAdmin {
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
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.transportationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportaionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTransportation = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idTransportationType = new System.Windows.Forms.Label();
            this.btnRefreshTransportation = new System.Windows.Forms.Button();
            this.btnDeleteTransportation = new System.Windows.Forms.Button();
            this.btnUpdateTransportation = new System.Windows.Forms.Button();
            this.btnCreateTransportation = new System.Windows.Forms.Button();
            this.txtDescriptionTransportation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeatQtyTransportation = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTransportationType = new System.Windows.Forms.ComboBox();
            this.txtCodeTransportation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchTransportation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTransportation = new System.Windows.Forms.Label();
            this.dgTransportation = new System.Windows.Forms.DataGridView();
            this.pnlRute = new System.Windows.Forms.Panel();
            this.dgRute = new System.Windows.Forms.DataGridView();
            this.txtSearchRute = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTransportation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepartAt = new System.Windows.Forms.TextBox();
            this.txtRuteFrom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRuteTo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.idTransportationRute = new System.Windows.Forms.Label();
            this.idRute = new System.Windows.Forms.Label();
            this.btnRefreshRute = new System.Windows.Forms.Button();
            this.btnDeleteRute = new System.Windows.Forms.Button();
            this.btnUpdateRute = new System.Windows.Forms.Button();
            this.btnCreateRute = new System.Windows.Forms.Button();
            this.msAdmin.SuspendLayout();
            this.pnlTransportation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeatQtyTransportation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransportation)).BeginInit();
            this.pnlRute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRute)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // msAdmin
            // 
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transportationToolStripMenuItem,
            this.btnLogout});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(459, 24);
            this.msAdmin.TabIndex = 0;
            this.msAdmin.Text = "menuStrip1";
            // 
            // transportationToolStripMenuItem
            // 
            this.transportationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transportaionToolStripMenuItem,
            this.ruteToolStripMenuItem});
            this.transportationToolStripMenuItem.Name = "transportationToolStripMenuItem";
            this.transportationToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.transportationToolStripMenuItem.Text = "Transportation";
            // 
            // transportaionToolStripMenuItem
            // 
            this.transportaionToolStripMenuItem.Name = "transportaionToolStripMenuItem";
            this.transportaionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transportaionToolStripMenuItem.Text = "Transportaion";
            this.transportaionToolStripMenuItem.Click += new System.EventHandler(this.transportaionToolStripMenuItem_Click);
            // 
            // ruteToolStripMenuItem
            // 
            this.ruteToolStripMenuItem.Name = "ruteToolStripMenuItem";
            this.ruteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ruteToolStripMenuItem.Text = "Route";
            this.ruteToolStripMenuItem.Click += new System.EventHandler(this.ruteToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 20);
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // pnlTransportation
            // 
            this.pnlTransportation.Controls.Add(this.groupBox1);
            this.pnlTransportation.Controls.Add(this.txtSearchTransportation);
            this.pnlTransportation.Controls.Add(this.label1);
            this.pnlTransportation.Controls.Add(this.idTransportation);
            this.pnlTransportation.Controls.Add(this.dgTransportation);
            this.pnlTransportation.Location = new System.Drawing.Point(0, 27);
            this.pnlTransportation.Name = "pnlTransportation";
            this.pnlTransportation.Size = new System.Drawing.Size(459, 334);
            this.pnlTransportation.TabIndex = 1;
            this.pnlTransportation.Click += new System.EventHandler(this.pnlTransportation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTransportationType);
            this.groupBox1.Controls.Add(this.btnRefreshTransportation);
            this.groupBox1.Controls.Add(this.btnDeleteTransportation);
            this.groupBox1.Controls.Add(this.btnUpdateTransportation);
            this.groupBox1.Controls.Add(this.btnCreateTransportation);
            this.groupBox1.Controls.Add(this.txtDescriptionTransportation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSeatQtyTransportation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTransportationType);
            this.groupBox1.Controls.Add(this.txtCodeTransportation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // idTransportationType
            // 
            this.idTransportationType.AutoSize = true;
            this.idTransportationType.Location = new System.Drawing.Point(60, 55);
            this.idTransportationType.Name = "idTransportationType";
            this.idTransportationType.Size = new System.Drawing.Size(18, 13);
            this.idTransportationType.TabIndex = 13;
            this.idTransportationType.Text = "ID";
            this.idTransportationType.Visible = false;
            // 
            // btnRefreshTransportation
            // 
            this.btnRefreshTransportation.Location = new System.Drawing.Point(304, 97);
            this.btnRefreshTransportation.Name = "btnRefreshTransportation";
            this.btnRefreshTransportation.Size = new System.Drawing.Size(57, 23);
            this.btnRefreshTransportation.TabIndex = 12;
            this.btnRefreshTransportation.Text = "Refresh";
            this.btnRefreshTransportation.UseVisualStyleBackColor = true;
            this.btnRefreshTransportation.Click += new System.EventHandler(this.btnRefreshTransportation_Click);
            // 
            // btnDeleteTransportation
            // 
            this.btnDeleteTransportation.Location = new System.Drawing.Point(241, 96);
            this.btnDeleteTransportation.Name = "btnDeleteTransportation";
            this.btnDeleteTransportation.Size = new System.Drawing.Size(57, 23);
            this.btnDeleteTransportation.TabIndex = 11;
            this.btnDeleteTransportation.Text = "Delete";
            this.btnDeleteTransportation.UseVisualStyleBackColor = true;
            this.btnDeleteTransportation.Click += new System.EventHandler(this.btnDeleteTransportation_Click);
            // 
            // btnUpdateTransportation
            // 
            this.btnUpdateTransportation.Location = new System.Drawing.Point(304, 72);
            this.btnUpdateTransportation.Name = "btnUpdateTransportation";
            this.btnUpdateTransportation.Size = new System.Drawing.Size(57, 23);
            this.btnUpdateTransportation.TabIndex = 10;
            this.btnUpdateTransportation.Text = "Edit";
            this.btnUpdateTransportation.UseVisualStyleBackColor = true;
            this.btnUpdateTransportation.Click += new System.EventHandler(this.btnUpdateTransportation_Click);
            // 
            // btnCreateTransportation
            // 
            this.btnCreateTransportation.Location = new System.Drawing.Point(241, 72);
            this.btnCreateTransportation.Name = "btnCreateTransportation";
            this.btnCreateTransportation.Size = new System.Drawing.Size(57, 23);
            this.btnCreateTransportation.TabIndex = 9;
            this.btnCreateTransportation.Text = "Insert";
            this.btnCreateTransportation.UseVisualStyleBackColor = true;
            this.btnCreateTransportation.Click += new System.EventHandler(this.btnCreateTransportation_Click);
            // 
            // txtDescriptionTransportation
            // 
            this.txtDescriptionTransportation.Location = new System.Drawing.Point(101, 99);
            this.txtDescriptionTransportation.Name = "txtDescriptionTransportation";
            this.txtDescriptionTransportation.Size = new System.Drawing.Size(121, 20);
            this.txtDescriptionTransportation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Transportation Name";
            // 
            // txtSeatQtyTransportation
            // 
            this.txtSeatQtyTransportation.Location = new System.Drawing.Point(241, 49);
            this.txtSeatQtyTransportation.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtSeatQtyTransportation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSeatQtyTransportation.Name = "txtSeatQtyTransportation";
            this.txtSeatQtyTransportation.Size = new System.Drawing.Size(120, 20);
            this.txtSeatQtyTransportation.TabIndex = 6;
            this.txtSeatQtyTransportation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seat Quantity";
            // 
            // cbTransportationType
            // 
            this.cbTransportationType.FormattingEnabled = true;
            this.cbTransportationType.Location = new System.Drawing.Point(101, 49);
            this.cbTransportationType.Name = "cbTransportationType";
            this.cbTransportationType.Size = new System.Drawing.Size(121, 21);
            this.cbTransportationType.TabIndex = 4;
            this.cbTransportationType.SelectedIndexChanged += new System.EventHandler(this.cbTransportationType_SelectedIndexChanged);
            this.cbTransportationType.TextChanged += new System.EventHandler(this.cbTransportationType_TextChanged);
            this.cbTransportationType.Click += new System.EventHandler(this.cbTransportationType_Click);
            // 
            // txtCodeTransportation
            // 
            this.txtCodeTransportation.AutoSize = true;
            this.txtCodeTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeTransportation.ForeColor = System.Drawing.Color.Gray;
            this.txtCodeTransportation.Location = new System.Drawing.Point(58, 0);
            this.txtCodeTransportation.Name = "txtCodeTransportation";
            this.txtCodeTransportation.Size = new System.Drawing.Size(0, 13);
            this.txtCodeTransportation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Transportation Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code :";
            // 
            // txtSearchTransportation
            // 
            this.txtSearchTransportation.Location = new System.Drawing.Point(356, 159);
            this.txtSearchTransportation.Name = "txtSearchTransportation";
            this.txtSearchTransportation.Size = new System.Drawing.Size(100, 20);
            this.txtSearchTransportation.TabIndex = 3;
            this.txtSearchTransportation.TextChanged += new System.EventHandler(this.txtSearchTransportation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // idTransportation
            // 
            this.idTransportation.AutoSize = true;
            this.idTransportation.Location = new System.Drawing.Point(447, 312);
            this.idTransportation.Name = "idTransportation";
            this.idTransportation.Size = new System.Drawing.Size(0, 13);
            this.idTransportation.TabIndex = 1;
            this.idTransportation.Visible = false;
            // 
            // dgTransportation
            // 
            this.dgTransportation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransportation.Location = new System.Drawing.Point(3, 3);
            this.dgTransportation.Name = "dgTransportation";
            this.dgTransportation.Size = new System.Drawing.Size(453, 150);
            this.dgTransportation.TabIndex = 0;
            this.dgTransportation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransportation_CellClick);
            // 
            // pnlRute
            // 
            this.pnlRute.Controls.Add(this.groupBox2);
            this.pnlRute.Controls.Add(this.txtSearchRute);
            this.pnlRute.Controls.Add(this.label6);
            this.pnlRute.Controls.Add(this.dgRute);
            this.pnlRute.Location = new System.Drawing.Point(0, 24);
            this.pnlRute.Name = "pnlRute";
            this.pnlRute.Size = new System.Drawing.Size(459, 334);
            this.pnlRute.TabIndex = 2;
            this.pnlRute.Click += new System.EventHandler(this.pnlRute_Click);
            // 
            // dgRute
            // 
            this.dgRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRute.Location = new System.Drawing.Point(3, 3);
            this.dgRute.Name = "dgRute";
            this.dgRute.Size = new System.Drawing.Size(453, 150);
            this.dgRute.TabIndex = 0;
            this.dgRute.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRute_CellClick);
            // 
            // txtSearchRute
            // 
            this.txtSearchRute.Location = new System.Drawing.Point(356, 158);
            this.txtSearchRute.Name = "txtSearchRute";
            this.txtSearchRute.Size = new System.Drawing.Size(100, 20);
            this.txtSearchRute.TabIndex = 5;
            this.txtSearchRute.TextChanged += new System.EventHandler(this.txtSearchRute_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshRute);
            this.groupBox2.Controls.Add(this.btnDeleteRute);
            this.groupBox2.Controls.Add(this.btnUpdateRute);
            this.groupBox2.Controls.Add(this.btnCreateRute);
            this.groupBox2.Controls.Add(this.idRute);
            this.groupBox2.Controls.Add(this.idTransportationRute);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtRuteTo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtRuteFrom);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDepartAt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbTransportation);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(3, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 146);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Transportation Name";
            // 
            // cbTransportation
            // 
            this.cbTransportation.FormattingEnabled = true;
            this.cbTransportation.Location = new System.Drawing.Point(12, 33);
            this.cbTransportation.Name = "cbTransportation";
            this.cbTransportation.Size = new System.Drawing.Size(121, 21);
            this.cbTransportation.TabIndex = 1;
            this.cbTransportation.TextChanged += new System.EventHandler(this.cbTransportation_TextChanged);
            this.cbTransportation.Click += new System.EventHandler(this.cbTransportation_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Depart At";
            // 
            // txtDepartAt
            // 
            this.txtDepartAt.Location = new System.Drawing.Point(12, 85);
            this.txtDepartAt.Name = "txtDepartAt";
            this.txtDepartAt.Size = new System.Drawing.Size(121, 20);
            this.txtDepartAt.TabIndex = 3;
            // 
            // txtRuteFrom
            // 
            this.txtRuteFrom.Location = new System.Drawing.Point(164, 33);
            this.txtRuteFrom.Name = "txtRuteFrom";
            this.txtRuteFrom.Size = new System.Drawing.Size(121, 20);
            this.txtRuteFrom.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Route From";
            // 
            // txtRuteTo
            // 
            this.txtRuteTo.Location = new System.Drawing.Point(164, 85);
            this.txtRuteTo.Name = "txtRuteTo";
            this.txtRuteTo.Size = new System.Drawing.Size(121, 20);
            this.txtRuteTo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Route To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPrice.Location = new System.Drawing.Point(309, 34);
            this.txtPrice.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(120, 20);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.ThousandsSeparator = true;
            // 
            // idTransportationRute
            // 
            this.idTransportationRute.AutoSize = true;
            this.idTransportationRute.Location = new System.Drawing.Point(133, 16);
            this.idTransportationRute.Name = "idTransportationRute";
            this.idTransportationRute.Size = new System.Drawing.Size(0, 13);
            this.idTransportationRute.TabIndex = 10;
            this.idTransportationRute.Visible = false;
            // 
            // idRute
            // 
            this.idRute.AutoSize = true;
            this.idRute.Location = new System.Drawing.Point(429, 127);
            this.idRute.Name = "idRute";
            this.idRute.Size = new System.Drawing.Size(0, 13);
            this.idRute.TabIndex = 11;
            this.idRute.Visible = false;
            // 
            // btnRefreshRute
            // 
            this.btnRefreshRute.Location = new System.Drawing.Point(372, 88);
            this.btnRefreshRute.Name = "btnRefreshRute";
            this.btnRefreshRute.Size = new System.Drawing.Size(57, 23);
            this.btnRefreshRute.TabIndex = 16;
            this.btnRefreshRute.Text = "Refresh";
            this.btnRefreshRute.UseVisualStyleBackColor = true;
            this.btnRefreshRute.Click += new System.EventHandler(this.btnRefreshRute_Click);
            // 
            // btnDeleteRute
            // 
            this.btnDeleteRute.Location = new System.Drawing.Point(309, 87);
            this.btnDeleteRute.Name = "btnDeleteRute";
            this.btnDeleteRute.Size = new System.Drawing.Size(57, 23);
            this.btnDeleteRute.TabIndex = 15;
            this.btnDeleteRute.Text = "Delete";
            this.btnDeleteRute.UseVisualStyleBackColor = true;
            this.btnDeleteRute.Click += new System.EventHandler(this.btnDeleteRute_Click);
            // 
            // btnUpdateRute
            // 
            this.btnUpdateRute.Location = new System.Drawing.Point(372, 63);
            this.btnUpdateRute.Name = "btnUpdateRute";
            this.btnUpdateRute.Size = new System.Drawing.Size(57, 23);
            this.btnUpdateRute.TabIndex = 14;
            this.btnUpdateRute.Text = "Edit";
            this.btnUpdateRute.UseVisualStyleBackColor = true;
            this.btnUpdateRute.Click += new System.EventHandler(this.btnUpdateRute_Click);
            // 
            // btnCreateRute
            // 
            this.btnCreateRute.Location = new System.Drawing.Point(309, 63);
            this.btnCreateRute.Name = "btnCreateRute";
            this.btnCreateRute.Size = new System.Drawing.Size(57, 23);
            this.btnCreateRute.TabIndex = 13;
            this.btnCreateRute.Text = "Insert";
            this.btnCreateRute.UseVisualStyleBackColor = true;
            this.btnCreateRute.Click += new System.EventHandler(this.btnCreateRute_Click);
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 361);
            this.Controls.Add(this.msAdmin);
            this.Controls.Add(this.pnlRute);
            this.Controls.Add(this.pnlTransportation);
            this.MainMenuStrip = this.msAdmin;
            this.Name = "formAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.pnlTransportation.ResumeLayout(false);
            this.pnlTransportation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeatQtyTransportation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransportation)).EndInit();
            this.pnlRute.ResumeLayout(false);
            this.pnlRute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRute)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem transportationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportaionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruteToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTransportation;
        private System.Windows.Forms.DataGridView dgTransportation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshTransportation;
        private System.Windows.Forms.Button btnDeleteTransportation;
        private System.Windows.Forms.Button btnUpdateTransportation;
        private System.Windows.Forms.Button btnCreateTransportation;
        private System.Windows.Forms.TextBox txtDescriptionTransportation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtSeatQtyTransportation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTransportationType;
        private System.Windows.Forms.Label txtCodeTransportation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchTransportation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idTransportation;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.Label idTransportationType;
        private System.Windows.Forms.Panel pnlRute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefreshRute;
        private System.Windows.Forms.Button btnDeleteRute;
        private System.Windows.Forms.Button btnUpdateRute;
        private System.Windows.Forms.Button btnCreateRute;
        private System.Windows.Forms.Label idRute;
        private System.Windows.Forms.Label idTransportationRute;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRuteTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRuteFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDepartAt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTransportation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchRute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgRute;
    }
}