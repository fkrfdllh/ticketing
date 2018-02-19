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
using CrystalDecisions.CrystalReports.Engine;

namespace ticketing {
    public partial class formCustomer : Form {
        MySqlConnection conn = new MySqlConnection("server = localhost; database = ticketing; uid = fkrfdllh; pwd = 18januari");
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        MySqlCommand cmd;
        DataTable dt;
        DataSet ds;
        int row;

        public formCustomer() {
            InitializeComponent();

            seeCustomer();
            seeRute();

            loadIDCustomer();
            loadTransportationType();
            loadTransportationName();
            loadSeatCode();

            generateReservationCode();
        }

        public void generateReservationCode() {
            Random r = new Random();
            int code = r.Next(0, 100000000);

            txtReservationCode.Text = "R-" + code;
        }

        public void seeCustomer() {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from customer";
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();

            adapter.Fill(ds);

            dgBiodata.DataSource = ds.Tables[0].DefaultView;
        }

        public void seeRute() {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from rute where transportationid = '" + idTransportationName.Text + "'";
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();

            adapter.Fill(ds);

            dgReservation.DataSource = ds.Tables[0];

            conn.Close();
        }

        public void loadIDCustomer() {
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select id from customer";
            adapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 0) {
                return;
            } else {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    txtIDCustomer.Items.Add(reader.GetString("id"));
                    txtIDCustomer.Refresh();
                    txtIDCustomer.Update();
                }

