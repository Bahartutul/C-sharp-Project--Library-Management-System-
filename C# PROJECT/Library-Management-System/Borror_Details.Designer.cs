namespace Library_Management_System
{
    partial class Book_Return
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.retrn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Label();
            this.return_date = new System.Windows.Forms.TextBox();
            this.Borrow_date = new System.Windows.Forms.TextBox();
            this.Bdate = new System.Windows.Forms.Label();
            this.CDate = new System.Windows.Forms.TextBox();
            this.fine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(492, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(141, 54);
            this.user_name.Multiline = true;
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(143, 27);
            this.user_name.TabIndex = 4;
            this.user_name.TextChanged += new System.EventHandler(this.user_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // retrn
            // 
            this.retrn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrn.Location = new System.Drawing.Point(340, 248);
            this.retrn.Name = "retrn";
            this.retrn.Size = new System.Drawing.Size(127, 30);
            this.retrn.TabIndex = 20;
            this.retrn.Text = "Return";
            this.retrn.UseVisualStyleBackColor = true;
            this.retrn.Click += new System.EventHandler(this.retrn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Book Id";
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(141, 94);
            this.book_id.Multiline = true;
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(143, 27);
            this.book_id.TabIndex = 22;
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(37, 179);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(104, 21);
            this.Return.TabIndex = 23;
            this.Return.Text = "Return_Date";
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // return_date
            // 
            this.return_date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.return_date.Location = new System.Drawing.Point(142, 176);
            this.return_date.Multiline = true;
            this.return_date.Name = "return_date";
            this.return_date.ReadOnly = true;
            this.return_date.Size = new System.Drawing.Size(143, 27);
            this.return_date.TabIndex = 26;
            // 
            // Borrow_date
            // 
            this.Borrow_date.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Borrow_date.Location = new System.Drawing.Point(141, 138);
            this.Borrow_date.Multiline = true;
            this.Borrow_date.Name = "Borrow_date";
            this.Borrow_date.ReadOnly = true;
            this.Borrow_date.Size = new System.Drawing.Size(143, 27);
            this.Borrow_date.TabIndex = 25;
            // 
            // Bdate
            // 
            this.Bdate.AutoSize = true;
            this.Bdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdate.Location = new System.Drawing.Point(30, 141);
            this.Bdate.Name = "Bdate";
            this.Bdate.Size = new System.Drawing.Size(108, 21);
            this.Bdate.TabIndex = 24;
            this.Bdate.Text = "Borrow_Date";
            // 
            // CDate
            // 
            this.CDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CDate.Location = new System.Drawing.Point(141, 218);
            this.CDate.Multiline = true;
            this.CDate.Name = "CDate";
            this.CDate.ReadOnly = true;
            this.CDate.Size = new System.Drawing.Size(143, 27);
            this.CDate.TabIndex = 27;
            this.CDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fine
            // 
            this.fine.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fine.Location = new System.Drawing.Point(141, 254);
            this.fine.Multiline = true;
            this.fine.Name = "fine";
            this.fine.ReadOnly = true;
            this.fine.Size = new System.Drawing.Size(143, 27);
            this.fine.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fine";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "Get_details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(340, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "Current_Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Result_found:";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(148, 510);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(19, 21);
            this.count.TabIndex = 35;
            this.count.Text = "0";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(498, 509);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(66, 32);
            this.back.TabIndex = 36;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 37);
            this.label7.TabIndex = 37;
            this.label7.Text = "~Book Return~";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Book_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(576, 542);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.back);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fine);
            this.Controls.Add(this.CDate);
            this.Controls.Add(this.return_date);
            this.Controls.Add(this.Borrow_date);
            this.Controls.Add(this.Bdate);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.retrn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Book_Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Return";
            this.Load += new System.EventHandler(this.Borror_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retrn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Label Return;
        private System.Windows.Forms.TextBox return_date;
        private System.Windows.Forms.TextBox Borrow_date;
        private System.Windows.Forms.Label Bdate;
        private System.Windows.Forms.TextBox CDate;
        private System.Windows.Forms.TextBox fine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label7;
    }
}