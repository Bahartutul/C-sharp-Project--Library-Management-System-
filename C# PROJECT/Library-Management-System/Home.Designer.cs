namespace Library_Management_System
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bookControlpanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.Update_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Show_Book_Details = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showdetails = new System.Windows.Forms.DataGridView();
            this.Log_Out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // bookControlpanelToolStripMenuItem
            // 
            this.bookControlpanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Book,
            this.Delete_Book,
            this.Update_Book});
            this.bookControlpanelToolStripMenuItem.Name = "bookControlpanelToolStripMenuItem";
            this.bookControlpanelToolStripMenuItem.Size = new System.Drawing.Size(175, 25);
            this.bookControlpanelToolStripMenuItem.Text = "Book_Control_panel";
            this.bookControlpanelToolStripMenuItem.Click += new System.EventHandler(this.bookControlpanelToolStripMenuItem_Click);
            // 
            // Add_Book
            // 
            this.Add_Book.Name = "Add_Book";
            this.Add_Book.Size = new System.Drawing.Size(182, 26);
            this.Add_Book.Text = "Add_Book";
            this.Add_Book.Click += new System.EventHandler(this.Add_Book_Click);
            // 
            // Delete_Book
            // 
            this.Delete_Book.Name = "Delete_Book";
            this.Delete_Book.Size = new System.Drawing.Size(182, 26);
            this.Delete_Book.Text = "Delete_Book";
            this.Delete_Book.Click += new System.EventHandler(this.Delete_Book_Click);
            // 
            // Update_Book
            // 
            this.Update_Book.Name = "Update_Book";
            this.Update_Book.Size = new System.Drawing.Size(182, 26);
            this.Update_Book.Text = "Update_Book";
            this.Update_Book.Click += new System.EventHandler(this.Update_Book_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookControlpanelToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.employeeDetailsToolStripMenuItem,
            this.supplierDetailsToolStripMenuItem,
            this.borrowDetailsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(79, 66);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(812, 29);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Show_Book_Details});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // Show_Book_Details
            // 
            this.Show_Book_Details.Name = "Show_Book_Details";
            this.Show_Book_Details.Size = new System.Drawing.Size(228, 26);
            this.Show_Book_Details.Text = "Show_Book_Details";
            this.Show_Book_Details.Click += new System.EventHandler(this.Show_Book_Details_Click);
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(158, 25);
            this.employeeDetailsToolStripMenuItem.Text = "Employee_Details";
            this.employeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem_Click);
            // 
            // supplierDetailsToolStripMenuItem
            // 
            this.supplierDetailsToolStripMenuItem.Name = "supplierDetailsToolStripMenuItem";
            this.supplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.supplierDetailsToolStripMenuItem.Text = "Supplier_Details";
            this.supplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.supplierDetailsToolStripMenuItem_Click);
            // 
            // borrowDetailsToolStripMenuItem
            // 
            this.borrowDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.returnBookToolStripMenuItem});
            this.borrowDetailsToolStripMenuItem.Name = "borrowDetailsToolStripMenuItem";
            this.borrowDetailsToolStripMenuItem.Size = new System.Drawing.Size(137, 25);
            this.borrowDetailsToolStripMenuItem.Text = "Borrow_Details";
            this.borrowDetailsToolStripMenuItem.Click += new System.EventHandler(this.borrowDetailsToolStripMenuItem_Click);
            // 
            // showdetails
            // 
            this.showdetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showdetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.showdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showdetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.showdetails.Location = new System.Drawing.Point(44, 122);
            this.showdetails.Name = "showdetails";
            this.showdetails.ReadOnly = true;
            this.showdetails.Size = new System.Drawing.Size(761, 346);
            this.showdetails.TabIndex = 3;
            this.showdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Log_Out
            // 
            this.Log_Out.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_Out.Location = new System.Drawing.Point(756, 475);
            this.Log_Out.Name = "Log_Out";
            this.Log_Out.Size = new System.Drawing.Size(90, 31);
            this.Log_Out.TabIndex = 9;
            this.Log_Out.Text = "Log out";
            this.Log_Out.UseVisualStyleBackColor = true;
            this.Log_Out.Click += new System.EventHandler(this.Log_Out_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "~Welcome to Admin Panel~";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.showDetailsToolStripMenuItem.Text = "Show_Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.returnBookToolStripMenuItem.Text = "Return_Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(865, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log_Out);
            this.Controls.Add(this.showdetails);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem bookControlpanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Add_Book;
        private System.Windows.Forms.ToolStripMenuItem Delete_Book;
        private System.Windows.Forms.ToolStripMenuItem Update_Book;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.DataGridView showdetails;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Show_Book_Details;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierDetailsToolStripMenuItem;
        private System.Windows.Forms.Button Log_Out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem borrowDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;


    }
}