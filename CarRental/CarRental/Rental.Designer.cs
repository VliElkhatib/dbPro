
namespace CarRental
{
    partial class Rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rental));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RentalDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FeesTb = new System.Windows.Forms.TextBox();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CarRegCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CustCb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 92);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rental";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Rental System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 489);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 15);
            this.panel2.TabIndex = 21;
            // 
            // RentalDGV
            // 
            this.RentalDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.RentalDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalDGV.GridColor = System.Drawing.SystemColors.Control;
            this.RentalDGV.Location = new System.Drawing.Point(348, 133);
            this.RentalDGV.Name = "RentalDGV";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentalDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RentalDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.RentalDGV.Size = new System.Drawing.Size(429, 193);
            this.RentalDGV.TabIndex = 62;
            this.RentalDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(338, 442);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 29);
            this.button4.TabIndex = 61;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(134, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 29);
            this.button3.TabIndex = 60;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(244, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 59;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IdTb
            // 
            this.IdTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IdTb.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.Location = new System.Drawing.Point(134, 133);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(156, 22);
            this.IdTb.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 57;
            this.label7.Text = "Id";
            // 
            // FeesTb
            // 
            this.FeesTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FeesTb.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesTb.Location = new System.Drawing.Point(134, 351);
            this.FeesTb.Name = "FeesTb";
            this.FeesTb.Size = new System.Drawing.Size(156, 22);
            this.FeesTb.TabIndex = 56;
            this.FeesTb.TextChanged += new System.EventHandler(this.FeesTb_TextChanged);
            // 
            // CustNameTb
            // 
            this.CustNameTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CustNameTb.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(134, 240);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(156, 22);
            this.CustNameTb.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 54;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "Cars On Rent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 53;
            this.label9.Text = "Rental Date";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(24, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 52;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "CarReg";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // CarRegCb
            // 
            this.CarRegCb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CarRegCb.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRegCb.FormattingEnabled = true;
            this.CarRegCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CarRegCb.Location = new System.Drawing.Point(134, 168);
            this.CarRegCb.Name = "CarRegCb";
            this.CarRegCb.Size = new System.Drawing.Size(156, 20);
            this.CarRegCb.TabIndex = 66;
            this.CarRegCb.SelectionChangeCommitted += new System.EventHandler(this.CarRegCb_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "CustId";
            // 
            // RentDate
            // 
            this.RentDate.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.RentDate.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.RentDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RentDate.Location = new System.Drawing.Point(134, 276);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(156, 22);
            this.RentDate.TabIndex = 69;
            this.RentDate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.RentDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 19);
            this.label10.TabIndex = 70;
            this.label10.Text = "Fees";
            // 
            // ReturnDate
            // 
            this.ReturnDate.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.ReturnDate.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.ReturnDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate.Location = new System.Drawing.Point(134, 313);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(156, 22);
            this.ReturnDate.TabIndex = 72;
            this.ReturnDate.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            this.ReturnDate.ValueChanged += new System.EventHandler(this.ReturnDate_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 71;
            this.label11.Text = "Return Date";
            // 
            // CustCb
            // 
            this.CustCb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CustCb.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustCb.FormattingEnabled = true;
            this.CustCb.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CustCb.Location = new System.Drawing.Point(134, 205);
            this.CustCb.Name = "CustCb";
            this.CustCb.Size = new System.Drawing.Size(156, 20);
            this.CustCb.TabIndex = 73;
            this.CustCb.SelectionChangeCommitted += new System.EventHandler(this.CustCb_SelectionChangeCommitted);
            // 
            // Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.CustCb);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CarRegCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RentalDGV);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FeesTb);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental";
            this.Load += new System.EventHandler(this.Rental_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView RentalDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FeesTb;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CarRegCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CustCb;
    }
}