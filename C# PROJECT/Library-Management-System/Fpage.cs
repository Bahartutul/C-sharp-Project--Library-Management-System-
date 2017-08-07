using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class Fpage : Form
    {
        public Fpage()
        {
            InitializeComponent();
        }

        private void Fpage_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Pcorrection p = new Pcorrection();
            p.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd=new MySqlDataAdapter("select count(*) from admin where username='"+username.Text+"'and password='"+password.Text+"'",mcon);
                DataTable dt=new DataTable();
                msd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Pleasecheck username & password correctly");
                }

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
            MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from user where username='" + name1.Text + "'and password='" + pass1.Text + "'", mcon);
            DataTable dt = new DataTable();
            msd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                userhome h = new userhome();
                h.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Pleasecheck username & password correctly");
               
            }
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            user_pcorrection p = new user_pcorrection();
            p.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Sing_Up s = new Sing_Up();
            s.Show();
            this.Hide();
        }

      
    }
}
