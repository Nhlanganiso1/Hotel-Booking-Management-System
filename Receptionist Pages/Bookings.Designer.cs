namespace Hotel_Booking_Management_System.Receptionist_Pages
{
    partial class Bookings
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DTP_Check_IN = new System.Windows.Forms.DateTimePicker();
            this.DTP_Check_OUT = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.the_Luxe_ServerDataSet = new Hotel_Booking_Management_System.The_Luxe_ServerDataSet();
            this.theLuxeServerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLuxeServerDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.the_Luxe_ServerDataSet;
            this.comboBox1.DisplayMember = "Hotel.City";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "City";
            this.comboBox1.ValueMember = "Hotel.Hotel_ID";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.the_Luxe_ServerDataSet;
            this.comboBox2.DisplayMember = "Hotel.Province";
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(666, 322);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 28);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Province";
            this.comboBox2.ValueMember = "Hotel.Hotel_ID";
            // 
            // DTP_Check_IN
            // 
            this.DTP_Check_IN.Location = new System.Drawing.Point(334, 379);
            this.DTP_Check_IN.Name = "DTP_Check_IN";
            this.DTP_Check_IN.Size = new System.Drawing.Size(249, 22);
            this.DTP_Check_IN.TabIndex = 2;
            this.DTP_Check_IN.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DTP_Check_OUT
            // 
            this.DTP_Check_OUT.Location = new System.Drawing.Point(666, 379);
            this.DTP_Check_OUT.Name = "DTP_Check_OUT";
            this.DTP_Check_OUT.Size = new System.Drawing.Size(248, 22);
            this.DTP_Check_OUT.TabIndex = 3;
            this.DTP_Check_OUT.ValueChanged += new System.EventHandler(this.DTP_Check_OUT_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox3.Location = new System.Drawing.Point(334, 435);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(249, 28);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.Text = "Persons ";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox4.Location = new System.Drawing.Point(666, 435);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(248, 28);
            this.comboBox4.TabIndex = 6;
            this.comboBox4.Text = "Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Check-In";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Check-Out";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // the_Luxe_ServerDataSet
            // 
            this.the_Luxe_ServerDataSet.DataSetName = "The_Luxe_ServerDataSet";
            this.the_Luxe_ServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theLuxeServerDataSetBindingSource
            // 
            this.theLuxeServerDataSetBindingSource.DataSource = this.the_Luxe_ServerDataSet;
            this.theLuxeServerDataSetBindingSource.Position = 0;
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Booking_Management_System.Properties.Resources.Login_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTP_Check_OUT);
            this.Controls.Add(this.DTP_Check_IN);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bookings";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.Bookings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLuxeServerDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker DTP_Check_IN;
        private System.Windows.Forms.DateTimePicker DTP_Check_OUT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource theLuxeServerDataSetBindingSource;
        private The_Luxe_ServerDataSet the_Luxe_ServerDataSet;
    }
}