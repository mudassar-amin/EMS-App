using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Directory
{
    public partial class Departments : Form
    {
        Functions Con;

        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ListDepartments();
            deplist.SelectionChanged += Deplist_SelectionChanged;
        }

        private void ListDepartments()
        {
            try
            {
                string Query = "SELECT DepId, DepName FROM DepartmentTb";
                deplist.DataSource = Con.GetData(Query);

                // Set column headers
                deplist.Columns["DepId"].HeaderText = "ID";
                deplist.Columns["DepName"].HeaderText = "Department Name";

                // Adjust column widths
                deplist.Columns["DepId"].Width = 50; 
                deplist.Columns["DepName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Make the name column fill the remaining space

                
                deplist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                deplist.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(DepName.Text))
                {
                    MessageBox.Show("Missing data! Please enter a department name.");
                    return;
                }

                string Dep = DepName.Text.Trim();

                // Parameterized query to prevent SQL injection
                string Query = "INSERT INTO DepartmentTb (DepName) VALUES (@DepName)";
                SqlParameter[] parameters = {
                    new SqlParameter("@DepName", Dep)
                };

                int rowsAffected = Con.SetData(Query, parameters);

                if (rowsAffected > 0)
                {
                    ListDepartments(); 
                    MessageBox.Show("Department added successfully!");
                    DepName.Text = ""; 
                }
                else
                {
                    MessageBox.Show("Failed to add department.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void Deplist_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (deplist.SelectedRows.Count > 0)
                {
                    
                    DepName.Text = deplist.SelectedRows[0].Cells["DepName"].Value.ToString();
                }
                else
                {
                    
                    DepName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while selecting the row: {ex.Message}");
            }
        }


        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (deplist.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a department to edit.");
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(DepName.Text))
                {
                    MessageBox.Show("Missing data! Please enter a department name.");
                    return;
                }

                
                int DepId = Convert.ToInt32(deplist.SelectedRows[0].Cells["DepId"].Value); // Assuming 'DepId' is the column name
                string Dep = DepName.Text.Trim(); 

                
                string Query = "UPDATE DepartmentTb SET DepName = @DepName WHERE DepId = @DepId";
                SqlParameter[] parameters = {
                new SqlParameter("@DepName", Dep),
                new SqlParameter("@DepId", DepId)
                };

                
                int rowsAffected = Con.SetData(Query, parameters);

                // Provide feedback to the user
                if (rowsAffected > 0)
                {
                    ListDepartments(); // Refresh the list
                    MessageBox.Show("Department updated successfully!");
                    DepName.Text = ""; // Clear the text field
                }
                else
                {
                    MessageBox.Show("Failed to update department.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (deplist.SelectedRows.Count == 0 || deplist.SelectedRows[0].Cells["DepId"].Value == null)
                {
                    MessageBox.Show("Please select a valid department to delete.");
                    return;
                }

                // Retrieve the selected department ID
                int DepId = Convert.ToInt32(deplist.SelectedRows[0].Cells["DepId"].Value);

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;

                // Delete query
                string Query = "DELETE FROM DepartmentTb WHERE DepId = @DepId";
                SqlParameter[] parameters = {
            new SqlParameter("@DepId", DepId)
        };

                // Execute the delete
                int rowsAffected = Con.SetData(Query, parameters);

                
                if (rowsAffected > 0)
                {
                    ListDepartments(); 
                    MessageBox.Show("Department deleted successfully!");
                    DepName.Text = ""; 
                }
                else
                {
                    MessageBox.Show("Failed to delete department. It may have dependencies.");
                }
            }
            catch (SqlException ex) when (ex.Number == 547) 
            {
                MessageBox.Show("Cannot delete this department because it is referenced in other records.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void emp_Click(object sender, EventArgs e)
        {
            // Open the Employees form
            Employees empForm = new Employees();
            empForm.Show();
            this.Hide(); // Optional: Hide the current form
        }

        private void dep_Click(object sender, EventArgs e)
        {
            // Open the Departments form
            Departments depForm = new Departments();
            depForm.Show();
            this.Hide(); // Optional: Hide the current form
        }

        private void sal_Click(object sender, EventArgs e)
        {
            // Open the Salaries form
            Salaries salForm = new Salaries();
            salForm.Show();
            this.Hide(); // Optional: Hide the current form
        }
    }
}
