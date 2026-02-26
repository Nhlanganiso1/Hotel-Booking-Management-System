namespace Hotel_Booking_Management_System.Manager_Pages
{
    partial class UpdateEmployee
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTXB = new System.Windows.Forms.TextBox();
            this.employeeDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.surnameTXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roleDropDown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTXB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pwdTXB = new System.Windows.Forms.TextBox();
            this.updateEmployeeBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.the_Luxe_ServerDataSet = new Hotel_Booking_Management_System.The_Luxe_ServerDataSet();
            this.employeeTableAdapter = new Hotel_Booking_Management_System.The_Luxe_ServerDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE EMPLOYEE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(217, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SEARCH BY NAME:";
            // 
            // searchTXB
            // 
            this.searchTXB.Location = new System.Drawing.Point(328, 117);
            this.searchTXB.Name = "searchTXB";
            this.searchTXB.Size = new System.Drawing.Size(185, 20);
            this.searchTXB.TabIndex = 2;
            this.searchTXB.TextChanged += new System.EventHandler(this.searchTXB_TextChanged);
            // 
            // employeeDGV
            // 
            this.employeeDGV.AllowUserToAddRows = false;
            this.employeeDGV.AllowUserToDeleteRows = false;
            this.employeeDGV.AutoGenerateColumns = false;
            this.employeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.hotelIDDataGridViewTextBoxColumn,
            this.employeenameDataGridViewTextBoxColumn,
            this.employeesurnameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.employeeDGV.DataSource = this.employeeBindingSource;
            this.employeeDGV.Location = new System.Drawing.Point(12, 167);
            this.employeeDGV.Name = "employeeDGV";
            this.employeeDGV.ReadOnly = true;
            this.employeeDGV.Size = new System.Drawing.Size(742, 258);
            this.employeeDGV.TabIndex = 3;
            this.employeeDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.employeeDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.employeeDGV_DataBindingComplete);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(885, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMPLOYEE DETAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(833, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // nameTXB
            // 
            this.nameTXB.Location = new System.Drawing.Point(836, 184);
            this.nameTXB.Name = "nameTXB";
            this.nameTXB.Size = new System.Drawing.Size(207, 20);
            this.nameTXB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(836, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Surname";
            // 
            // surnameTXB
            // 
            this.surnameTXB.Location = new System.Drawing.Point(836, 240);
            this.surnameTXB.Name = "surnameTXB";
            this.surnameTXB.Size = new System.Drawing.Size(207, 20);
            this.surnameTXB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(836, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Role:";
            // 
            // roleDropDown
            // 
            this.roleDropDown.FormattingEnabled = true;
            this.roleDropDown.Items.AddRange(new object[] {
            "Cleaner",
            "Receptionist",
            "Manager"});
            this.roleDropDown.Location = new System.Drawing.Point(836, 297);
            this.roleDropDown.Name = "roleDropDown";
            this.roleDropDown.Size = new System.Drawing.Size(207, 21);
            this.roleDropDown.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(836, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email:";
            // 
            // emailTXB
            // 
            this.emailTXB.Location = new System.Drawing.Point(836, 353);
            this.emailTXB.Name = "emailTXB";
            this.emailTXB.Size = new System.Drawing.Size(207, 20);
            this.emailTXB.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(836, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password:";
            // 
            // pwdTXB
            // 
            this.pwdTXB.Location = new System.Drawing.Point(836, 407);
            this.pwdTXB.Name = "pwdTXB";
            this.pwdTXB.PasswordChar = '*';
            this.pwdTXB.Size = new System.Drawing.Size(207, 20);
            this.pwdTXB.TabIndex = 14;
            // 
            // updateEmployeeBTN
            // 
            this.updateEmployeeBTN.Location = new System.Drawing.Point(836, 460);
            this.updateEmployeeBTN.Name = "updateEmployeeBTN";
            this.updateEmployeeBTN.Size = new System.Drawing.Size(118, 23);
            this.updateEmployeeBTN.TabIndex = 15;
            this.updateEmployeeBTN.Text = "Update Employee";
            this.updateEmployeeBTN.UseVisualStyleBackColor = true;
            this.updateEmployeeBTN.Click += new System.EventHandler(this.updateEmployeeBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(995, 460);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 16;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_ID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "Hotel_ID";
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            this.hotelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "Employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "Employee_name";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeesurnameDataGridViewTextBoxColumn
            // 
            this.employeesurnameDataGridViewTextBoxColumn.DataPropertyName = "Employee_surname";
            this.employeesurnameDataGridViewTextBoxColumn.HeaderText = "Employee_surname";
            this.employeesurnameDataGridViewTextBoxColumn.Name = "employeesurnameDataGridViewTextBoxColumn";
            this.employeesurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.the_Luxe_ServerDataSet;
            // 
            // the_Luxe_ServerDataSet
            // 
            this.the_Luxe_ServerDataSet.DataSetName = "The_Luxe_ServerDataSet";
            this.the_Luxe_ServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Booking_Management_System.Properties.Resources.Login_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 511);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.updateEmployeeBTN);
            this.Controls.Add(this.pwdTXB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailTXB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roleDropDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.surnameTXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameTXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employeeDGV);
            this.Controls.Add(this.searchTXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UpdateEmployee";
            this.Text = "UpdateEmployee";
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTXB;
        private System.Windows.Forms.DataGridView employeeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeesurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private The_Luxe_ServerDataSet the_Luxe_ServerDataSet;
        private The_Luxe_ServerDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox surnameTXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox roleDropDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailTXB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pwdTXB;
        private System.Windows.Forms.Button updateEmployeeBTN;
        private System.Windows.Forms.Button clearBTN;
    }
}