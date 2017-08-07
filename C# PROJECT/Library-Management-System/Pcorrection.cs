using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace Library_Management_System
{
    public partial class Pcorrection : Form
    {
      
        public Pcorrection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Pcorrection_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=LMS");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from admin where Seq_pin='"+seq_pin.Text+"'", mcon);
               // MySqlDataAdapter mss = new MySqlDataAdapter("select count(*) from user where que='" + que.Text + "'", mcon);

                mcon.Open();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                                DataTable dt=new DataTable();
                                msd.Fill(dt);
                               // mss.Fill(dt);

                                if (dt.Rows[0][0].ToString() == "1" && npass.Text==con_pass.Text)
                                {
                 
                         


                cmd.CommandText = "update admin set Password='" + con_pass.Text + "' where Username='" + name.Text+ "'";
               // cmd.CommandText = "update user set password='" + pass.Text + "' where Username='" + name.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Done...!!!");

           
                 }
                                else if(npass.Text!=con_pass.Text)
                                {
                                    MessageBox.Show("New_password field and Confirm_password field does not match...please check again!!!");
                                }
                else
                {
                    MessageBox.Show("Sequrity que answer incorrect!!!!");
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        
        
            
                
     
}
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Fpage f = new Fpage();
            f.Show();
        }

        private void que_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void npass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
