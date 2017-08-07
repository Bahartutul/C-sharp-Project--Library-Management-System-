namespace Library_Management_System
{
    partial class user_pcorrection
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
            this.Username = new System.Windows.Forms.Label();
            this.SQ = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.pinbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.con_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(319, 87);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(91, 21);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // SQ
            // 
            this.SQ.AutoSize = true;
            this.SQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQ.Location = new System.Drawing.Point(300, 134);
            this.SQ.Name = "SQ";
            this.SQ.Size = new System.Drawing.Size(111, 21);
            this.SQ.TabIndex = 2;
            this.SQ.Text = "Sequrity Pin :";
            this.SQ.Click += new System.EventHandler(this.SQ_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(414, 84);
            this.usernamebox.Multiline = true;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(178, 27);
            this.usernamebox.TabIndex = 3;
            this.usernamebox.TextChanged += new System.EventHandler(this.usernamebox_TextChanged);
            // 
            // pinbox
            // 
            this.pinbox.Location = new System.Drawing.Point(415, 131);
            this.pinbox.Multiline = true;
            this.pinbox.Name = "pinbox";
            this.pinbox.PasswordChar = '#';
            this.pinbox.Size = new System.Drawing.Size(138, 27);
            this.pinbox.TabIndex = 6;
            this.pinbox.TextChanged += new System.EventHandler(this.pinbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "New-Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(415, 182);
            this.newpassword.Multiline = true;
            this.newpassword.Name = "newpassword";
            this.newpassword.PasswordChar = '#';
            this.newpassword.Size = new System.Drawing.Size(178, 27);
            this.newpassword.TabIndex = 8;
            this.newpassword.TextChanged += new System.EventHandler(this.newpasswordbox_TextChanged);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(529, 284);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 37);
            this.back.TabIndex = 11;
            this.back.Text = "Exit";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(447, 284);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 37);
            this.submit.TabIndex = 12;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // con_pass
            // 
            this.con_pass.Location = new System.Drawing.Point(415, 230);
            this.con_pass.Multiline = true;
            this.con_pass.Name = "con_pass";
            this.con_pass.PasswordChar = '#';
            this.con_pass.Size = new System.Drawing.Size(178, 27);
            this.con_pass.TabIndex = 13;
            this.con_pass.TextChanged += new System.EventHandler(this.con_pass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Confirm-Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "~User Password Correction~";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(53, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // user_pcorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(624, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.con_pass);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.SQ);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "user_pcorrection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_pcorrection";
            this.Load += new System.EventHandler(this.user_pcorrection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label SQ;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox pinbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newpassword;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox con_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}