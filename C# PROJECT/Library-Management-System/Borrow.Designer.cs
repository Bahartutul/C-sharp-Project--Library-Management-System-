namespace Library_Management_System
{
    partial class Borrow
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
            this.name = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.bookid = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.Bdate = new System.Windows.Forms.Label();
            this.Borrow_date = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Label();
            this.return_date = new System.Windows.Forms.TextBox();
            this.Cdate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Borrorbook = new System.Windows.Forms.Button();
            this.borrowhistory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.num_of_day = new System.Windows.Forms.TextBox();
            this.Set = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(129, 50);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(143, 27);
            this.name.TabIndex = 25;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(42, 91);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(82, 21);
            this.pass.TabIndex = 5;
            this.pass.Text = "Password";
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(129, 89);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '#';
            this.password.Size = new System.Drawing.Size(143, 27);
            this.password.TabIndex = 6;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookid.Location = new System.Drawing.Point(55, 128);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(71, 21);
            this.bookid.TabIndex = 7;
            this.bookid.Text = "Book_Id";
            this.bookid.Click += new System.EventHandler(this.bookid_Click);
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(129, 126);
            this.book_id.Multiline = true;
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(143, 27);
            this.book_id.TabIndex = 8;
            this.book_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Bdate
            // 
            this.Bdate.AutoSize = true;
            this.Bdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdate.Location = new System.Drawing.Point(18, 170);
            this.Bdate.Name = "Bdate";
            this.Bdate.Size = new System.Drawing.Size(108, 21);
            this.Bdate.TabIndex = 9;
            this.Bdate.Text = "Borrow_Date";
            this.Bdate.Click += new System.EventHandler(this.Bdate_Click);
            // 
            // Borrow_date
            // 
            this.Borrow_date.Location = new System.Drawing.Point(129, 167);
            this.Borrow_date.Multiline = true;
            this.Borrow_date.Name = "Borrow_date";
            this.Borrow_date.ReadOnly = true;
            this.Borrow_date.Size = new System.Drawing.Size(143, 27);
            this.Borrow_date.TabIndex = 10;
            this.Borrow_date.TextChanged += new System.EventHandler(this.Borrow_date_TextChanged);
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(23, 205);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(104, 21);
            this.Return.TabIndex = 11;
            this.Return.Text = "Return_Date";
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // return_date
            // 
            this.return_date.Location = new System.Drawing.Point(130, 205);
            this.return_date.Multiline = true;
            this.return_date.Name = "return_date";
            this.return_date.ReadOnly = true;
            this.return_date.Size = new System.Drawing.Size(143, 27);
            this.return_date.TabIndex = 12;
            this.return_date.TextChanged += new System.EventHandler(this.return_date_TextChanged);
            // 
            // Cdate
            // 
            this.Cdate.AutoSize = true;
            this.Cdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cdate.Location = new System.Drawing.Point(491, 7);
            this.Cdate.Name = "Cdate";
            this.Cdate.Size = new System.Drawing.Size(110, 21);
            this.Cdate.TabIndex = 13;
            this.Cdate.Text = "Current_Date";
            this.Cdate.Click += new System.EventHandler(this.Cdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(527, 179);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Borrorbook
            // 
            this.Borrorbook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrorbook.Location = new System.Drawing.Point(403, 143);
            this.Borrorbook.Name = "Borrorbook";
            this.Borrorbook.Size = new System.Drawing.Size(75, 35);
            this.Borrorbook.TabIndex = 17;
            this.Borrorbook.Text = "Borrow";
            this.Borrorbook.UseVisualStyleBackColor = true;
            this.Borrorbook.Click += new System.EventHandler(this.Borrorbook_Click);
            // 
            // borrowhistory
            // 
            this.borrowhistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowhistory.Location = new System.Drawing.Point(373, 190);
            this.borrowhistory.Name = "borrowhistory";
            this.borrowhistory.Size = new System.Drawing.Size(141, 35);
            this.borrowhistory.TabIndex = 18;
            this.borrowhistory.Text = "Borrow_History";
            this.borrowhistory.UseVisualStyleBackColor = true;
            this.borrowhistory.Click += new System.EventHandler(this.borrowhistory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "~Borrow Book~";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(530, 496);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(69, 30);
            this.Exit.TabIndex = 20;
            this.Exit.Text = "Back";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Num_Of_Day";
            // 
            // num_of_day
            // 
            this.num_of_day.Location = new System.Drawing.Point(129, 241);
            this.num_of_day.Multiline = true;
            this.num_of_day.Name = "num_of_day";
            this.num_of_day.Size = new System.Drawing.Size(143, 27);
            this.num_of_day.TabIndex = 22;
            this.num_of_day.TextChanged += new System.EventHandler(this.num_of_day_TextChanged);
            // 
            // Set
            // 
            this.Set.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set.Location = new System.Drawing.Point(402, 96);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(75, 35);
            this.Set.TabIndex = 23;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(404, 232);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 35);
            this.Clear.TabIndex = 24;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(609, 530);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.num_of_day);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borrowhistory);
            this.Controls.Add(this.Borrorbook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cdate);
            this.Controls.Add(this.return_date);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Borrow_date);
            this.Controls.Add(this.Bdate);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.bookid);
            this.Controls.Add(this.password);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.Borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Label Bdate;
        private System.Windows.Forms.TextBox Borrow_date;
        private System.Windows.Forms.Label Return;
        private System.Windows.Forms.TextBox return_date;
        private System.Windows.Forms.Label Cdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Borrorbook;
        private System.Windows.Forms.Button borrowhistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num_of_day;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button Clear;
    }
}