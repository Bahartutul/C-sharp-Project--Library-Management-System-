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
    public partial class Book_Return : Form
    {
        public Book_Return()
        {
            InitializeComponent();
        }

        private void Borror_Details_Load(object sender, EventArgs e)
        {
            DateTime idate = DateTime.Now;
            CDate.Text = idate.ToString("dd/MM/yyyy");
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void retrn_Click(object sender, EventArgs e)
        {
            
            try
            {
              MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from  borrow_history where Book_Id='"+book_id.Text+"'", mcon);
                mcon.Open();
            //  MySqlDataAdapter msd = new MySqlDataAdapter("delete from book_details where Book_Id='"+textBox1.Text+"'", mcon);
                DataTable dt = new DataTable();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                msd.Fill(dt);
                

              //  if (mcon.State == ConnectionState.Open)
               if (dt.Rows[0][0].ToString() == "1")
                {

                   cmd.CommandText= "delete from borrow_history where Book_Id='" + book_id.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Return Done....");
                }
               else
               {
                   MessageBox.Show("Book_Id does not found for Return!!!");
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            book_id.Clear();
            user_name.Clear();
            Borrow_date.Clear();
            return_date.Clear();
            CDate.Clear();
            fine.Clear();

        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime idate = DateTime.Now;

            //Ctime.Text = idate.ToShortDateString();
            CDate.Text = idate.ToString("dd/MM/yyyy");
            timer1.Start();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            string query = "select * from borrow_history where Book_Id='" + book_id.Text + "'and User_name='"+user_name.Text+"'";
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
            //  MySqlDataAdapter msd = new MySqlDataAdapter("select * from book_details", mcon);
            MySqlCommand cmd = new MySqlCommand(query, mcon);
            MySqlDataReader myReader;
            try
            {
                mcon.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sBook_Id = myReader.GetString("Book_Id");
                    string sUser_name = myReader.GetString("User_name");
                    string sBorrow_date = myReader.GetString("Borrow_date");
                    string sReturn_date = myReader.GetString("Return_date");
                    
                    book_id.Text = sBook_Id;
                    user_name.Text = sUser_name;
                    Borrow_date.Text = sBorrow_date;
                    return_date.Text = sReturn_date;
                   /* int a = System.Convert.ToInt32(return_date.Text);
                    int b = System.Convert.ToInt32(CDate.Text);
                    int c = (b-a)*5;
                    fine.Text = System.Convert.ToString(c);*/
                    
                   
                }

               /* DateTime d1 = System.Convert.ToDateTime(CDate.Text);
                DateTime d2 = System.Convert.ToDateTime(return_date.Text);
                //  string a="5";
                // DateTime d3=System.Convert.ToDateTime(a);
                TimeSpan t = (d1 - d2);
                double d3 = t.TotalDays * 5;
                fine.Text = System.Convert.ToString(d3);*/
                
                  //  DateTime d = Calendar1.SelectedDate;
                    // int a;
                  //  return_date.Text = d.ToShortDateString();
                    string s = Convert.ToDateTime(CDate.Text).ToShortDateString();
                    string s1 = Convert.ToDateTime(return_date.Text).ToShortDateString();
                    DateTime dt = Convert.ToDateTime(s).Date;
                    DateTime dt1 = Convert.ToDateTime(s1).Date;
                    if (dt > dt1)
                    {
                       // Response.Write("<script>alert(' Not a valid Date to extend warranty')</script>");
                        MessageBox.Show(".......");
                    }
                    else
                    {
                        string diff = dt1.Subtract(dt).ToString();
                       // Response.Write(diff);
                        fine.Text = diff;
                       // Session["diff"] = Label18.Text;
                    }
                }   
            
            catch (Exception ex)
            {

            }

        }
        public void searchdata(string valueTosearch)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
            string s = "select * from borrow_history where CONCAT(`User_Name`)like '%" + valueTosearch + "%'";
            MySqlCommand command = new MySqlCommand(s, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
           count.Text = table.Rows.Count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueTosearch = user_name.Text.ToString();
            searchdata(valueTosearch);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

      
    }
}
