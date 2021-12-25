
namespace CarRental
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnTb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DelayTb = new System.Windows.Forms.TextBox();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CarIdTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FineTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.RentalDGV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.ReturnDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(815, 92);
            this.panel1.TabIndex = 5;
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
            this.label3.Location = new System.Drawing.Point(784, 9);
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
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Return";
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
            // ReturnDate
            // 
            this.ReturnDate.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.ReturnDate.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.ReturnDate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate.Location = new System.Drawing.Point(130, 235);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(158, 22);
            this.ReturnDate.TabIndex = 89;
            this.ReturnDate.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // ReturnTb
            // 
            this.ReturnTb.AutoSize = true;
            this.ReturnTb.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnTb.Location = new System.Drawing.Point(21, 235);
            this.ReturnTb.Name = "ReturnTb";
            this.ReturnTb.Size = new System.Drawing.Size(99, 19);
            this.ReturnTb.TabIndex = 88;
            this.ReturnTb.Text = "Return Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 87;
            this.label10.Text = "Delay";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(193, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 81;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // IdTb
            // 
            this.IdTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IdTb.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTb.Location = new System.Drawing.Point(130, 115);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(158, 22);
            this.IdTb.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 79;
            this.label7.Text = "Id";
            // 
            // DelayTb
            // 
            this.DelayTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DelayTb.Enabled = false;
            this.DelayTb.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayTb.Location = new System.Drawing.Point(132, 270);
            this.DelayTb.Name = "DelayTb";
            this.DelayTb.Size = new System.Drawing.Size(156, 22);
            this.DelayTb.TabIndex = 78;
            // 
            // CustNameTb
            // 
            this.CustNameTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CustNameTb.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameTb.Location = new System.Drawing.Point(130, 197);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(158, 22);
            this.CustNameTb.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 76;
            this.label6.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(70, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 74;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarIdTb
            // 
            this.CarIdTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CarIdTb.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarIdTb.Location = new System.Drawing.Point(130, 156);
            this.CarIdTb.Name = "CarIdTb";
            this.CarIdTb.Size = new System.Drawing.Size(158, 22);
            this.CarIdTb.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 90;
            this.label5.Text = "CarReg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 93;
            this.label8.Text = "Fine";
            // 
            // FineTb
            // 
            this.FineTb.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FineTb.Enabled = false;
            this.FineTb.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FineTb.Location = new System.Drawing.Point(132, 310);
            this.FineTb.Name = "FineTb";
            this.FineTb.Size = new System.Drawing.Size(156, 22);
            this.FineTb.TabIndex = 92;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(353, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 29);
            this.button4.TabIndex = 94;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RentalDGV
            // 
            this.RentalDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.RentalDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalDGV.GridColor = System.Drawing.SystemColors.Control;
            this.RentalDGV.Location = new System.Drawing.Point(363, 119);
            this.RentalDGV.Name = "RentalDGV";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentalDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RentalDGV.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.RentalDGV.Size = new System.Drawing.Size(429, 116);
            this.RentalDGV.TabIndex = 96;
            this.RentalDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalDGV_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 95;
            this.label9.Text = "Cars On Rent";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ReturnDGV
            // 
            this.ReturnDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnDGV.GridColor = System.Drawing.SystemColors.Control;
            this.ReturnDGV.Location = new System.Drawing.Point(363, 276);
            this.ReturnDGV.Name = "ReturnDGV";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReturnDGV.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.ReturnDGV.Size = new System.Drawing.Size(429, 116);
            this.ReturnDGV.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 97;
            this.label4.Text = "Cars Returned";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 15);
            this.panel2.TabIndex = 99;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(815, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ReturnDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RentalDGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FineTb);
            this.Controls.Add(this.CarIdTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.ReturnTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DelayTb);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label ReturnTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DelayTb;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CarIdTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FineTb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView RentalDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ReturnDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}