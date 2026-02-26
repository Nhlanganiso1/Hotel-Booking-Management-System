namespace Hotel_Booking_Management_System.Manager_Pages
{
    partial class Manage_Room
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.roomDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomNoTXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomTypeTXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.roomCostTXB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomStatusTXB = new System.Windows.Forms.TextBox();
            this.unavailableBTN = new System.Windows.Forms.Button();
            this.availableBTN = new System.Windows.Forms.Button();
            this.roomnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeofroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomcostperdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.the_Luxe_ServerDataSet = new Hotel_Booking_Management_System.The_Luxe_ServerDataSet();
            this.roomTableAdapter = new Hotel_Booking_Management_System.The_Luxe_ServerDataSetTableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roomDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE ROOMS";
            // 
            // searchTXB
            // 
            this.searchTXB.Location = new System.Drawing.Point(415, 153);
            this.searchTXB.Name = "searchTXB";
            this.searchTXB.Size = new System.Drawing.Size(238, 22);
            this.searchTXB.TabIndex = 1;
            this.searchTXB.TextChanged += new System.EventHandler(this.searchTXB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SEARCH BY ROOM NO:";
            // 
            // roomDGV
            // 
            this.roomDGV.AllowUserToAddRows = false;
            this.roomDGV.AllowUserToDeleteRows = false;
            this.roomDGV.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.roomDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomnumberDataGridViewTextBoxColumn,
            this.hotelIDDataGridViewTextBoxColumn,
            this.typeofroomDataGridViewTextBoxColumn,
            this.roomstatusDataGridViewTextBoxColumn,
            this.roomcostperdayDataGridViewTextBoxColumn});
            this.roomDGV.DataSource = this.roomBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.roomDGV.Location = new System.Drawing.Point(88, 207);
            this.roomDGV.Name = "roomDGV";
            this.roomDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.roomDGV.RowHeadersWidth = 51;
            this.roomDGV.RowTemplate.Height = 24;
            this.roomDGV.Size = new System.Drawing.Size(684, 330);
            this.roomDGV.TabIndex = 3;
            this.roomDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(882, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ROOM DETAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room No:";
            // 
            // roomNoTXB
            // 
            this.roomNoTXB.Location = new System.Drawing.Point(887, 254);
            this.roomNoTXB.Name = "roomNoTXB";
            this.roomNoTXB.ReadOnly = true;
            this.roomNoTXB.Size = new System.Drawing.Size(178, 22);
            this.roomNoTXB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type of room:";
            // 
            // roomTypeTXB
            // 
            this.roomTypeTXB.Location = new System.Drawing.Point(887, 293);
            this.roomTypeTXB.Name = "roomTypeTXB";
            this.roomTypeTXB.ReadOnly = true;
            this.roomTypeTXB.Size = new System.Drawing.Size(178, 22);
            this.roomTypeTXB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Room cost:";
            // 
            // roomCostTXB
            // 
            this.roomCostTXB.Location = new System.Drawing.Point(887, 332);
            this.roomCostTXB.Name = "roomCostTXB";
            this.roomCostTXB.ReadOnly = true;
            this.roomCostTXB.Size = new System.Drawing.Size(178, 22);
            this.roomCostTXB.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(795, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Room status:";
            // 
            // roomStatusTXB
            // 
            this.roomStatusTXB.Location = new System.Drawing.Point(887, 366);
            this.roomStatusTXB.Name = "roomStatusTXB";
            this.roomStatusTXB.Size = new System.Drawing.Size(178, 22);
            this.roomStatusTXB.TabIndex = 12;
            // 
            // unavailableBTN
            // 
            this.unavailableBTN.Location = new System.Drawing.Point(808, 420);
            this.unavailableBTN.Name = "unavailableBTN";
            this.unavailableBTN.Size = new System.Drawing.Size(101, 34);
            this.unavailableBTN.TabIndex = 13;
            this.unavailableBTN.Text = "Unavailable";
            this.unavailableBTN.UseVisualStyleBackColor = true;
            this.unavailableBTN.Click += new System.EventHandler(this.unavailableBTN_Click);
            // 
            // availableBTN
            // 
            this.availableBTN.Location = new System.Drawing.Point(963, 420);
            this.availableBTN.Name = "availableBTN";
            this.availableBTN.Size = new System.Drawing.Size(102, 34);
            this.availableBTN.TabIndex = 14;
            this.availableBTN.Text = "Available";
            this.availableBTN.UseVisualStyleBackColor = true;
            this.availableBTN.Click += new System.EventHandler(this.availableBTN_Click);
            // 
            // roomnumberDataGridViewTextBoxColumn
            // 
            this.roomnumberDataGridViewTextBoxColumn.DataPropertyName = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn.HeaderText = "Room_number";
            this.roomnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomnumberDataGridViewTextBoxColumn.Name = "roomnumberDataGridViewTextBoxColumn";
            this.roomnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "Hotel_ID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "Hotel_ID";
            this.hotelIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            this.hotelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeofroomDataGridViewTextBoxColumn
            // 
            this.typeofroomDataGridViewTextBoxColumn.DataPropertyName = "Type_of_room";
            this.typeofroomDataGridViewTextBoxColumn.HeaderText = "Type_of_room";
            this.typeofroomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeofroomDataGridViewTextBoxColumn.Name = "typeofroomDataGridViewTextBoxColumn";
            this.typeofroomDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeofroomDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomstatusDataGridViewTextBoxColumn
            // 
            this.roomstatusDataGridViewTextBoxColumn.DataPropertyName = "Room_status";
            this.roomstatusDataGridViewTextBoxColumn.HeaderText = "Room_status";
            this.roomstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomstatusDataGridViewTextBoxColumn.Name = "roomstatusDataGridViewTextBoxColumn";
            this.roomstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomcostperdayDataGridViewTextBoxColumn
            // 
            this.roomcostperdayDataGridViewTextBoxColumn.DataPropertyName = "Room_cost_per_day";
            this.roomcostperdayDataGridViewTextBoxColumn.HeaderText = "Room cost";
            this.roomcostperdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomcostperdayDataGridViewTextBoxColumn.Name = "roomcostperdayDataGridViewTextBoxColumn";
            this.roomcostperdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomcostperdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.the_Luxe_ServerDataSet;
            // 
            // the_Luxe_ServerDataSet
            // 
            this.the_Luxe_ServerDataSet.DataSetName = "The_Luxe_ServerDataSet";
            this.the_Luxe_ServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // Manage_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Booking_Management_System.Properties.Resources.Login_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 612);
            this.Controls.Add(this.availableBTN);
            this.Controls.Add(this.unavailableBTN);
            this.Controls.Add(this.roomStatusTXB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.roomCostTXB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roomTypeTXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomNoTXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTXB);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manage_Room";
            this.Text = "Manage_Room";
            this.Load += new System.EventHandler(this.Manage_Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView roomDGV;
        private The_Luxe_ServerDataSet the_Luxe_ServerDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private The_Luxe_ServerDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofroomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomcostperdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomNoTXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roomTypeTXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox roomCostTXB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roomStatusTXB;
        private System.Windows.Forms.Button unavailableBTN;
        private System.Windows.Forms.Button availableBTN;
    }
}