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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
            populateGride();
            dpM_expdate.Value = DateTime.Now;
        }

        public void populateGride()
        {
            SqlConnection con = new dbConnection().ConnectDB();
            string sql = "SELECT * FROM Medicine";
            SqlCommand cmd = new SqlCommand(sql, con);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvMedicine.DataSource = dataTable;
            }
        }

        public void clearTextAndComboBoxesAndDatePicker()
        {
            txtM_name.Clear();
            txtM_isbn.Clear();
            dpM_expdate.Value = DateTime.Today;
            cmbM_Type.SelectedIndex = -1;
            txtM_stock.Clear();
        }

        private void btnM_save_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtM_name.Text;
                string ISBN = txtM_isbn.Text;
                DateTime ExpDate = Convert.ToDateTime(dpM_expdate.Text);
                string Type = cmbM_Type.Text;
                int Stock = Convert.ToInt32(txtM_stock.Text);
                insert(Name, ISBN, ExpDate, Type, Stock);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextAndComboBoxesAndDatePicker();
            }
        }

        private void insert(string n, string i, DateTime d, string t, int s)
        {
            if(dpM_expdate.Text.Length > 0 && txtM_isbn.Text.Length > 0 && cmbM_Type.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "INSERT INTO Medicine ([Name], [ISBN], [Expiery Date], [Type], Stock) " +
                    "VALUES (@Name, @ISBN, @ExpD, @Type, @Stock)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Name", n);
                    cmd.Parameters.AddWithValue("@ISBN", i);
                    cmd.Parameters.AddWithValue("@ExpD", d);
                    cmd.Parameters.AddWithValue("@Type", t);
                    cmd.Parameters.AddWithValue("@Stock", s);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Inserted!");
                populateGride();
                clearTextAndComboBoxesAndDatePicker();
            }
            else if (dpM_expdate.Text.Length == 0 && txtM_isbn.Text.Length > 0 && cmbM_Type.Text.Length > 0)
            {
                MessageBox.Show("Select Expiery Date", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpM_expdate.Value=DateTime.Today;
                dpM_expdate.Focus();
            }
            else if (dpM_expdate.Text.Length > 0 && txtM_isbn.Text.Length == 0 && cmbM_Type.Text.Length > 0)
            {
                MessageBox.Show("Enter valid ISBN No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtM_isbn.Clear();
                txtM_isbn.Focus();
            }
            else if (dpM_expdate.Text.Length > 0 && txtM_isbn.Text.Length > 0 && cmbM_Type.Text.Length == 0)
            {
                MessageBox.Show("Select Medicine Type", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbM_Type.Items.Clear();
                cmbM_Type.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpM_expdate.Value = DateTime.Today;
                cmbM_Type.Items.Clear();
                txtM_isbn.Clear();
            }
        }

        private void btnM_update_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtM_searchID.Text);
                string Name = txtM_name.Text;
                string ISBN = txtM_isbn.Text;
                DateTime ExpDate = Convert.ToDateTime(dpM_expdate.Text);
                string Type = cmbM_Type.Text;
                int Stock = Convert.ToInt32(txtM_stock.Text);
                update(ID, Name, ISBN, ExpDate, Type, Stock);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextAndComboBoxesAndDatePicker();
            }
            if (dpM_expdate.Text.Length == 0)
            {
                MessageBox.Show("Select Expiery Date", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpM_expdate.DataBindings.Clear();
                dpM_expdate.Focus();
            }
            if (txtM_isbn.Text.Length == 0)
            {
                MessageBox.Show("Enter valid ISBN No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtM_isbn.Clear();
                txtM_isbn.Focus();
            }
            if (cmbM_Type.Text.Length == 0)
            {
                MessageBox.Show("Select Medicine Type", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbM_Type.Items.Clear();
                cmbM_Type.Focus();
            }
        }

        private void update(int id, string n, string i, DateTime d, string t, int s)
        {
            if (dpM_expdate.Text.Length > 0 && txtM_isbn.Text.Length > 0 && cmbM_Type.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "UPDATE Medicine SET [Name] = @Name, [ISBN] = @ISBN, [Expiery Date] = @ExpD, [Type] = @Type, [Stock] = @Stock WHERE ID = @ID;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", n);
                    cmd.Parameters.AddWithValue("@ISBN", i);
                    cmd.Parameters.AddWithValue("@ExpD", d);
                    cmd.Parameters.AddWithValue("@Type", t);
                    cmd.Parameters.AddWithValue("@Stock", s);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Updated!");
                populateGride();
                clearTextAndComboBoxesAndDatePicker();
                txtM_searchID.Text = "0";
            }
            else if (dpM_expdate.Text.Length == 0 && txtM_isbn.Text.Length > 0 && cmbM_Type.Text.Length > 0)
            {
                MessageBox.Show("Select Expiery Date", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpM_expdate.Value = DateTime.Today;
                dpM_expdate.Focus();
            }
            else if (dpM_expdate.Text.Length > 0 && txtM_isbn.Text.Length == 0 && cmbM_Type.Text.Length > 0)
            {
                MessageBox.Show("Enter valid ISBN No.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtM_isbn.Clear();
                txtM_isbn.Focus();
            }
            else if (dpM_expdate.Text.Length > 0 && txtM_isbn.Text.Length > 0 && cmbM_Type.Text.Length == 0)
            {
                MessageBox.Show("Select Medicine Type", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbM_Type.Items.Clear();
                cmbM_Type.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpM_expdate.Value = DateTime.Today;
                cmbM_Type.Items.Clear();
                txtM_isbn.Clear();
            }
        }

        private void btnM_search_Click(object sender, EventArgs e)
        {
            string NIC = txtM_searchISBN.Text;
            if (int.TryParse(txtM_searchID.Text, out int ID))
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
                string sql = "SELECT * FROM Medicine WHERE ISBN = @ISBN";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ISBN", nic);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dgvMedicine.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            txtM_searchISBN.Clear();
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(nic) && id != 0)
            {
                string sql = "SELECT * FROM Medicine WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtM_name.Text = reader["Name"].ToString();
                            txtM_isbn.Text = reader["ISBN"].ToString();
                            dpM_expdate.Text = reader["Expiery Date"].ToString();
                            cmbM_Type.Text = reader["Type"].ToString();
                            txtM_stock.Text = reader["Stock"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            clearTextAndComboBoxesAndDatePicker();
                            txtM_searchID.Text = "0";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please give the input for only one of the above.");
            }

            con.Close();
        }

        private void btnM_return_Click(object sender, EventArgs e)
        {
            populateGride();
            clearTextAndComboBoxesAndDatePicker();
            txtM_searchID.Text = "0";
            txtM_searchISBN.Clear();
        }

        private void btnM_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtM_searchID.Text, out int ID))
            {
                delete(ID);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
                txtM_searchID.Clear();
                txtM_searchID.Focus();
            }
        }

        private void delete(int id)
        {
            SqlConnection con = new dbConnection().ConnectDB();

            if (MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Medicine WHERE ID = @ID";

                using (SqlCommand deleteCmd = new SqlCommand(sql, con))
                {
                    deleteCmd.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        populateGride();
                        clearTextAndComboBoxesAndDatePicker();
                        txtM_searchID.Text = "0";
                    }
                    else
                    {
                        MessageBox.Show("Record not found or could not be deleted.");
                        txtM_searchID.Text = "0";
                    }
                }
            }
            else
            {
                populateGride();
                clearTextAndComboBoxesAndDatePicker() ;
                txtM_searchID.Text = "0";
            }

            con.Close();
        }

    }
}
