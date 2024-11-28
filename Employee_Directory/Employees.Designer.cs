namespace Employee_Directory
{
    partial class Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dailySalary = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DepList = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dateofbirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.joiningdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.EmpList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.sal = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dep = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.emp = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.delEmp = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.ComboBox();
            this.addEmp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 82);
            this.panel1.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(486, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(45, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee Name";
            // 
            // EmpName
            // 
            this.EmpName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.Location = new System.Drawing.Point(49, 192);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(332, 37);
            this.EmpName.TabIndex = 5;
            this.EmpName.TextChanged += new System.EventHandler(this.EmpName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(45, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(45, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(45, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(45, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Join Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(45, 597);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 36);
            this.label8.TabIndex = 16;
            this.label8.Text = "Daily Salary";
            // 
            // dailySalary
            // 
            this.dailySalary.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailySalary.Location = new System.Drawing.Point(49, 636);
            this.dailySalary.Name = "dailySalary";
            this.dailySalary.Size = new System.Drawing.Size(332, 37);
            this.dailySalary.TabIndex = 15;
            this.dailySalary.TextChanged += new System.EventHandler(this.dailySalary_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 798);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1343, 27);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // DepList
            // 
            this.DepList.FormattingEnabled = true;
            this.DepList.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DepList.Location = new System.Drawing.Point(49, 361);
            this.DepList.Name = "DepList";
            this.DepList.Size = new System.Drawing.Size(332, 44);
            this.DepList.TabIndex = 19;
            this.DepList.SelectedIndexChanged += new System.EventHandler(this.DepList_SelectedIndexChanged);
            // 
            // dateofbirth
            // 
            this.dateofbirth.Checked = true;
            this.dateofbirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateofbirth.Location = new System.Drawing.Point(49, 450);
            this.dateofbirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateofbirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(327, 44);
            this.dateofbirth.TabIndex = 21;
            this.dateofbirth.Value = new System.DateTime(2024, 11, 24, 18, 58, 32, 263);
            this.dateofbirth.ValueChanged += new System.EventHandler(this.dateofbirth_ValueChanged);
            // 
            // joiningdate
            // 
            this.joiningdate.Checked = true;
            this.joiningdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.joiningdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.joiningdate.Location = new System.Drawing.Point(51, 539);
            this.joiningdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.joiningdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.joiningdate.Name = "joiningdate";
            this.joiningdate.Size = new System.Drawing.Size(327, 44);
            this.joiningdate.TabIndex = 22;
            this.joiningdate.Value = new System.DateTime(2024, 11, 23, 22, 26, 42, 615);
            this.joiningdate.ValueChanged += new System.EventHandler(this.joiningdate_ValueChanged);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Updatebtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(222, 694);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(159, 42);
            this.Updatebtn.TabIndex = 24;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // EmpList
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.EmpList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.EmpList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.EmpList.ColumnHeadersHeight = 4;
            this.EmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpList.DefaultCellStyle = dataGridViewCellStyle15;
            this.EmpList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpList.Location = new System.Drawing.Point(492, 195);
            this.EmpList.Name = "EmpList";
            this.EmpList.RowHeadersVisible = false;
            this.EmpList.RowHeadersWidth = 51;
            this.EmpList.RowTemplate.Height = 24;
            this.EmpList.Size = new System.Drawing.Size(764, 420);
            this.EmpList.TabIndex = 20;
            this.EmpList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmpList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmpList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.EmpList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpList.ThemeStyle.HeaderStyle.Height = 4;
            this.EmpList.ThemeStyle.ReadOnly = false;
            this.EmpList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.EmpList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpList.ThemeStyle.RowsStyle.Height = 24;
            this.EmpList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpList_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Teal;
            this.logout.Location = new System.Drawing.Point(950, 91);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(84, 36);
            this.logout.TabIndex = 60;
            this.logout.Text = "Logout";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(897, 85);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 59;
            this.pictureBox5.TabStop = false;
            // 
            // sal
            // 
            this.sal.AutoSize = true;
            this.sal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal.ForeColor = System.Drawing.Color.Teal;
            this.sal.Location = new System.Drawing.Point(807, 91);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(78, 36);
            this.sal.TabIndex = 58;
            this.sal.Text = "Salary";
            this.sal.Click += new System.EventHandler(this.sal_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(754, 85);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep.ForeColor = System.Drawing.Color.Teal;
            this.dep.Location = new System.Drawing.Point(598, 91);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(146, 36);
            this.dep.TabIndex = 56;
            this.dep.Text = "Departments";
            this.dep.Click += new System.EventHandler(this.dep_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(545, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // emp
            // 
            this.emp.AutoSize = true;
            this.emp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp.ForeColor = System.Drawing.Color.Teal;
            this.emp.Location = new System.Drawing.Point(422, 91);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(113, 36);
            this.emp.TabIndex = 54;
            this.emp.Text = "Employee";
            this.emp.Click += new System.EventHandler(this.emp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(369, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // delEmp
            // 
            this.delEmp.BackColor = System.Drawing.Color.Crimson;
            this.delEmp.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.delEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delEmp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEmp.ForeColor = System.Drawing.Color.White;
            this.delEmp.Location = new System.Drawing.Point(222, 742);
            this.delEmp.Name = "delEmp";
            this.delEmp.Size = new System.Drawing.Size(159, 42);
            this.delEmp.TabIndex = 61;
            this.delEmp.Text = "Delete";
            this.delEmp.UseVisualStyleBackColor = false;
            this.delEmp.Click += new System.EventHandler(this.delEmp_Click);
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(51, 274);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(332, 44);
            this.gender.TabIndex = 62;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // addEmp
            // 
            this.addEmp.BackColor = System.Drawing.Color.Teal;
            this.addEmp.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp.ForeColor = System.Drawing.Color.White;
            this.addEmp.Location = new System.Drawing.Point(51, 694);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(145, 42);
            this.addEmp.TabIndex = 63;
            this.addEmp.Text = "Add";
            this.addEmp.UseVisualStyleBackColor = false;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 825);
            this.Controls.Add(this.addEmp);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.delEmp);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.emp);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.joiningdate);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.EmpList);
            this.Controls.Add(this.DepList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dailySalary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dailySalary;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox DepList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateofbirth;
        private Guna.UI2.WinForms.Guna2DateTimePicker joiningdate;
        private System.Windows.Forms.Button Updatebtn;
        private Guna.UI2.WinForms.Guna2DataGridView EmpList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label sal;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label dep;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label emp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button delEmp;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Button addEmp;
    }
}