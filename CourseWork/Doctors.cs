using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            populateGride();
        }

        public void populateGride()
        {
            SqlConnection con = new dbConnection().ConnectDB();
            string sql = "SELECT * FROM Doctor";
            SqlCommand cmd = new SqlCommand(sql, con);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvDoctors.DataSource = dataTable;
            }
        }

        public void clearTextAndComboBoxes()
        {
            txtD_Fname.Clear();
            txtD_Lname.Clear();
            cmbD_profession.SelectedIndex = -1;
            txtD_nic.Clear();
        }

        private void btnD_save_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = txtD_Fname.Text;
                string Lname = txtD_Lname.Text;
                string profession = cmbD_profession.Text;
                string nic = txtD_nic.Text;
                insert(Fname, Lname, profession, nic);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextAndComboBoxes();
            }
        }

        private void insert(string f, string l, string p, string n)
        {
            if (cmbD_profession.Text.Length > 0 && txtD_nic.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "INSERT INTO Doctor ([First Name], [Last Name], [Profession], NIC, [Date]) " +
                    "VALUES (@Fname, @Lname, @Prof, @NIC, @DateTime)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", f);
                    cmd.Parameters.AddWithValue("@Lname", l);
                    cmd.Parameters.AddWithValue("@Prof", p);
                    cmd.Parameters.AddWithValue("@NIC", n);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now.Date);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Inserted!");
                populateGride();
                clearTextAndComboBoxes();
            }
            else if (cmbD_profession.Text.Length == 0 && txtD_nic.Text.Length > 0)
            {
                MessageBox.Show("Select profession", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbD_profession.SelectedIndex = -1;
                cmbD_profession.Focus();
            }
            else if (cmbD_profession.Text.Length > 0 && txtD_nic.Text.Length == 0)
            {
                MessageBox.Show("Enter valid NIC No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtD_nic.Clear();
                txtD_nic.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtD_nic.Clear();
                cmbD_profession.SelectedIndex = -1;
            }
        }

        private void btnD_update_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtD_searchID.Text);
                string Fname = txtD_Fname.Text;
                string Lname = txtD_Lname.Text;
                string profession = cmbD_profession.Text;
                string nic = txtD_nic.Text;
                update(ID, Fname, Lname, profession, nic);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Re-enter.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextAndComboBoxes();
            }
        }

        private void update(int id, string f, string l, string p, string n)
        {
            if (cmbD_profession.Text.Length > 0 && txtD_nic.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "UPDATE Doctor SET [First Name] = @Fname, [Last Name] = @Lname, Profession = @Prof, [NIC] = @NIC WHERE ID = @ID;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Fname", f);
                    cmd.Parameters.AddWithValue("@Lname", l);
                    cmd.Parameters.AddWithValue("@Prof", p);
                    cmd.Parameters.AddWithValue("@NIC", n);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Updated!");
                populateGride();
                txtD_searchID.Text = "0";
                clearTextAndComboBoxes();
            }
            if (cmbD_profession.Text.Length == 0 && txtD_nic.Text.Length > 0)
            {
                MessageBox.Show("Select profession", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbD_profession.SelectedIndex = -1;
                cmbD_profession.Focus();
            }
            if (cmbD_profession.Text.Length > 0 && txtD_nic.Text.Length == 0)
            {
                MessageBox.Show("Enter valid NIC No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtD_nic.Clear();
                txtD_nic.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtD_nic.Clear();
                cmbD_profession.SelectedIndex = -1;
            }
        }

        private void btnD_search_Click(object sender, EventArgs e)
        {
            string NIC = txtD_searchNIC.Text;
            if (int.TryParse(txtD_searchID.Text, out int ID))
            {
                search(NIC, ID);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
            }
            search(NIC, ID);
        }

        private void search(string nic, int id)
        {
            SqlConnection con = new dbConnection().ConnectDB();

            if (!string.IsNullOrEmpty(nic) && id == 0)
            {
                string sql = "SELECT * FROM Doctor WHERE NIC = @NIC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@NIC", nic);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dgvDoctors.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            txtD_searchNIC.Clear();
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(nic) && id != 0)
            {
                string sql = "SELECT * FROM Doctor WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtD_Fname.Text = reader["First Name"].ToString();
                            txtD_Lname.Text = reader["Last Name"].ToString();
                            cmbD_profession.Text = reader["Profession"].ToString() ;
                            txtD_nic.Text = reader["NIC"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            clearTextAndComboBoxes();
                            txtD_searchID.Text = "0";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please give the input for only one of the above.");
                txtD_searchID.Text = "0";
                txtD_searchNIC.Clear();
            }

            con.Close();
        }

        private void btnD_return_Click(object sender, EventArgs e)
        {
            populateGride();
            clearTextAndComboBoxes() ;
            txtD_searchID .Text = "0";
            txtD_searchNIC.Clear() ;
        }

        private void btnD_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtD_searchID.Text, out int ID))
            {
                delete(ID);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
                txtD_searchID.Clear();
                txtD_searchID.Focus();
            }
        }

        private void delete(int id)
        {
            SqlConnection con = new dbConnection().ConnectDB();

            if (MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Doctor WHERE ID = @ID";

                using (SqlCommand deleteCmd = new SqlCommand(sql, con))
                {
                    deleteCmd.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        populateGride();
                        clearTextAndComboBoxes() ;
                        txtD_searchID.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("Record not found or could not be deleted.");
                        txtD_searchID.Text = "0";
                    }
                }
            }
            else
            {
                populateGride();
                clearTextAndComboBoxes();
                txtD_searchID.Text = "0";
            }

            con.Close();
        }

    }
}
