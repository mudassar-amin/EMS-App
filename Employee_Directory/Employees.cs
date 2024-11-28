using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee_Directory
{
    public partial class Employees : Form
    {
        Functions Con;

        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ListEmployees();
            LoadDepartments();
        }

        // Display all employees in the grid
        private void ListEmployees()
        {
            try
            {
                // Join EmployeeTb with DepartmentTb to get the department name
                string Query = @"
            SELECT 
                e.EmpId, 
                e.EmpName, 
                e.EmpGender, 
                e.EmpDOB, 
                d.DepName AS DepartmentName, 
                e.EmpJoinDate, 
                e.EmpSalary
            FROM 
                EmployeeTb e
            INNER JOIN 
                DepartmentTb d ON e.EmpDep = d.DepId";

                // Fetch data and bind to the grid
                EmpList.DataSource = Con.GetData(Query);

                // Set column headers
                EmpList.Columns["EmpId"].HeaderText = "ID";
                EmpList.Columns["EmpName"].HeaderText = "Name";
                EmpList.Columns["EmpGender"].HeaderText = "Gender";
                EmpList.Columns["EmpDOB"].HeaderText = "Date of Birth";
                EmpList.Columns["DepartmentName"].HeaderText = "Department Name";
                EmpList.Columns["EmpJoinDate"].HeaderText = "Joining Date";
                EmpList.Columns["EmpSalary"].HeaderText = "Salary";

                // Adjust column widths
                EmpList.Columns["EmpId"].Width = 30; // Smaller width for ID column
                EmpList.Columns["EmpName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Name column fills remaining space
                EmpList.Columns["EmpGender"].Width = 100; // Fixed width for Gender column
                EmpList.Columns["EmpDOB"].Width = 150; // Adjust width for Date of Birth
                EmpList.Columns["DepartmentName"].Width = 150; // Adjust width for Department Name
                EmpList.Columns["EmpJoinDate"].Width = 150; // Adjust width for Joining Date
                EmpList.Columns["EmpSalary"].Width = 100; // Fixed width for Salary column

                // Align column content
                EmpList.Columns["EmpId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                EmpList.Columns["EmpName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                EmpList.Columns["EmpGender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                EmpList.Columns["EmpDOB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                EmpList.Columns["DepartmentName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                EmpList.Columns["EmpJoinDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                EmpList.Columns["EmpSalary"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Enable full row selection
                EmpList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                EmpList.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }



        // Load departments into the dropdown
        private void LoadDepartments()
        {
            try
            {
                string Query = "SELECT DepId, DepName FROM DepartmentTb";
                DepList.DataSource = Con.GetData(Query);
                DepList.DisplayMember = "DepName"; // Show department name
                DepList.ValueMember = "DepId";    // Use department ID as the value
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}");
            }
        }

        // Add a new employee
        private void addEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(EmpName.Text) || string.IsNullOrWhiteSpace(gender.Text) ||
                    DepList.SelectedValue == null || string.IsNullOrWhiteSpace(dailySalary.Text))
                {
                    MessageBox.Show("Missing Data! Please fill all fields.");
                    return;
                }

                string Emp = EmpName.Text.Trim();
                string Gender = gender.Text.Trim();
                int DepId = Convert.ToInt32(DepList.SelectedValue);
                DateTime Dob = dateofbirth.Value;
                DateTime JDate = joiningdate.Value;
                int Salary = Convert.ToInt32(dailySalary.Text.Trim());

                string Query = "INSERT INTO EmployeeTb (EmpName, EmpGender, EmpDOB, EmpDep, EmpJoinDate, EmpSalary) " +
                               "VALUES (@EmpName, @EmpGender, @EmpDOB, @EmpDep, @EmpJoinDate, @EmpSalary)";
                SqlParameter[] parameters = {
                    new SqlParameter("@EmpName", Emp),
                    new SqlParameter("@EmpGender", Gender),
                    new SqlParameter("@EmpDOB", Dob),
                    new SqlParameter("@EmpDep", DepId),
                    new SqlParameter("@EmpJoinDate", JDate),
                    new SqlParameter("@EmpSalary", Salary)
                };

                int rowsAffected = Con.SetData(Query, parameters);

                if (rowsAffected > 0)
                {
                    ListEmployees();
                    MessageBox.Show("Employee added successfully!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add employee.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Update an existing employee
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an employee to update.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(EmpName.Text) || string.IsNullOrWhiteSpace(gender.Text) ||
                    DepList.SelectedValue == null || string.IsNullOrWhiteSpace(dailySalary.Text))
                {
                    MessageBox.Show("Missing Data! Please fill all fields.");
                    return;
                }

                int EmpId = Convert.ToInt32(EmpList.SelectedRows[0].Cells["EmpId"].Value);
                string Emp = EmpName.Text.Trim();
                string Gender = gender.Text.Trim();
                int DepId = Convert.ToInt32(DepList.SelectedValue);
                DateTime Dob = dateofbirth.Value;
                DateTime JDate = joiningdate.Value;
                int Salary = Convert.ToInt32(dailySalary.Text.Trim());

                string Query = "UPDATE EmployeeTb SET EmpName = @EmpName, EmpGender = @EmpGender, EmpDOB = @EmpDOB, " +
                               "EmpDep = @EmpDep, EmpJoinDate = @EmpJoinDate, EmpSalary = @EmpSalary " +
                               "WHERE EmpId = @EmpId";
                SqlParameter[] parameters = {
                    new SqlParameter("@EmpName", Emp),
                    new SqlParameter("@EmpGender", Gender),
                    new SqlParameter("@EmpDOB", Dob),
                    new SqlParameter("@EmpDep", DepId),
                    new SqlParameter("@EmpJoinDate", JDate),
                    new SqlParameter("@EmpSalary", Salary),
                    new SqlParameter("@EmpId", EmpId)
                };

                int rowsAffected = Con.SetData(Query, parameters);

                if (rowsAffected > 0)
                {
                    ListEmployees();
                    MessageBox.Show("Employee updated successfully!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to update employee.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Delete_employee
        private void delEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an employee to delete.");
                    return;
                }

                int EmpId = Convert.ToInt32(EmpList.SelectedRows[0].Cells["EmpId"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;

                string Query = "DELETE FROM EmployeeTb WHERE EmpId = @EmpId";
                SqlParameter[] parameters = { new SqlParameter("@EmpId", EmpId) };

                int rowsAffected = Con.SetData(Query, parameters);

                if (rowsAffected > 0)
                {
                    ListEmployees();
                    MessageBox.Show("Employee deleted successfully!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete employee.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Populate fields when a row is selected
        private void EmpList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmpList.SelectedRows.Count > 0)
            {
                // Populate employee details
                EmpName.Text = EmpList.SelectedRows[0].Cells["EmpName"].Value.ToString();
                gender.Text = EmpList.SelectedRows[0].Cells["EmpGender"].Value.ToString();
                dateofbirth.Value = Convert.ToDateTime(EmpList.SelectedRows[0].Cells["EmpDOB"].Value);
                joiningdate.Value = Convert.ToDateTime(EmpList.SelectedRows[0].Cells["EmpJoinDate"].Value);
                dailySalary.Text = EmpList.SelectedRows[0].Cells["EmpSalary"].Value.ToString();

                // Match department name to set the selected value in the dropdown
                string departmentName = EmpList.SelectedRows[0].Cells["DepartmentName"].Value.ToString();
                foreach (DataRowView item in DepList.Items)
                {
                    if (item["DepName"].ToString() == departmentName)
                    {
                        DepList.SelectedValue = item["DepId"];
                        break;
                    }
                }
            }
        }




        private void EmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DepList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateofbirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void joiningdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dailySalary_TextChanged(object sender, EventArgs e)
        {

        }




        // Clear input fields
        private void ClearFields()
        {
            EmpName.Text = "";
            gender.SelectedIndex = -1;
            DepList.SelectedIndex = -1;
            dateofbirth.Value = DateTime.Now;
            joiningdate.Value = DateTime.Now;
            dailySalary.Text = "";
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
