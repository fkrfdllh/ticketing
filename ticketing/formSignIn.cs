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
    public partial class formSignIn : Form {
        MySqlConnection conn = new MySqlConnection("server = localhost; database = ticketing; uid = fkrfdllh; pwd = 18januari");
        MySqlCommand cmd;

        public formSignIn() {
            InitializeComponent();

            seederUser();
            seederTransportationTypeAirplane();
            seederTransportationTypeTrain();
        }

        public void seederUser() {
            try {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from user where id = '1' and username = 'admin' and password = 'admin' and fullname = 'Administrator' and level = 'Admin'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0) {
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "insert into user (id, username, password, fullname, level) values ('1', 'admin', 'admin', 'Administrator', 'Admin')";
                    com.ExecuteNonQuery();

                    conn.Close();
                } else if (dataTable.Rows.Count == 1) {
                    conn.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public void seederTransportationTypeAirplane() {
            try {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from transportation_type where id = 1";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0) {
//                  Add seeder data for transportation airplane type
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "insert into transportation_type (id, description) values ('1', 'Airplane')";
                    com.ExecuteNonQuery();

                    conn.Close();
                } else if (dataTable.Rows.Count == 1) {
                    conn.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        public void seederTransportationTypeTrain() {
            try {
                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandText = "select * from transportation_type where id = 2";

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0) {
//                  Add seeder data for transportation train type
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "insert into transportation_type (id, description) values ('2', 'Train')";
                    com.ExecuteNonQuery();

                    conn.Close();
                } else if (dataTable.Rows.Count == 1) {
                    conn.Close();
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void redirectRegister_MouseMove(object sender, MouseEventArgs e) {
            redirectRegister.ForeColor = Color.Black;
        }

        private void redirectRegister_MouseLeave(object sender, EventArgs e) {
            redirectRegister.ForeColor = Color.Gray;
        }

        private void redirectRegister_Click(object sender, EventArgs e) {
            txtUsername.Text = "";
            txtPassword.Text = "";

            this.Hide();

            formRegister reg = new formRegister();
            reg.Show();
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

        private void txtUsername_TextChanged(object sender, EventArgs e) {
            txtUsername.MaxLength = 18;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e) {
            txtPassword.MaxLength = 12;
        }

        private void btnSignIn_Click(object sender, EventArgs e) {
            if (txtUsername.Text == "") {
                MessageBox.Show("Username must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Password must be filled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            } else {
                try {
                    conn.Open();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "select username from user where username = @username";
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 0) {
                        MessageBox.Show("Username is not match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    } else {
                        MySqlCommand com = conn.CreateCommand();
                        com.CommandText = "select password from user where password = @password";
                        com.Parameters.AddWithValue("@password", txtPassword.Text);

                        MySqlDataAdapter da = new MySqlDataAdapter(com);
                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        if (dt.Rows.Count == 0) {
                            MessageBox.Show("Password is not match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                        } else {
                            MySqlCommand command = conn.CreateCommand();
                            command.CommandText = "select * from user where username = @username";
                            command.Parameters.AddWithValue("@username", txtUsername.Text);

                            MySqlDataAdapter adapterLevel = new MySqlDataAdapter(command);
                            DataTable dtLevel = new DataTable();

                            adapterLevel.Fill(dtLevel);

                            if (dt.Rows.Count == 0) {
                                MessageBox.Show("No user registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                conn.Close();
                            } else {
                                MySqlDataReader reader = command.ExecuteReader();

                                if (reader.Read()) {
                                    string role = reader["level"].ToString();
                                    string fullName = reader["fullname"].ToString();

                                    this.Hide();

                                    if (role == "Customer") {
                                        MessageBox.Show("You're Customer!");

                                        conn.Close();
                                    } else if (role == "Admin") {
                                        conn.Close();

                                        formAdmin admin = new formAdmin();
                                        admin.Text = "Welcome, " + fullName + "!";
                                        admin.Show();
                                    }
                                }
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }
    }
}
