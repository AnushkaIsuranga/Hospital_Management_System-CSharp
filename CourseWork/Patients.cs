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
using MySql.Data.MySqlClient;

namespace Hospital_Management
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            populateGride();
        }

        public void populateGride()
        {
            SqlConnection con = new dbConnection().ConnectDB();
            string sql = "SELECT * FROM Patient";
            SqlCommand cmd = new SqlCommand(sql, con);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvPatients.DataSource = dataTable;
            }
        }

        public void clearTextBoxes()
        {
            txtP_Fname.Clear();
            txtP_Lname.Clear();
            txtP_nic.Clear();
            txtP_disease.Clear();
            txtP_age.Clear();
            txtP_ward.Clear();
            txtP_doctor.Clear();
        }

        private void btnP_save_Click(object sender, EventArgs e)
        {
            try
            {
                string Fname = txtP_Fname.Text;
                string Lname = txtP_Lname.Text;
                int age = Convert.ToInt32(txtP_age.Text);
                string nic = txtP_nic.Text;
                string disease = txtP_disease.Text;
                string ward = txtP_ward.Text;
                int doctor = Convert.ToInt32(txtP_doctor.Text);
                insert(Fname, Lname, age, nic, disease, ward, doctor);
            }catch (FormatException)
            {
                MessageBox.Show("Invalid input. Re-enter.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
            }
        }

        private void insert(string f, string l, int a, string n, string d, string w, int doc)
        {

            if (txtP_disease.Text.Length > 0 && txtP_nic.Text.Length > 0 && txtP_ward.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "INSERT INTO Patient ([First Name], [Last Name], Age, NIC, [Disease/Injury], Ward, [Doctor ID], [Date & Time]) " +
                    "VALUES (@Fname, @Lname, @Age, @NIC, @Disease, @Ward, @Doctor, @DateTime)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Fname", f);
                    cmd.Parameters.AddWithValue("@Lname", l);
                    cmd.Parameters.AddWithValue("@Age", a);
                    cmd.Parameters.AddWithValue("@NIC", n);
                    cmd.Parameters.AddWithValue("@Disease", d);
                    cmd.Parameters.AddWithValue("@Ward", w);
                    cmd.Parameters.AddWithValue("@Doctor", doc);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Inserted!");
                populateGride();
                clearTextBoxes();
            }
            else if (txtP_disease.Text.Length == 0 && txtP_nic.Text.Length > 0 && txtP_ward.Text.Length > 0)
            {
                MessageBox.Show("Enter disease/injury", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtP_disease.Clear();
                txtP_disease.Focus();
            }
            else if (txtP_disease.Text.Length > 0 && txtP_nic.Text.Length == 0 && txtP_ward.Text.Length > 0)
            {
                MessageBox.Show("Enter valid NIC No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtP_nic.Clear();
                txtP_nic.Focus();
            }
            else if (txtP_disease.Text.Length > 0 && txtP_nic.Text.Length > 0 && txtP_ward.Text.Length == 0)
            {
                MessageBox.Show("Enter valid ward", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtP_ward.Clear();
                txtP_ward.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtP_disease.Clear();
                txtP_nic.Clear();
                txtP_ward.Clear();
            }
            
        }

        private void btnP_update_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtP_searchID.Text);
                string Fname = txtP_Fname.Text;
                string Lname = txtP_Lname.Text;
                int age = Convert.ToInt32(txtP_age.Text);
                string nic = txtP_nic.Text;
                string disease = txtP_disease.Text;
                string ward = txtP_ward.Text;
                int doctor = Convert.ToInt32(txtP_doctor.Text); 

                update(ID, Fname, Lname, age, nic, disease, ward, doctor);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Re-enter.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
            }
        }

        private void update(int id, string f, string l, int a, string n, string d, string w, int doc)
        {
            if (txtP_disease.Text.Length > 0 && txtP_nic.Text.Length > 0 && txtP_ward.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "UPDATE Patient SET [First Name] = @Fname, [Last Name] = @Lname, Age = @Age, NIC = @NIC, [Disease/Injury] = @Disease, Ward = @Ward, [Doctor ID] = @Doctor WHERE ID = @ID;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Fname", f);
                    cmd.Parameters.AddWithValue("@Lname", l);
                    cmd.Parameters.AddWithValue("@Age", a);
                    cmd.Parameters.AddWithValue("@NIC", n);
                    cmd.Parameters.AddWithValue("@Disease", d);
                    cmd.Parameters.AddWithValue("@Ward", w);
                    cmd.Parameters.AddWithValue("@Doctor", doc);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Updated!");
                populateGride();
                txtP_searchID.Text = "0";
                clearTextBoxes();
            }
            else if (txtP_disease.Text.Length == 0 && txtP_nic.Text.Length > 0 && txtP_ward.Text.Length > 0)
            {
                MessageBox.Show("Enter disease/injury", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtP_disease.Clear();
                txtP_disease.Focus();
            }
            else if (txtP_disease.Text.Length > 0 && txtP_nic.Text.Length == 0 && txtP_ward.Text.Length > 0)
            {
                MessageBox.Show("Enter valid NIC No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtP_nic.Clear();
                txtP_nic.Focus();
            }
            else if (txtP_disease.Text.Length > 0 && txtP_nic.Text.Length > 0 && txtP_ward.Text.Length == 0)
            {
                MessageBox.Show("Enter valid ward", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtP_ward.Clear();
                txtP_ward.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtP_disease.Clear();
                txtP_nic.Clear();
                txtP_ward.Clear();
            }
        }

        private void btnP_search_Click(object sender, EventArgs e)
        {
            string NIC = txtP_searchNIC.Text; 
            if (int.TryParse(txtP_searchID.Text, out int ID))
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
                string sql = "SELECT * FROM Patient WHERE NIC = @NIC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@NIC", nic);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dgvPatients.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            txtP_searchNIC.Clear();
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(nic) && id != 0)
            {
                string sql = "SELECT * FROM Patient WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtP_Fname.Text = reader["First Name"].ToString();
                            txtP_Lname.Text = reader["Last Name"].ToString();
                            txtP_age.Text = reader["Age"].ToString();
                            txtP_nic.Text = reader["NIC"].ToString();
                            txtP_disease.Text = reader["Disease/Injury"].ToString();
                            txtP_ward.Text = reader["Ward"].ToString();
                            txtP_doctor.Text = reader["Doctor ID"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            clearTextBoxes();
                            txtP_searchID.Text = "0";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please give the input for only on the the above.");
                txtP_searchID.Text = "0";
                txtP_searchNIC.Clear();
            }

            con.Close();
        }

        private void btnP_return_Click(object sender, EventArgs e)
        {
            populateGride();
            clearTextBoxes();
            txtP_searchID.Text = "0";
            txtP_searchNIC.Clear();
        }

        private void btnP_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtP_searchID.Text, out int ID))
            {
                delete(ID);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
                txtP_searchID.Clear();
                txtP_searchID.Focus();
            }
        }

        private void delete(int id)
        {
            SqlConnection con = new dbConnection().ConnectDB();

            if (MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Patient WHERE ID = @ID";

                using (SqlCommand deleteCmd = new SqlCommand(sql, con))
                {
                    deleteCmd.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        populateGride();
                        txtP_searchID.Text = "0";
                        clearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Record not found or could not be deleted.");
                        txtP_searchID.Text = "0";
                    }
                }
            }
            else
            {
                populateGride();
                clearTextBoxes();
                txtP_searchID.Text = "0";
            }

            con.Close();
        }

    }
}
