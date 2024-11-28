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

namespace Employee_Directory
{
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            LoadEmployees(); // Load employee names into dropdown
            ListSalaries();

        }

        // Load employee names into the dropdown
        private void LoadEmployees()
        {
            try
            {
                string Query = "SELECT EmpId, EmpName FROM EmployeeTb";
                DataTable employees = Con.GetData(Query);
                emplist.DataSource = employees;
                emplist.DisplayMember = "EmpName"; // Show employee name
                emplist.ValueMember = "EmpId";    // Use employee ID as value
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }


        private void ListSalaries()
        {
            try
            {
                string Query = @"
            SELECT 
                s.SCode, 
                e.EmpName AS EmployeeName, 
                s.Attendence, 
                s.Period, 
                s.Amount, 
                s.PayDate
            FROM 
                SalaryTb s
            INNER JOIN 
                EmployeeTb e ON s.Employee = e.EmpId";
                salarylist.DataSource = Con.GetData(Query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading salaries: {ex.Message}");
            }
        }


        private void emplist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void attendeddays_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (emplist.SelectedValue != null && int.TryParse(attendeddays.Text, out int days))
                {
                    string Query = $"SELECT EmpSalary FROM EmployeeTb WHERE EmpId = {emplist.SelectedValue}";
                    DataTable dt = Con.GetData(Query);
                    if (dt.Rows.Count > 0)
                    {
                        int dailySalary = Convert.ToInt32(dt.Rows[0]["EmpSalary"]);
                        salaryamount.Text = (dailySalary * days).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating salary: {ex.Message}");
            }

        }

        private void period_ValueChanged(object sender, EventArgs e)
        {

        }

        private void salaryamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure all required fields are filled
                if (emplist.SelectedValue == null || string.IsNullOrWhiteSpace(attendeddays.Text) || string.IsNullOrWhiteSpace(salaryamount.Text))
                {
                    MessageBox.Show("Missing Data! Please fill all fields.");
                    return;
                }

                // Retrieve the employee ID from the dropdown (ValueMember should be EmpId)
                int empId = Convert.ToInt32(emplist.SelectedValue); // Get EmpId from the dropdown
                int days = Convert.ToInt32(attendeddays.Text); // Attended days
                string periodStr = period.Value.ToString("yyyy-MM"); // Format Period as string (e.g., "2024-11")
                int amount = Convert.ToInt32(salaryamount.Text); // Salary amount
                DateTime payDate = DateTime.Now; // Current date as PayDate

                // Insert query
                string Query = "INSERT INTO SalaryTb (Employee, Attendence, Period, Amount, PayDate) VALUES (@Employee, @Attendence, @Period, @Amount, @PayDate)";
                SqlParameter[] parameters = {
                new SqlParameter("@Employee", empId),
                new SqlParameter("@Attendence", days),
                new SqlParameter("@Period", periodStr),
                new SqlParameter("@Amount", amount),
                new SqlParameter("@PayDate", payDate)
                 };

                // Execute the query using your SetData method
                int rowsAffected = Con.SetData(Query, parameters);

                if (rowsAffected > 0)
                {
                    ListSalaries(); // Refresh the salary list
                    MessageBox.Show("Salary record added successfully!");
                    ClearFields(); // Clear the input fields
                }
                else
                {
                    MessageBox.Show("Failed to add salary record.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (salarylist.SelectedRows.Count == 0 || emplist.SelectedValue == null || string.IsNullOrWhiteSpace(attendeddays.Text) || string.IsNullOrWhiteSpace(salaryamount.Text))
                {
                    MessageBox.Show("Missing Data! Please select a record and fill all fields.");
                    return;
                }

                int salaryId = Convert.ToInt32(salarylist.SelectedRows[0].Cells["SalaryId"].Value);
                int empId = Convert.ToInt32(emplist.SelectedValue);
                int days = Convert.ToInt32(attendeddays.Text);
                DateTime periodDate = period.Value;
                int amount = Convert.ToInt32(salaryamount.Text);

                string Query = "UPDATE SalaryTb SET Employee = @Employee, Attendence = @Attendence, Period = @Period, Amount = @Amount, PayDate = @PayDate WHERE SCode = @SCode";
                ;
                SqlParameter[] parameters = {
                    new SqlParameter("@EmpId", empId),
                    new SqlParameter("@Period", periodDate),
                    new SqlParameter("@AttendedDays", days),
                    new SqlParameter("@SalaryAmount", amount),
                    new SqlParameter("@SalaryId", salaryId)
                };

                int rowsAffected = Con.SetData(Query, parameters);

                if (rowsAffected > 0)
                {
                    ListSalaries();
                    MessageBox.Show("Salary record updated successfully!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to update salary record.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void salarylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (salarylist.SelectedRows.Count > 0)
            {
                emplist.Text = salarylist.SelectedRows[0].Cells["EmpName"].Value.ToString();
                period.Value = Convert.ToDateTime(salarylist.SelectedRows[0].Cells["Period"].Value);
                attendeddays.Text = salarylist.SelectedRows[0].Cells["AttendedDays"].Value.ToString();
                salaryamount.Text = salarylist.SelectedRows[0].Cells["SalaryAmount"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            emplist.SelectedIndex = -1;
            attendeddays.Text = "";
            salaryamount.Text = "";
            period.Value = DateTime.Now;
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
