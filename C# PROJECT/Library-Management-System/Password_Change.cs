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
    public partial class Password_Change : Form
    {
        public Password_Change()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Npass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            userhome u = new userhome();
            u.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=LMS");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from User where Username='"+name.Text+"'and Password='"+Opass.Text+"'", mcon);

                mcon.Open();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                msd.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1" && Npass.Text==Cpass.Text)
                {




                    cmd.CommandText = "update User set Password='" + Cpass.Text + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Done");
                }
                else if(Npass.Text!=Cpass.Text)
                {
                    MessageBox.Show("New_password field and Confirm_password field does not match!!!");
                }

                else
                {
                    MessageBox.Show("Does not match user name and password....fill all the field correctly!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Cpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_Change_Load(object sender, EventArgs e)
        {

        }

        private void Opass_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
