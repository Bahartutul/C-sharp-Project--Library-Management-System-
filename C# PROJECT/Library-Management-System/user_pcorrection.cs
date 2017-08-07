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
    public partial class user_pcorrection : Form
    {
        public user_pcorrection()
        {
            InitializeComponent();
        }

        private void user_pcorrection_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=LMS");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from user where Seq_pin='" + pinbox.Text + "'", mcon);
                // MySqlDataAdapter mss = new MySqlDataAdapter("select count(*) from user where que='" + que.Text + "'", mcon);

                mcon.Open();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                msd.Fill(dt);
                // mss.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1" && newpassword.Text==con_pass.Text)
                {




                    cmd.CommandText = "update user set password='" + newpassword.Text + "' where Username='"+usernamebox.Text+"'";
                    // cmd.CommandText = "update user set password='" + pass.Text + "' where Username='" + name.Text + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Done");
                }
                else if(newpassword.Text!=con_pass.Text)
                {
                    MessageBox.Show("New_password & Confirm_passwod field does not math please check!!!");
                }

                else
                {
                    MessageBox.Show("Incorrect sequrity pin....!!!!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Close();
            Fpage f = new Fpage();
            f.Show();
            
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void newpasswordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void con_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {


        }

        private void pinbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SQ_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
