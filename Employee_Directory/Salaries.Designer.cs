namespace Employee_Directory
{
    partial class Salaries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            this.updatebtn = new System.Windows.Forms.Button();
            this.period = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.addbtn = new System.Windows.Forms.Button();
            this.salarylist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.emplist = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attendeddays = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.sal = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dep = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emp = new System.Windows.Forms.Label();
            this.salaryamount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salarylist)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Teal;
            this.updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(224, 551);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(159, 42);
            this.updatebtn.TabIndex = 42;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // period
            // 
            this.period.Checked = true;
            this.period.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.period.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.period.Location = new System.Drawing.Point(49, 362);
            this.period.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.period.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(327, 44);
            this.period.TabIndex = 39;
            this.period.Value = new System.DateTime(2024, 11, 23, 22, 26, 42, 615);
            this.period.ValueChanged += new System.EventHandler(this.period_ValueChanged);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Teal;
            this.addbtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(51, 551);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(145, 42);
            this.addbtn.TabIndex = 41;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // salarylist
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.salarylist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salarylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.salarylist.ColumnHeadersHeight = 4;
            this.salarylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salarylist.DefaultCellStyle = dataGridViewCellStyle6;
            this.salarylist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salarylist.Location = new System.Drawing.Point(551, 210);
            this.salarylist.Name = "salarylist";
            this.salarylist.RowHeadersVisible = false;
            this.salarylist.RowHeadersWidth = 51;
            this.salarylist.RowTemplate.Height = 24;
            this.salarylist.Size = new System.Drawing.Size(694, 441);
            this.salarylist.TabIndex = 38;
            this.salarylist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.salarylist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.salarylist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.salarylist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.salarylist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.salarylist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.salarylist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salarylist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.salarylist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salarylist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.salarylist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salarylist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.salarylist.ThemeStyle.HeaderStyle.Height = 4;
            this.salarylist.ThemeStyle.ReadOnly = false;
            this.salarylist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.salarylist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salarylist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.salarylist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.salarylist.ThemeStyle.RowsStyle.Height = 24;
            this.salarylist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salarylist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.salarylist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salarylist_CellContentClick);
            // 
            // emplist
            // 
            this.emplist.FormattingEnabled = true;
            this.emplist.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.emplist.Location = new System.Drawing.Point(51, 189);
            this.emplist.Name = "emplist";
            this.emplist.Size = new System.Drawing.Size(332, 44);
            this.emplist.TabIndex = 36;
            this.emplist.SelectedIndexChanged += new System.EventHandler(this.emplist_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 798);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1343, 27);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(545, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "Manage Salaries";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(500, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management System";
            // 
            // attendeddays
            // 
            this.attendeddays.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendeddays.Location = new System.Drawing.Point(51, 275);
            this.attendeddays.Name = "attendeddays";
            this.attendeddays.Size = new System.Drawing.Size(332, 37);
            this.attendeddays.TabIndex = 27;
            this.attendeddays.TextChanged += new System.EventHandler(this.attendeddays_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 82);
            this.panel1.TabIndex = 25;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Teal;
            this.logout.Location = new System.Drawing.Point(944, 97);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(84, 36);
            this.logout.TabIndex = 68;
            this.logout.Text = "Logout";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(891, 91);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 67;
            this.pictureBox5.TabStop = false;
            // 
            // sal
            // 
            this.sal.AutoSize = true;
            this.sal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal.ForeColor = System.Drawing.Color.Teal;
            this.sal.Location = new System.Drawing.Point(798, 95);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(78, 36);
            this.sal.TabIndex = 66;
            this.sal.Text = "Salary";
            this.sal.Click += new System.EventHandler(this.sal_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(748, 91);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep.ForeColor = System.Drawing.Color.Teal;
            this.dep.Location = new System.Drawing.Point(589, 95);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(146, 36);
            this.dep.TabIndex = 64;
            this.dep.Text = "Departments";
            this.dep.Click += new System.EventHandler(this.dep_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(539, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(363, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // emp
            // 
            this.emp.AutoSize = true;
            this.emp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp.ForeColor = System.Drawing.Color.Teal;
            this.emp.Location = new System.Drawing.Point(415, 96);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(113, 36);
            this.emp.TabIndex = 70;
            this.emp.Text = "Employee";
            this.emp.Click += new System.EventHandler(this.emp_Click);
            // 
            // salaryamount
            // 
            this.salaryamount.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryamount.Location = new System.Drawing.Point(51, 449);
            this.salaryamount.Name = "salaryamount";
            this.salaryamount.Size = new System.Drawing.Size(332, 37);
            this.salaryamount.TabIndex = 71;
            this.salaryamount.TextChanged += new System.EventHandler(this.salaryamount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(49, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 36);
            this.label7.TabIndex = 72;
            this.label7.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(49, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 36);
            this.label3.TabIndex = 73;
            this.label3.Text = "Days Attended";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(49, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 36);
            this.label4.TabIndex = 74;
            this.label4.Text = "Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(48, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 36);
            this.label5.TabIndex = 75;
            this.label5.Text = "Salary Amount";
            // 
            // Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 825);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salaryamount);
            this.Controls.Add(this.emp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.period);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.salarylist);
            this.Controls.Add(this.emplist);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendeddays);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Salaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salaries";
            ((System.ComponentModel.ISupportInitialize)(this.salarylist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updatebtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker period;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button addbtn;
        private Guna.UI2.WinForms.Guna2DataGridView salarylist;
        private System.Windows.Forms.ComboBox emplist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox attendeddays;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label sal;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label dep;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label emp;
        private System.Windows.Forms.TextBox salaryamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}