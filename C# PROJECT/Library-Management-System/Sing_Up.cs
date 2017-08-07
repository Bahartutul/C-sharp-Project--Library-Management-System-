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
    public partial class Sing_Up : Form
    {
        public Sing_Up()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Sing_Up_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void uname_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
            MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from user where Username='"+uname.Text+"'",mcon);
            DataTable dt = new DataTable();

            mcon.Open();


            msd.Fill(dt);
            if(int.Parse(dt.Rows[0][0].ToString())==0)
            {
                Unamelbl.Text = uname.Text + " is available";
                this.Unamelbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Unamelbl.Text = uname.Text + " is not available";
                this.Unamelbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpass_TextChanged(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Fpage f = new Fpage();
            f.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
            mcon.Open();
            try
            {
                

                
                if (Unamelbl.ForeColor == System.Drawing.Color.Green)
                {
                    if (password.Text == cpass.Text)
                    {
                        MySqlDataAdapter msd = new MySqlDataAdapter("insert into user(Username,Password,Seq_pin,Address,Age,Gender,Mobile_no)values ('" + uname.Text + "','" + cpass.Text + "','" + sp.Text + "','" + address.Text + "','" + age.Text + "','" + comboBox1.Text + "','" + mnum.Text + "')", mcon);
                        DataTable dt = new DataTable();

                        



                        msd.Fill(dt);



                        MessageBox.Show("Done...!!!");
                        

                    }
                }
                else if(Unamelbl.ForeColor == System.Drawing.Color.Red)
                {
                    MessageBox.Show("You can't use this username....change it to continue!!!");
                }
                else //(password.Text!=cpass.Text)
                {
                    MessageBox.Show("Password and Confirm_password field does not match!!!");
                }

            /*    else if(uname.Text==" " || cpass.Text==" " ||sp.Text==" " || address.Text==" " || age.Text==" " || comboBox1.Text==" " || mnum.Text==" " )
                {
                    MessageBox.Show("Insert all the field correctly!!!");
                }*/

               /* else if (dt.Rows[0][0].ToString() == "1")
                {

                    MessageBox.Show("Done");
                }*/
                 /*     else
                  {
                      MessageBox.Show("Insert all data correctly");

                  //}*/
             /*   textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();*/
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      
        private void Unamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
