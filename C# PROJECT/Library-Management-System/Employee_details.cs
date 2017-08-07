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
    public partial class Employee_details : Form
    {
        public Employee_details()
        {
            InitializeComponent();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Get_details_Click(object sender, EventArgs e)
        {
            string query = "select * from employee where ID='" + textBox1.Text + "'";
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
            MySqlCommand cmd = new MySqlCommand(query, mcon);
            MySqlDataReader myReader;
            try
            {
                mcon.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sEmployee_Id = myReader.GetString("ID");
                    string sEmployee_Name = myReader.GetString("Name");
                    string sAdress = myReader.GetString("Adress");
                    string sAge = myReader.GetString("Age");
                    string sDate = myReader.GetString("Joining_Date");
                    string sSalary = myReader.GetString("Salary");
                    textBox1.Text = sEmployee_Id;
                    textBox2.Text = sEmployee_Name;
                    textBox3.Text = sAdress;
                    textBox4.Text = sAge;
                    textBox6.Text = sDate;
                    textBox5.Text = sSalary;

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Showbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("select * from employee", mcon);

                mcon.Open();
                DataSet ds = new DataSet();
                msd.Fill(ds, "lms");
                Showbox.DataSource = ds.Tables["lms"];
                mcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("insert into employee(ID,Name,Adress,Age,Salary,Joining_Date)values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+textBox6.Text+"')", mcon);
                DataTable dt = new DataTable();

                msd.Fill(dt);
                mcon.Open();

             
                MessageBox.Show("1 Row is added correctly");

               
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("delete from employee where Id='" + textBox1.Text + "'", mcon);
                DataTable dt = new DataTable();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                msd.Fill(dt);
                mcon.Open();

                if (mcon.State == ConnectionState.Open)
                {

                    MessageBox.Show("Done");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=LMS");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from employee where ID='" + textBox1.Text + "'", mcon);
                mcon.Open();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                msd.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {

                    cmd.CommandText = "update employee set Name='" + textBox2.Text + "',Adress='" + textBox3.Text + "',Age='" + textBox4.Text + "',Salary='" + textBox5.Text + "',Joining_Date='"+textBox6.Text+"' where ID='" + textBox1.Text + "'";
                    

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Done");
                }

                else
                {
                    MessageBox.Show("Id does not found for update!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Employee_details_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