                conn.Close();
            }
        }

        public void loadTransportationType() {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select description from transportation_type";
            adapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 0) {
                return;
            } else {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    txtTransportationType.Items.Add(reader.GetString("description"));
                }
            }
        }

        public void loadTransportationName() {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select description from transportation where transportation_typeid = '" + idTransportationType.Text + "'";
            adapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 0) {
                return;
            } else {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    txtTransportationName.Items.Add(reader.GetString("description"));
                }
            }
        }

        public void loadSeatCode() {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select seat_qty from transportation where id = '" + idTransportationName.Text + "'";
            adapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count == 0) {
                return;
            } else {
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    int num;
                    int seat = Convert.ToInt32(reader["seat_qty"].ToString());

                    for (num = 1; num <= seat; num++) {
                        txtSeatCode.Items.Add(num);
                    }
                }
            }
        }

        public void dgBiodataClick() {
            row = dgBiodata.CurrentCell.RowIndex;

            idCustomer.Text = dgBiodata.Rows[row].Cells[0].Value.ToString();
            txtNameCustomer.Text = dgBiodata.Rows[row].Cells[1].Value.ToString();
            txtAddressCustomer.Text = dgBiodata.Rows[row].Cells[2].Value.ToString();
            txtPhoneCustomer.Text = dgBiodata.Rows[row].Cells[3].Value.ToString();
            txtGenderCustomer.Text = dgBiodata.Rows[row].Cells[4].Value.ToString();

            txtGenderCustomer.Enabled = false;
        }

        public void dgReservationClick() {
            row = dgReservation.CurrentCell.RowIndex;

            idRute.Text = dgReservation.Rows[row].Cells[0].Value.ToString();
            txtDepartAt.Text = dgReservation.Rows[row].Cells[1].Value.ToString();
            txtPrice.Value = Convert.ToDecimal(dgReservation.Rows[row].Cells[4].Value.ToString());
        }

        public void searchCustomer() {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from customer where id = @search or name = @search";
            cmd.Parameters.AddWithValue("@search", txtSearchCustomer.Text);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();

            adapter.Fill(ds);

            dgBiodata.DataSource = ds.Tables[0];
        }

        public void refreshCustomer() {
            idCustomer.Text = "";
            txtSearchCustomer.Text = "";
            txtNameCustomer.Text = "";
            txtAddressCustomer.Text = "";
            txtPhoneCustomer.Text = "";
            txtGenderCustomer.Text = "";

            txtGenderCustomer.Enabled = true;
            seeCustomer();
        }

        public void refreshReservation() {
            txtReservationCode.Text = "";
            txtReservationAt.Text = "";
            txtIDCustomer.Text = "";
            txtTransportationType.Text = "";
            txtTransportationName.Text = "";
            txtSeatCode.Text = "";
            txtDepartAt.Text = "";
            txtPrice.Value = 0;
            idRute.Text = "";

            generateReservationCode();
        }

        public void createCustomer() {
            if (txtNameCustomer.Text == "" || txtAddressCustomer.Text == "" || txtPhoneCustomer.Text == "" || txtGenderCustomer.Text == "") {
                MessageBox.Show("Data must be filled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Close();
                    conn.Open();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into customer (name, address, phone, gender) values (@name, @address, @phone, @gender)";
                    cmd.Parameters.AddWithValue("@name", txtNameCustomer.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddressCustomer.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhoneCustomer.Text);
                    cmd.Parameters.AddWithValue("@gender", txtGenderCustomer.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshCustomer();
                } catch (Exception ex) {
                    MessageBox.Show("Error!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        public void createReservation() {
            if (txtReservationAt.Text == "" || txtIDCustomer.Text == "" || txtTransportationType.Text == "" || txtTransportationName.Text == "" || txtSeatCode.Text == "" || idRute.Text == "") {
                MessageBox.Show("Data must be filled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Close();
                    conn.Open();

                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "select * from reservation";
                    adapter = new MySqlDataAdapter(command);
                    dt = new DataTable();

                    adapter.Fill(dt);

                    if (dt.Rows.Count == 1) {
                        reader = command.ExecuteReader();
                        while (reader.Read()) {
                            String seatCode = reader["seat_code"].ToString();
                            if (txtSeatCode.Text == seatCode) {
                                MessageBox.Show("Seat Code has been taked", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    } else {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "insert into reservation (reservation_code, reservation_at, reservation_date, customerid, seat_code, ruteid, depart_at, price, userid) values (@reservation_code, @reservation_at, NOW(), @customerid, @seat_code, @ruteid, @depart_at, @price, @userid)";
                        cmd.Parameters.AddWithValue("@reservation_code", txtReservationCode.Text);
                        cmd.Parameters.AddWithValue("@reservation_at", txtReservationAt.Text);
                        cmd.Parameters.AddWithValue("@customerid", txtIDCustomer.Text);
                        cmd.Parameters.AddWithValue("@seat_code", txtSeatCode.Text);
                        cmd.Parameters.AddWithValue("@ruteid", idRute.Text);
                        cmd.Parameters.AddWithValue("@depart_at", txtDepartAt.Text);
                        cmd.Parameters.AddWithValue("@price", txtPrice.Value);
                        cmd.Parameters.AddWithValue("@userid", idUser.Text);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        conn.Open();

                        cmd = conn.CreateCommand();
                        cmd.CommandText = "select * from reservation where reservation_code = '" + txtReservationCode.Text + "'";
                        adapter = new MySqlDataAdapter(cmd);
                        ds = new DataSet();
                        cmd.ExecuteNonQuery();

                        ds.Clear();
                        adapter.Fill(ds);

                        conn.Close();

                        ReportDocument rd = new ReportDocument();
                        rd.Load("../../Struct.rpt");
                        rd.Database.Tables[0].SetDataSource(ds.Tables[0]);

                        Struk struk = new Struk();
                        struk.crystalReportViewer1.ReportSource = rd;
                        struk.ShowDialog();

                        refreshReservation();
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        public void updateCustomer() {
            if (idCustomer.Text == "") {
                MessageBox.Show("Data must be selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                try {
                    conn.Close();
                    conn.Open();

                    cmd = conn.CreateCommand();
                    cmd.CommandText = "update customer set name = @name, address = @address, phone = @phone where id = @id";
                    cmd.Parameters.AddWithValue("@id", idCustomer.Text);
                    cmd.Parameters.AddWithValue("@name", txtNameCustomer.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddressCustomer.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhoneCustomer.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    refreshCustomer();
                } catch (Exception ex) {
                    MessageBox.Show("Error!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e) {
            createCustomer();
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e) {
            refreshCustomer();
        }

        private void dgBiodata_CellClick(object sender, DataGridViewCellEventArgs e) {
            dgBiodataClick();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e) {
            updateCustomer();
        }

        private void biodataToolStripMenuItem_Click(object sender, EventArgs e) {
            pnlBiodata.Visible = true;
            pnlReservation.Visible = false;

            refreshCustomer();
            refreshReservation();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e) {
            pnlBiodata.Visible = false;
            pnlReservation.Visible = true;

            refreshCustomer();
            refreshReservation();
        }

        private void txtTransportationType_Click(object sender, EventArgs e) {
            if (txtTransportationType.Items.ToString() == txtTransportationType.Items.ToString()) {
                return;
            } else {
                loadTransportationType();
            }
        }

        private void txtTransportationType_TextChanged(object sender, EventArgs e) {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select id from transportation_type where description = '" + txtTransportationType.Text + "'";
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                idTransportationType.Text = reader["id"].ToString();
            }

            conn.Close();
        }

        private void txtTransportationName_Click(object sender, EventArgs e) {
            if (txtTransportationName.Items.ToString() == txtTransportationName.Items.ToString()) {
                return;
            } else {
                loadTransportationName();
            }
        }

        private void idTransportationType_TextChanged(object sender, EventArgs e) {
            txtTransportationName.Items.Clear();

            loadTransportationName();
        }

        private void txtTransportationName_TextChanged(object sender, EventArgs e) {
            conn.Close();
            conn.Open();

            cmd = conn.CreateCommand();
            cmd.CommandText = "select id from transportation where description = '" + txtTransportationName.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read()) {
                idTransportationName.Text = reader["id"].ToString();
            }

            conn.Close();

            loadSeatCode();
        }

        private void idTransportationName_TextChanged(object sender, EventArgs e) {
            seeRute();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e) {
            refreshCustomer();
            refreshReservation();

            this.Hide();
            formSignIn si = new formSignIn();
            si.Show();
        }

        private void txtSeatCode_Click(object sender, EventArgs e) {
            if (txtSeatCode.Items.ToString() == txtSeatCode.Items.ToString()) {
                return;
            } else {
                loadSeatCode();
            }
        }

        private void btnRefreshReservation_Click(object sender, EventArgs e) {
            refreshReservation();
        }

        private void dgReservation_CellClick(object sender, DataGridViewCellEventArgs e) {
            dgReservationClick();
        }

        private void btnCreateReservation_Click(object sender, EventArgs e) {
            createReservation();
        }

        private void txtIDCustomer_Click(object sender, EventArgs e) {
            txtIDCustomer.Update();
            if (txtIDCustomer.Items.ToString() == txtIDCustomer.Items.ToString()) {
                return;
            } else {
                loadIDCustomer();
            }
        }
    }
}
