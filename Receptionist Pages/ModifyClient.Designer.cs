namespace Hotel_Booking_Management_System.Receptionist_Pages
{
    partial class ModifyClient
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
            this.clientDGV = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTXB = new System.Windows.Forms.TextBox();
            this.surnameTXB = new System.Windows.Forms.TextBox();
            this.emailTXB = new System.Windows.Forms.TextBox();
            this.modifyBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTXB = new System.Windows.Forms.TextBox();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLuxeServerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.the_Luxe_ServerDataSet = new Hotel_Booking_Management_System.The_Luxe_ServerDataSet();
            this.clientTableAdapter = new Hotel_Booking_Management_System.The_Luxe_ServerDataSetTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLuxeServerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFY RESIDENT DETAILS";
            // 
            // clientDGV
            // 
            this.clientDGV.AllowUserToAddRows = false;
            this.clientDGV.AllowUserToDeleteRows = false;
            this.clientDGV.AutoGenerateColumns = false;
            this.clientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientSurnameDataGridViewTextBoxColumn,
            this.clientEmailDataGridViewTextBoxColumn});
            this.clientDGV.DataSource = this.clientBindingSource;
            this.clientDGV.Location = new System.Drawing.Point(58, 253);
            this.clientDGV.Name = "clientDGV";
            this.clientDGV.ReadOnly = true;
            this.clientDGV.RowHeadersWidth = 51;
            this.clientDGV.RowTemplate.Height = 24;
            this.clientDGV.Size = new System.Drawing.Size(732, 341);
            this.clientDGV.TabIndex = 1;
            this.clientDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientDGV_CellDoubleClick);
            this.clientDGV.DoubleClick += new System.EventHandler(this.clientDGV_DoubleClick);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.theLuxeServerDataSetBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(948, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "RESIDENT DETAILS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(906, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(926, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // nameTXB
            // 
            this.nameTXB.Location = new System.Drawing.Point(976, 284);
            this.nameTXB.Name = "nameTXB";
            this.nameTXB.Size = new System.Drawing.Size(228, 22);
            this.nameTXB.TabIndex = 6;
            // 
            // surnameTXB
            // 
            this.surnameTXB.Location = new System.Drawing.Point(976, 326);
            this.surnameTXB.Name = "surnameTXB";
            this.surnameTXB.Size = new System.Drawing.Size(228, 22);
            this.surnameTXB.TabIndex = 7;
            // 
            // emailTXB
            // 
            this.emailTXB.Location = new System.Drawing.Point(976, 378);
            this.emailTXB.Name = "emailTXB";
            this.emailTXB.Size = new System.Drawing.Size(228, 22);
            this.emailTXB.TabIndex = 8;
            // 
            // modifyBTN
            // 
            this.modifyBTN.Location = new System.Drawing.Point(976, 447);
            this.modifyBTN.Name = "modifyBTN";
            this.modifyBTN.Size = new System.Drawing.Size(102, 23);
            this.modifyBTN.TabIndex = 9;
            this.modifyBTN.Text = "MODIFY";
            this.modifyBTN.UseVisualStyleBackColor = true;
            this.modifyBTN.Click += new System.EventHandler(this.modifyBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(1129, 447);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 10;
            this.clearBTN.Text = "CLEAR";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Search Name:";
            // 
            // searchTXB
            // 
            this.searchTXB.Location = new System.Drawing.Point(328, 209);
            this.searchTXB.Name = "searchTXB";
            this.searchTXB.Size = new System.Drawing.Size(258, 22);
            this.searchTXB.TabIndex = 12;
            this.searchTXB.TextChanged += new System.EventHandler(this.searchTXB_TextChanged);
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientSurnameDataGridViewTextBoxColumn
            // 
            this.clientSurnameDataGridViewTextBoxColumn.DataPropertyName = "Client_Surname";
            this.clientSurnameDataGridViewTextBoxColumn.HeaderText = "Client_Surname";
            this.clientSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientSurnameDataGridViewTextBoxColumn.Name = "clientSurnameDataGridViewTextBoxColumn";
            this.clientSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientEmailDataGridViewTextBoxColumn
            // 
            this.clientEmailDataGridViewTextBoxColumn.DataPropertyName = "Client_Email";
            this.clientEmailDataGridViewTextBoxColumn.HeaderText = "Client_Email";
            this.clientEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientEmailDataGridViewTextBoxColumn.Name = "clientEmailDataGridViewTextBoxColumn";
            this.clientEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // theLuxeServerDataSetBindingSource
            // 
            this.theLuxeServerDataSetBindingSource.DataSource = this.the_Luxe_ServerDataSet;
            this.theLuxeServerDataSetBindingSource.Position = 0;
            // 
            // the_Luxe_ServerDataSet
            // 
            this.the_Luxe_ServerDataSet.DataSetName = "The_Luxe_ServerDataSet";
            this.the_Luxe_ServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // ModifyClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Booking_Management_System.Properties.Resources.Login_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1321, 693);
            this.Controls.Add(this.searchTXB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.modifyBTN);
            this.Controls.Add(this.emailTXB);
            this.Controls.Add(this.surnameTXB);
            this.Controls.Add(this.nameTXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientDGV);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "ModifyClient";
            this.Text = "ModifyClient";
            this.Load += new System.EventHandler(this.ModifyClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLuxeServerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView clientDGV;
        private System.Windows.Forms.BindingSource theLuxeServerDataSetBindingSource;
        private The_Luxe_ServerDataSet the_Luxe_ServerDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private The_Luxe_ServerDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTXB;
        private System.Windows.Forms.TextBox surnameTXB;
        private System.Windows.Forms.TextBox emailTXB;
        private System.Windows.Forms.Button modifyBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchTXB;
    }
}