namespace Hotel_Booking_Management_System.Manager_Pages
{
    partial class AddEmployee
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
            this.addEmployeeLabel = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.nameTXB = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTXB = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTXB = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTXB = new System.Windows.Forms.TextBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.roleDropDown = new System.Windows.Forms.ComboBox();
            this.HotelIDLabel = new System.Windows.Forms.Label();
            this.HotelIDTXB = new System.Windows.Forms.TextBox();
            this.the_Luxe_ServerDataSet = new Hotel_Booking_Management_System.The_Luxe_ServerDataSet();
            this.employeeTableAdapter1 = new Hotel_Booking_Management_System.The_Luxe_ServerDataSetTableAdapters.EmployeeTableAdapter();
            this.hotelTableAdapter1 = new Hotel_Booking_Management_System.The_Luxe_ServerDataSetTableAdapters.HotelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addEmployeeLabel
            // 
            this.addEmployeeLabel.AutoSize = true;
            this.addEmployeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.addEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeLabel.ForeColor = System.Drawing.Color.Silver;
            this.addEmployeeLabel.Location = new System.Drawing.Point(281, 108);
            this.addEmployeeLabel.Name = "addEmployeeLabel";
            this.addEmployeeLabel.Size = new System.Drawing.Size(250, 25);
            this.addEmployeeLabel.TabIndex = 0;
            this.addEmployeeLabel.Text = "ADD NEW EMPLOYEE";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(182, 171);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(99, 13);
            this.employeeName.TabIndex = 1;
            this.employeeName.Text = "EMPLOYEE NAME";
            // 
            // nameTXB
            // 
            this.nameTXB.Location = new System.Drawing.Point(185, 187);
            this.nameTXB.Name = "nameTXB";
            this.nameTXB.Size = new System.Drawing.Size(149, 20);
            this.nameTXB.TabIndex = 2;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(182, 221);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(122, 13);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "EMPLOYEE SURNAME";
            // 
            // surnameTXB
            // 
            this.surnameTXB.Location = new System.Drawing.Point(185, 237);
            this.surnameTXB.Name = "surnameTXB";
            this.surnameTXB.Size = new System.Drawing.Size(149, 20);
            this.surnameTXB.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(182, 276);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // passwordTXB
            // 
            this.passwordTXB.Location = new System.Drawing.Point(185, 292);
            this.passwordTXB.Name = "passwordTXB";
            this.passwordTXB.PasswordChar = '*';
            this.passwordTXB.Size = new System.Drawing.Size(149, 20);
            this.passwordTXB.TabIndex = 6;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(437, 220);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(36, 13);
            this.roleLabel.TabIndex = 8;
            this.roleLabel.Text = "ROLE";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(437, 170);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(76, 13);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "WORK EMAIL";
            // 
            // emailTXB
            // 
            this.emailTXB.Location = new System.Drawing.Point(437, 187);
            this.emailTXB.Name = "emailTXB";
            this.emailTXB.Size = new System.Drawing.Size(153, 20);
            this.emailTXB.TabIndex = 10;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(249, 346);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(123, 23);
            this.addEmployeeButton.TabIndex = 11;
            this.addEmployeeButton.Text = "ADD EMPLOYEE";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(473, 346);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // roleDropDown
            // 
            this.roleDropDown.FormattingEnabled = true;
            this.roleDropDown.Items.AddRange(new object[] {
            "Manager",
            "Cleaner",
            "Receptionist"});
            this.roleDropDown.Location = new System.Drawing.Point(437, 236);
            this.roleDropDown.Name = "roleDropDown";
            this.roleDropDown.Size = new System.Drawing.Size(153, 21);
            this.roleDropDown.TabIndex = 7;
            // 
            // HotelIDLabel
            // 
            this.HotelIDLabel.AutoSize = true;
            this.HotelIDLabel.Location = new System.Drawing.Point(437, 275);
            this.HotelIDLabel.Name = "HotelIDLabel";
            this.HotelIDLabel.Size = new System.Drawing.Size(57, 13);
            this.HotelIDLabel.TabIndex = 13;
            this.HotelIDLabel.Text = "HOTEL ID";
            // 
            // HotelIDTXB
            // 
            this.HotelIDTXB.Location = new System.Drawing.Point(437, 291);
            this.HotelIDTXB.Name = "HotelIDTXB";
            this.HotelIDTXB.Size = new System.Drawing.Size(153, 20);
            this.HotelIDTXB.TabIndex = 14;
            // 
            // the_Luxe_ServerDataSet
            // 
            this.the_Luxe_ServerDataSet.DataSetName = "The_Luxe_ServerDataSet";
            this.the_Luxe_ServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // hotelTableAdapter1
            // 
            this.hotelTableAdapter1.ClearBeforeFill = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Booking_Management_System.Properties.Resources.Login_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 489);
            this.Controls.Add(this.HotelIDTXB);
            this.Controls.Add(this.HotelIDLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.emailTXB);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.roleDropDown);
            this.Controls.Add(this.passwordTXB);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.surnameTXB);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameTXB);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.addEmployeeLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.Text = "ADD EMPLOYEE";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addEmployeeLabel;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.TextBox nameTXB;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTXB;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTXB;
        private System.Windows.Forms.Label roleLabel;
        private The_Luxe_ServerDataSet the_Luxe_ServerDataSet;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTXB;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox roleDropDown;
        private System.Windows.Forms.Label HotelIDLabel;
        private System.Windows.Forms.TextBox HotelIDTXB;
        private The_Luxe_ServerDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private The_Luxe_ServerDataSetTableAdapters.HotelTableAdapter hotelTableAdapter1;
    }
}