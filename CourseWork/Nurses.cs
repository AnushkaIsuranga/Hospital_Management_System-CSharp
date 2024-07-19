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
    public partial class Nurses : Form
    {
        public Nurses()
        {
            InitializeComponent();
            populateGride();
            dpN_dob.Value = DateTime.Today;
        }

        public void populateGride()
        {
            SqlConnection con = new dbConnection().ConnectDB();
            string sql = "SELECT * FROM Nurse";
            SqlCommand cmd = new SqlCommand(sql, con);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvNurses.DataSource = dataTable;
            }
        }

        public void clearTextBoxesAndDatePicker()
        {
            txtN_Fname.Clear();
            txtN_Lname.Clear();
            dpN_dob.Value = DateTime.Today;
            txtN_nic.Clear();
        }

        private void btnN_save_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = txtN_Fname.Text;
                string Lname = txtN_Lname.Text;
                DateTime DOB = Convert.ToDateTime(dpN_dob.Text);
                string nic = txtN_nic.Text;
                insert(Fname, Lname, DOB, nic);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxesAndDatePicker();
            }
        }

        private void insert(string f, string l, DateTime d, string n)
        {
            if (dpN_dob.Text.Length > 0 && txtN_nic.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "INSERT INTO Nurse ([First Name], [Last Name], [DoB], [Age], NIC) " +
                    "VALUES (@Fname, @Lname, @dob, @Age, @NIC)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", f);
                    cmd.Parameters.AddWithValue("@Lname", l);
                    cmd.Parameters.AddWithValue("@dob", d);
                    int age = DateTime.Today.Year - d.Year;
                    if (d.Date > DateTime.Today.AddYears(-age))
                        age--;
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@NIC", n);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Inserted!");
                populateGride();
                clearTextBoxesAndDatePicker();
            }
            else if (dpN_dob.Text.Length == 0 && txtN_nic.Text.Length > 0)
            {
                MessageBox.Show("Select Birthday", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpN_dob.Value = DateTime.Today;
                dpN_dob.Focus();
            }
            else if (dpN_dob.Text.Length > 0 && txtN_nic.Text.Length == 0)
            {
                MessageBox.Show("Enter valid NIC No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtN_nic.Clear();
                txtN_nic.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtN_nic.Clear();
                dpN_dob.Value = DateTime.Today;
            }
        }

        private void btnN_update_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtN_searchID.Text);
                string Fname = txtN_Fname.Text;
                string Lname = txtN_Lname.Text;
                DateTime DOB = Convert.ToDateTime(dpN_dob.Text);
                string nic = txtN_nic.Text;
                update(ID, Fname, Lname, DOB, nic);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxesAndDatePicker();
            }
        }

        private void update(int id, string f, string l, DateTime d, string n)
        {
            if (dpN_dob.Text.Length > 0 && txtN_nic.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "UPDATE Nurse SET [First Name] = @Fname, [Last Name] = @Lname, DoB = @dob, [NIC] = @NIC WHERE ID = @ID;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Fname", f);
                    cmd.Parameters.AddWithValue("@Lname", l);
                    cmd.Parameters.AddWithValue("@dob", d);
                    int age = DateTime.Today.Year - d.Year;
                    if (d.Date > DateTime.Today.AddYears(-age))
                        age--;
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@NIC", n);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Updated!");
                populateGride();
                clearTextBoxesAndDatePicker();
            }
            else if (dpN_dob.Text.Length == 0 && txtN_nic.Text.Length > 0)
            {
                MessageBox.Show("Select Birthday", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpN_dob.Value = DateTime.Today;
                dpN_dob.Focus();
            }
            else if (dpN_dob.Text.Length > 0 && txtN_nic.Text.Length == 0)
            {
                MessageBox.Show("Enter valid NIC No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtN_nic.Clear();
                txtN_nic.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtN_nic.Clear();
                dpN_dob.Value = DateTime.Today;
            }
        }

        private void btnN_search_Click(object sender, EventArgs e)
        {
            string NIC = txtN_searchNIC.Text;
            if (int.TryParse(txtN_searchID.Text, out int ID))
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
                string sql = "SELECT * FROM Nurse WHERE NIC = @NIC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@NIC", nic);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dgvNurses.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            txtN_searchNIC.Clear();
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(nic) && id != 0)
            {
                string sql = "SELECT * FROM Nurse WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtN_Fname.Text = reader["First Name"].ToString();
                            txtN_Lname.Text = reader["Last Name"].ToString();
                            dpN_dob.Text = reader["DoB"].ToString();
                            txtN_nic.Text = reader["NIC"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            clearTextBoxesAndDatePicker();
                            txtN_searchID.Text = "0";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please give the input for only one of the above.");
                txtN_searchID.Text = "0";
                txtN_searchNIC.Clear();
            }

            con.Close();
        }

        private void btnN_return_Click(object sender, EventArgs e)
        {
            populateGride();
            clearTextBoxesAndDatePicker();
            txtN_searchID.Text = "0";
            txtN_searchNIC.Clear();
        }

        private void btnN_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtN_searchID.Text, out int ID))
            {
                delete(ID);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
                txtN_searchID.Clear();
                txtN_searchID.Focus();
            }
        }

        private void delete(int id)
        {
            SqlConnection con = new dbConnection().ConnectDB();

            if (MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Nurse WHERE ID = @ID";

                using (SqlCommand deleteCmd = new SqlCommand(sql, con))
                {
                    deleteCmd.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        populateGride();
                        clearTextBoxesAndDatePicker();
                        txtN_searchID.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("Record not found or could not be deleted.");
                        txtN_searchID.Text = "0";
                    }
                }
            }
            else
            {
                populateGride();
                clearTextBoxesAndDatePicker();
                txtN_searchID.Text = "0";
            }

            con.Close();
        }

    }
}
