namespace ticketing {
    partial class formSignIn {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.redirectRegister = new System.Windows.Forms.Label();
            this.btnSeePassword = new System.Windows.Forms.PictureBox();
            this.btnUnseePassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnseePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(24, 35);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(24, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(99, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Location = new System.Drawing.Point(24, 110);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(125, 23);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // redirectRegister
            // 
            this.redirectRegister.AutoSize = true;
            this.redirectRegister.BackColor = System.Drawing.Color.White;
            this.redirectRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redirectRegister.ForeColor = System.Drawing.Color.Gray;
            this.redirectRegister.Location = new System.Drawing.Point(12, 145);
            this.redirectRegister.Name = "redirectRegister";
            this.redirectRegister.Size = new System.Drawing.Size(149, 13);
            this.redirectRegister.TabIndex = 5;
            this.redirectRegister.Text = "Not registered yet? Click here.";
            this.redirectRegister.Click += new System.EventHandler(this.redirectRegister_Click);
            this.redirectRegister.MouseLeave += new System.EventHandler(this.redirectRegister_MouseLeave);
            this.redirectRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.redirectRegister_MouseMove);
            // 
            // btnSeePassword
            // 
            this.btnSeePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeePassword.Image = global::ticketing.Properties.Resources.eye_24_256;
            this.btnSeePassword.Location = new System.Drawing.Point(129, 84);
            this.btnSeePassword.Name = "btnSeePassword";
            this.btnSeePassword.Size = new System.Drawing.Size(20, 20);
            this.btnSeePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSeePassword.TabIndex = 6;
            this.btnSeePassword.TabStop = false;
            this.btnSeePassword.Click += new System.EventHandler(this.btnSeePassword_Click);
            // 
            // btnUnseePassword
            // 
            this.btnUnseePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnseePassword.Image = global::ticketing.Properties.Resources._1319644_200;
            this.btnUnseePassword.Location = new System.Drawing.Point(129, 84);
            this.btnUnseePassword.Name = "btnUnseePassword";
            this.btnUnseePassword.Size = new System.Drawing.Size(20, 20);
            this.btnUnseePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUnseePassword.TabIndex = 7;
            this.btnUnseePassword.TabStop = false;
            this.btnUnseePassword.Visible = false;
            this.btnUnseePassword.Click += new System.EventHandler(this.btnUnseePassword_Click);
            // 
            // formSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(172, 169);
            this.Controls.Add(this.btnSeePassword);
            this.Controls.Add(this.redirectRegister);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnseePassword);
            this.Name = "formSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.btnSeePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnseePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label redirectRegister;
        private System.Windows.Forms.PictureBox btnSeePassword;
        private System.Windows.Forms.PictureBox btnUnseePassword;
    }
}

