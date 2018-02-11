using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ticketing {
    public partial class formRegister : Form {
        MySqlConnection conn = new MySqlConnection("server=localhost; database=ticketing; uid=root; pwd=");
        MySqlCommand cmd;

        public formRegister() {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {
            txtUsername.MaxLength = 18;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e) {
            txtPassword.MaxLength = 12;
        }

        private void btnSeePassword_Click(object sender, EventArgs e) {
            txtPassword.UseSystemPasswordChar = false;

            btnSeePassword.Visible = false;
            btnUnseePassword.Visible = true;
        }

        private void btnUnseePassword_Click(object sender, EventArgs e) {
            txtPassword.UseSystemPasswordChar = true;

            btnSeePassword.Visible = true;
            btnUnseePassword.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure want to cancel?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK) {
                txtFullName.Text = "";
                txtUsername.Text = "";
                txtUsername.Text = "";

                this.Hide();
                formSignIn si = new formSignIn();
                si.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            if (txtFullName.Text == "") {
                MessageBox.Show("Full name must be filled!");
            } else if (txtUsername.Text == "") {
                MessageBox.Show("Username must be filled!");
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Password must be filled!");
            } else {
                try {
                    conn.Open();

                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "select username from user where username='" + txtUsername.Text + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(com);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) {
                        MessageBox.Show("Username is exist(s)!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    } else {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "insert into user (fullname, username, password, level) values (@fullname, @username, @password, 'Customer')";
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Register success!");

                        conn.Close();

                        txtFullName.Text = "";
                        txtUsername.Text = "";
                        txtPassword.Text = "";

                        this.Hide();
                        formSignIn si = new formSignIn();
                        si.Show();
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
