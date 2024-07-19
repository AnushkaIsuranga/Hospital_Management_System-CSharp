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
    public partial class Wards : Form
    {
        public Wards()
        {
            InitializeComponent();
            populateGride();
        }

        public void populateGride()
        {
            SqlConnection con = new dbConnection().ConnectDB();
            string sql = "SELECT * FROM Ward";
            SqlCommand cmd = new SqlCommand(sql, con);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvWards.DataSource = dataTable;
            }
        }

        public void clearTextAndComboBoxes()
        {
            cmbW_type.SelectedIndex = -1;
            txtW_doctor.Clear();
            txtW_Lname.Clear();
            txtW_master.Clear();
            txtW_searchID.Text = "0";
            txtW_searchLable.Clear();
        }

        private void btnW_save_Click(object sender, EventArgs e)
        {
            try
            {
                string type = cmbW_type.Text;
                string labName = txtW_Lname.Text;
                int wMaster = Convert.ToInt32(txtW_master.Text);
                int docInCharge = Convert.ToInt32(txtW_doctor.Text);
                insert(type, labName, wMaster, docInCharge);
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

        private void insert(string t, string l, int m, int d)
        {
            if (cmbW_type.Text.Length > 0 && txtW_Lname.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "INSERT INTO Ward ([Lable Name], [Type], [Ward Master], [Doctor In Charge]) " +
                    "VALUES (@lName, @Type, @Wmaster, @Dcharge)";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@lName", l);
                    cmd.Parameters.AddWithValue("@Type", t);
                    cmd.Parameters.AddWithValue("@Wmaster", m);
                    cmd.Parameters.AddWithValue("@Dcharge", d);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Inserted!");
                populateGride();
                clearTextAndComboBoxes() ;
            }
            else if (cmbW_type.Text.Length == 0 && txtW_Lname.Text.Length > 0)
            {
                MessageBox.Show("Enter valid ward type.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbW_type.Items.Clear();
                cmbW_type.Focus();
            }
            else if (cmbW_type.Text.Length > 0 && txtW_Lname.Text.Length == 0)
            {
                MessageBox.Show("Enter valid lable name.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtW_Lname.Clear();
                txtW_Lname.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtW_Lname.Clear();
                cmbW_type.SelectedIndex = -1;
            }
        }

        private void btnW_update_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(txtW_searchID.Text);
                string type = cmbW_type.Text;
                string labName = txtW_Lname.Text;
                int wMaster = Convert.ToInt32(txtW_master.Text);
                int docInCharge = Convert.ToInt32(txtW_doctor.Text);
                update(ID, type, labName, wMaster, docInCharge);
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

        private void update(int id, string t, string l, int m, int d)
        {
            if (cmbW_type.Text.Length > 0 && txtW_Lname.Text.Length > 0)
            {
                SqlConnection con = new dbConnection().ConnectDB();
                string sql =
                    "UPDATE Ward SET [Lable Name] = @lName, [Type] = @Type, [Ward Master] = @Wmaster, [Doctor In Charge] = @Dcharge WHERE ID = @ID;";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@lName", l);
                    cmd.Parameters.AddWithValue("@Type", t);
                    cmd.Parameters.AddWithValue("@Wmaster", m);
                    cmd.Parameters.AddWithValue("@Dcharge", d);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Record Updated!");
                populateGride();
                clearTextAndComboBoxes() ;
                txtW_searchID.Text = "0";
            }
            else if (cmbW_type.Text.Length == 0 && txtW_Lname.Text.Length > 0)
            {
                MessageBox.Show("Enter valid ward type.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbW_type.Items.Clear();
                cmbW_type.Focus();
            }
            else if (cmbW_type.Text.Length > 0 && txtW_Lname.Text.Length == 0)
            {
                MessageBox.Show("Enter valid lable name.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtW_Lname.Clear();
                txtW_Lname.Focus();
            }
            else
            {
                MessageBox.Show("Enter valid Information", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtW_Lname.Clear();
                cmbW_type.SelectedIndex = -1;
            }
        }

        private void btnW_search_Click(object sender, EventArgs e)
        {
            string Lable = txtW_searchLable.Text;
            if (int.TryParse(txtW_searchID.Text, out int ID))
            {
                search(Lable, ID);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
            }
            search(Lable, ID);
        }

        private void search(string l, int id)
        {
            SqlConnection con = new dbConnection().ConnectDB();

            if (!string.IsNullOrEmpty(l) && id == 0)
            {
                string sql = "SELECT * FROM Ward WHERE [Lable Name] = @Lable";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Lable", l);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dgvWards.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            txtW_searchLable.Clear();
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(l) && id != 0)
            {
                string sql = "SELECT * FROM Ward WHERE ID = @ID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cmbW_type.Text = reader["Type"].ToString();
                            txtW_Lname.Text = reader["Lable Name"].ToString();
                            txtW_master.Text = reader["Ward Master"].ToString();
                            txtW_doctor.Text = reader["Doctor In Charge"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                            clearTextAndComboBoxes();
                            txtW_searchID.Text = "0";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please give the input for only one of the above.");
                txtW_searchLable.Clear();
                txtW_searchID.Text = "0";
            }

            con.Close();
        }

        private void btnW_return_Click(object sender, EventArgs e)
        {
            populateGride();
            clearTextAndComboBoxes();
        }

        private void btnW_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtW_searchID.Text, out int ID))
            {
                delete(ID);
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.");
                txtW_searchID.Text = "0";
                txtW_searchID.Focus();
            }
        }

        private void delete(int id)
        {
            SqlConnection con = new dbConnection().ConnectDB();

            if (MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Ward WHERE ID = @ID";

                using (SqlCommand deleteCmd = new SqlCommand(sql, con))
                {
                    deleteCmd.Parameters.AddWithValue("@ID", id);

                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        populateGride();
                        clearTextAndComboBoxes();
                        txtW_searchID.Text= "0";
                    }
                    else
                    {
                        MessageBox.Show("Record not found or could not be deleted.");
                        txtW_searchID.Text = "0";
                    }
                }
            }
            else
            {
                populateGride();
                clearTextAndComboBoxes();
                txtW_searchID.Text = "0";
            }

            con.Close();
        }

    }
}
