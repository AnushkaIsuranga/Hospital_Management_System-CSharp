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
    public partial class Labors : Form
    {
        public Labors()
        {
            InitializeComponent();
            populateGride();
            dpL_dob.Value = DateTime.Now;
        }

        public void populateGride()
        {
            SqlConnection con = new dbConnection().ConnectDB();
            string sql = "SELECT * FROM Labor";
            SqlCommand cmd = new SqlCommand(sql, con);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvLabors.DataSource = dataTable;
            }
        }

        public void clearTextBoxesAndDatePicker()
        {
            txtL_Fname.Clear();
            txtL_Lname.Clear();
            dpL_dob.Value = DateTime.Today;
            txtL_nic.Clear();
            txtL_ward.Clear();
        }

        private void btnL_save_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = txtL_Fname.Text;
                string Lname = txtL_Lname.Text;
                DateTime DOB = Convert.ToDateTime(dpL_dob.Text);
                string nic = txtL_nic.Text;
                int ward = Convert.ToInt32(txtL_ward.Text);
                insert(Fname, Lname, DOB, nic, ward);
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

        private void insert(string f, string l, DateTime d, string n, int w)
        {
            if (dpL_dob.Text.Length > 0 && txtL_nic.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "INSERT INTO Labor ([First Name], [Last Name], [DoB], [Age], NIC, [Ward]) " +
                    "VALUES (@Fname, @Lname, @dob, @Age, @NIC, @Ward)";

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
                    cmd.Parameters.AddWithValue("@Ward", w);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Inserted!");
                populateGride();
                clearTextBoxesAndDatePicker();
            }
            else if (dpL_dob.Text.Length == 0 && txtL_nic.Text.Length > 0)
            {
                MessageBox.Show("Select Birthday", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpL_dob.DataBindings.Clear();
                dpL_dob.Focus();
            }
            else if (dpL_dob.Text.Length > 0 && txtL_nic.Text.Length == 0)
            {
                MessageBox.Show("Enter valid NIC No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtL_nic.Clear();
                txtL_nic.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtL_nic.Clear();
                dpL_dob.Value = DateTime.Today;
            }
        }

        private void btnL_update_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtL_searchID.Text);
                string Fname = txtL_Fname.Text;
                string Lname = txtL_Lname.Text;
                DateTime DOB = Convert.ToDateTime(dpL_dob.Text);
                string nic = txtL_nic.Text;
                int ward = Convert.ToInt32(txtL_ward.Text);
                update(ID, Fname, Lname, DOB, nic, ward);
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

        private void update(int id, string f, string l, DateTime d, string n, int w)
        {
            if (dpL_dob.Text.Length > 0 && txtL_nic.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "UPDATE Labor SET [First Name] = @Fname, [Last Name] = @Lname, DoB = @dob, [NIC] = @NIC, [Ward] = @Ward WHERE ID = @ID;";

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
                    cmd.Parameters.AddWithValue("@Ward", w);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Updated!");
                populateGride();
                clearTextBoxesAndDatePicker();
                txtL_searchID.Text = "0";
            }
            else if (dpL_dob.Text.Length == 0 && txtL_nic.Text.Length > 0)
            {
                MessageBox.Show("Select Birthday", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpL_dob.DataBindings.Clear();
                dpL_dob.Focus();
            }
            else if (dpL_dob.Text.Length > 0 && txtL_nic.Text.Length == 0)
            {
                MessageBox.Show("Enter valid NIC No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtL_nic.Clear();
                txtL_nic.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtL_nic.Clear();
                dpL_dob.Value = DateTime.Today;
            }
        }

        private void btnL_search_Click(object sender, EventArgs e)
        {
            string NIC = txtL_searchNIC.Text;
            if (int.TryParse(txtL_searchID.Text, out int ID))
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
                string sql = "SELECT * FROM Labor WHERE NIC = @NIC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@NIC", nic);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dgvLabors.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            txtL_searchNIC.Clear();
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(nic) && id != 0)
            {
                string sql = "SELECT * FROM Labor WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtL_Fname.Text = reader["First Name"].ToString();
                            txtL_Lname.Text = reader["Last Name"].ToString();
                            dpL_dob.Text = reader["DoB"].ToString();
                            txtL_nic.Text = reader["NIC"].ToString();
                            txtL_ward.Text = reader["Ward"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            clearTextBoxesAndDatePicker();
                            txtL_searchID.Text = "0";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please give the input for only one of the above.");
                txtL_searchID.Text = "0";
                txtL_searchNIC.Clear();
            }

            con.Close();
        }

        private void btnL_return_Click(object sender, EventArgs e)
        {
            populateGride();
            clearTextBoxesAndDatePicker();
            txtL_searchID.Text = "0";
            txtL_searchNIC.Clear();
        }

        private void btnL_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtL_searchID.Text, out int ID))
            {
                delete(ID);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
                txtL_searchID.Clear();
                txtL_searchID.Focus();
            }
        }

        private void delete(int id)
        {
            SqlConnection con = new dbConnection().ConnectDB();

            if (MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Labor WHERE ID = @ID";

                using (SqlCommand deleteCmd = new SqlCommand(sql, con))
                {
                    deleteCmd.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        populateGride();
                        clearTextBoxesAndDatePicker();
                        txtL_searchID.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("Record not found or could not be deleted.");
                        txtL_searchID.Text = "0";
                    }
                }
            }
            else
            {
                populateGride();
                clearTextBoxesAndDatePicker() ;
                txtL_searchID.Text = "0";
            }

            con.Close();
        }

    }
}
