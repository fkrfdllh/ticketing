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
    public partial class formAdmin : Form {
        MySqlConnection conn = new MySqlConnection("server = localhost; database = ticketing; uid = fkrfdllh; pwd = 18januari");
        MySqlCommand cmd;

        public formAdmin() {
            InitializeComponent();

            seeTransportation();
            seeRute();

            loadTransportationType();
            loadTransportationName();

            generateCodeTransportation();
        }

        public void seeTransportation() {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select transportation.id, transportation_type.description, transportation.code, transportation.description, transportation.seat_qty from transportation_type, transportation where transportation_type.id = transportation.transportation_typeid";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            dgTransportation.DataSource = ds.Tables[0].DefaultView;

            conn.Close();
        }

        public void seeRute() {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select rute.id, transportation.description, rute.depart_at, rute.rute_from, rute.rute_to, rute.price from transportation, rute where transportation.id = rute.transportationid";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            dgRute.DataSource = ds.Tables[0].DefaultView;

            conn.Close();
        }

        public void loadTransportationType() {
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select description from transportation_type";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter1.Fill(dt);

            if (dt.Rows.Count == 0) {
                return;
            } else {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    cbTransportationType.Refresh();
                    cbTransportationType.Items.Add(reader.GetString("description"));
                    cbTransportationType.Update();
                }
                conn.Close();
            }
        }

        public void loadTransportationName() {
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select description from transportation";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter1.Fill(dt);

            if (dt.Rows.Count == 0) {
                return;
            } else {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    cbTransportation.BeginUpdate();
                    cbTransportation.Items.Add(reader.GetString("description"));
                    cbTransportation.EndUpdate();
                }
                conn.Close();
            }
        }

        public void generateCodeTransportation() {
            Random r = new Random();
            int rInt = r.Next(0, 100000000);

            if (cbTransportationType.Text == "Train") {
                txtCodeTransportation.Text = "T-" + rInt;
            } else if (cbTransportationType.Text == "Airplane") {
                txtCodeTransportation.Text = "A-" + rInt;
            }
        }

        public void dgTransportationClick() {
            int row = dgTransportation.CurrentCell.RowIndex;

            idTransportation.Text = dgTransportation.Rows[row].Cells[0].Value.ToString();
            cbTransportationType.Text = dgTransportation.Rows[row].Cells[1].Value.ToString();
            txtCodeTransportation.Text = dgTransportation.Rows[row].Cells[2].Value.ToString();
            txtDescriptionTransportation.Text = dgTransportation.Rows[row].Cells[3].Value.ToString();
            txtSeatQtyTransportation.Value = Convert.ToDecimal(dgTransportation.Rows[row].Cells[4].Value.ToString());
        }

        public void dgRuteClick() {
            int row = dgRute.CurrentCell.RowIndex;

            idRute.Text = dgRute.Rows[row].Cells[0].Value.ToString();
            cbTransportation.Text = dgRute.Rows[row].Cells[1].Value.ToString();
            txtDepartAt.Text = dgRute.Rows[row].Cells[2].Value.ToString();
            txtRuteFrom.Text = dgRute.Rows[row].Cells[3].Value.ToString();
            txtRuteTo.Text = dgRute.Rows[row].Cells[4].Value.ToString();
            txtPrice.Value = Convert.ToDecimal(dgRute.Rows[row].Cells[5].Value.ToString());
        }

        public void searchTransportation() {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select transportation.id, transportation_type.description, transportation.code, transportation.description, transportation.seat_qty from transportation_type, transportation where transportation.code  like '%" + txtSearchTransportation.Text + "%' or transportation.description like '%" + txtSearchTransportation.Text + "%' and transportation_type.id = transportation.transportation_typeid";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            dgTransportation.DataSource = ds.Tables[0];
        }

        public void searchRute() {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select rute.id, transportation.description, rute.depart_at, rute.rute_from, rute.rute_to from transportation, rute where rute.id like '%" + txtSearchRute.Text + "%' or transportation.description like '%" + txtSearchRute.Text + "%' or rute.depart_at like '%" + txtSearchRute.Text + "%' or rute.rute_from like '%" + txtSearchRute.Text + "%' or rute.rute_to like '%" + txtSearchRute.Text + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            dgRute.DataSource = ds.Tables[0];
        }

        public void refreshTransportation() {
            idTransportation.Text = "";
            idTransportationType.Text = "";
            txtSearchTransportation.Text = "";
            txtCodeTransportation.Text = "";
            cbTransportationType.Text = "";
            txtDescriptionTransportation.Text = "";
            txtSeatQtyTransportation.Value = 1;

            seeTransportation();
        }

        public void refreshRute() {
            idRute.Text = "";
            idTransportationRute.Text = "";
            txtSearchRute.Text = "";
            cbTransportation.Text = "";
            txtDepartAt.Text = "";
            txtRuteFrom.Text = "";
            txtRuteTo.Text = "";
            txtPrice.Value = 0;

            seeRute();
        }

        public void createTransportation() {
            if (cbTransportationType.Text == "" && txtDescriptionTransportation.Text == "") {
                MessageBox.Show("Data must be filled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Open();

                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "select * from transportation where code = @code1";
                    command.Parameters.AddWithValue("@code1", txtCodeTransportation.Text);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1) {
                        MessageBox.Show("Code has been taked", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    } else {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "insert into transportation (code, description, seat_qty, transportation_typeid) values (@code, @description, @seat_qty, @transportation_typeid)";
                        cmd.Parameters.AddWithValue("@code", txtCodeTransportation.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescriptionTransportation.Text);
                        cmd.Parameters.AddWithValue("@seat_qty", txtSeatQtyTransportation.Value);
                        cmd.Parameters.AddWithValue("@transportation_typeid", idTransportationType.Text);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    refreshTransportation();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        public void createRute() {
            if (cbTransportation.Text == "" || txtDepartAt.Text == "" || txtRuteFrom.Text == "" || txtRuteTo.Text == "" || txtPrice.Value == 0) {
                MessageBox.Show("Data must be filled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Open();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into rute (depart_at, rute_from, rute_to, price, transportationid) values (@depart_at, @rute_from, @rute_to, @price, @transportationid)";
                    cmd.Parameters.AddWithValue("@depart_at", txtDepartAt.Text);
                    cmd.Parameters.AddWithValue("@rute_from", txtRuteFrom.Text);
                    cmd.Parameters.AddWithValue("@rute_to", txtRuteTo.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Value);
                    cmd.Parameters.AddWithValue("@transportationid", idTransportationRute.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshRute();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        public void updateTransportation() {
            if (idTransportation.Text == "" && cbTransportationType.Text == "" && txtDescriptionTransportation.Text == "") {
                MessageBox.Show("Data must be selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Open();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "update transportation set transportation_typeid = @description, code = @code, description = @description1, seat_qty = @qty where id = @id";
                    cmd.Parameters.AddWithValue("@description", idTransportationType.Text);
                    cmd.Parameters.AddWithValue("@code", txtCodeTransportation.Text);
                    cmd.Parameters.AddWithValue("@description1", txtDescriptionTransportation.Text);
                    cmd.Parameters.AddWithValue("@qty", txtSeatQtyTransportation.Value);
                    cmd.Parameters.AddWithValue("@id", idTransportation.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Edited!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshTransportation();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        public void updateRute() {
            if (idRute.Text == "") {
                MessageBox.Show("Data must be selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Open();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "update rute set depart_at = @depart_at, rute_from = @rute_from, rute_to = @rute_to, price = @price, transportationid = @transportationid where id = @id";
                    cmd.Parameters.AddWithValue("@depart_at", txtDepartAt.Text);
                    cmd.Parameters.AddWithValue("@rute_from", txtRuteFrom.Text);
                    cmd.Parameters.AddWithValue("@rute_to", txtRuteTo.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Value);
                    cmd.Parameters.AddWithValue("@transportationid", idTransportationRute.Text);
                    cmd.Parameters.AddWithValue("id", idRute.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Edited!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshRute();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        public void deleteTransportation() {
            if (idTransportation.Text == "") {
                MessageBox.Show("Data must be selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Open();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from transportation where id = '" + idTransportation.Text + "'";
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshTransportation();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        public void deleteRute() {
            if (idRute.Text == "") {
                MessageBox.Show("Data must be selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Open();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from rute where id = '" + idRute.Text + "'";
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshRute();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        private void transportaionToolStripMenuItem_Click(object sender, EventArgs e) {
            pnlRute.Visible = false;
            pnlTransportation.Visible = true;

            refreshRute();
            refreshTransportation();
        }

        private void btnLogout_Click_1(object sender, EventArgs e) {
            refreshTransportation();

            this.Hide();
            formSignIn si = new formSignIn();
            si.Show();
        }

        private void cbTransportationType_Click(object sender, EventArgs e) {
            if (cbTransportationType.Items.ToString() == cbTransportationType.Items.ToString()) {
                return;
            } else {
                loadTransportationType();
            }
        }

        private void cbTransportationType_SelectedIndexChanged(object sender, EventArgs e) {
            generateCodeTransportation();
        }

        private void btnCreateTransportation_Click(object sender, EventArgs e) {
            createTransportation();
            Application.Restart();
        }

        private void cbTransportationType_TextChanged(object sender, EventArgs e) {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select id from transportation_type where description = '" + cbTransportationType.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 0) {
                return;
            } else {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    idTransportationType.Text = reader["id"].ToString();
                }

                conn.Close();
            }
        }

        private void dgTransportation_CellClick(object sender, DataGridViewCellEventArgs e) {
            dgTransportationClick();
        }

        private void txtSearchTransportation_TextChanged(object sender, EventArgs e) {
            searchTransportation();
        }

        private void btnRefreshTransportation_Click(object sender, EventArgs e) {
            refreshTransportation();
        }

        private void pnlTransportation_Click(object sender, EventArgs e) {
            refreshTransportation();
        }

        private void btnUpdateTransportation_Click(object sender, EventArgs e) {
            updateTransportation();
            Application.Restart();
        }

        private void btnDeleteTransportation_Click(object sender, EventArgs e) {
            deleteTransportation();
            Application.Restart();
        }

        private void ruteToolStripMenuItem_Click(object sender, EventArgs e) {
            pnlTransportation.Visible = false;
            pnlRute.Visible = true;

            refreshTransportation();
            refreshRute();
        }

        private void cbTransportation_TextChanged(object sender, EventArgs e) {
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select id from transportation where description = '" + cbTransportation.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 0) {
                return;
            } else {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    idTransportationRute.Text = reader["id"].ToString();
                }

                conn.Close();
            }
        }

        private void cbTransportation_Click(object sender, EventArgs e) {
            if (cbTransportation.Items.ToString() == cbTransportation.Items.ToString()) {
                return;
            } else {
                loadTransportationName();
            }
        }

        private void txtSearchRute_TextChanged(object sender, EventArgs e) {
            searchRute();
        }

        private void dgRute_CellClick(object sender, DataGridViewCellEventArgs e) {
            dgRuteClick();
        }

        private void btnCreateRute_Click(object sender, EventArgs e) {
            createRute();
            Application.Restart();
        }

        private void btnUpdateRute_Click(object sender, EventArgs e) {
            updateRute();
            Application.Restart();
        }

        private void btnDeleteRute_Click(object sender, EventArgs e) {
            deleteRute();
            Application.Restart();
        }

        private void btnRefreshRute_Click(object sender, EventArgs e) {
            refreshRute();
        }

        private void pnlRute_Click(object sender, EventArgs e) {
            refreshRute();
        }
    }
}
