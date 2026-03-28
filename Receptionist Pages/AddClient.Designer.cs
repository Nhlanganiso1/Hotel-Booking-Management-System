namespace Hotel_Booking_Management_System.Receptionist_Pages
{
    partial class AddClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameTXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTXB = new System.Windows.Forms.TextBox();
            this.addResidentBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.clientTableAdapter2 = new Hotel_Booking_Management_System.The_Luxe_ServerDataSetTableAdapters.ClientTableAdapter();
            this.the_Luxe_ServerDataSet1 = new Hotel_Booking_Management_System.The_Luxe_ServerDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW RESIDENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // nameTXB
            // 
            this.nameTXB.Location = new System.Drawing.Point(468, 252);
            this.nameTXB.Name = "nameTXB";
            this.nameTXB.Size = new System.Drawing.Size(249, 22);
            this.nameTXB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "SURNAME:";
            // 
            // surnameTXB
            // 
            this.surnameTXB.Location = new System.Drawing.Point(468, 307);
            this.surnameTXB.Name = "surnameTXB";
            this.surnameTXB.Size = new System.Drawing.Size(249, 22);
            this.surnameTXB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "EMAIL:";
            // 
            // emailTXB
            // 
            this.emailTXB.Location = new System.Drawing.Point(468, 369);
            this.emailTXB.Name = "emailTXB";
            this.emailTXB.Size = new System.Drawing.Size(249, 22);
            this.emailTXB.TabIndex = 6;
            // 
            // addResidentBTN
            // 
            this.addResidentBTN.Location = new System.Drawing.Point(426, 432);
            this.addResidentBTN.Name = "addResidentBTN";
            this.addResidentBTN.Size = new System.Drawing.Size(129, 23);
            this.addResidentBTN.TabIndex = 7;
            this.addResidentBTN.Text = "ADD RESIDENT";
            this.addResidentBTN.UseVisualStyleBackColor = true;
            this.addResidentBTN.Click += new System.EventHandler(this.addResidentBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(601, 432);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(116, 23);
            this.clearBTN.TabIndex = 8;
            this.clearBTN.Text = "CLEAR";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // clientTableAdapter2
            // 
            this.clientTableAdapter2.ClearBeforeFill = true;
            // 
            // the_Luxe_ServerDataSet1
            // 
            this.the_Luxe_ServerDataSet1.DataSetName = "The_Luxe_ServerDataSet";
            this.the_Luxe_ServerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Booking_Management_System.Properties.Resources.Login_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 692);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.addResidentBTN);
            this.Controls.Add(this.emailTXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surnameTXB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.the_Luxe_ServerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameTXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTXB;
        private System.Windows.Forms.Button addResidentBTN;
        private System.Windows.Forms.Button clearBTN;
        
        
        private The_Luxe_ServerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private The_Luxe_ServerDataSetTableAdapters.ClientTableAdapter clientTableAdapter2;
        private The_Luxe_ServerDataSet the_Luxe_ServerDataSet1;
    }
}