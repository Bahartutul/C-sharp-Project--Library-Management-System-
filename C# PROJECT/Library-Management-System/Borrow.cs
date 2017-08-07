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
    public partial class Borrow : Form
    {
        short BookLoan;
        public Borrow()
        {
            InitializeComponent();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            DateTime idate = DateTime.Now;
            Borrow_date.Text = idate.ToString("dd/MM/yyyy");
            timer1.Start();
        }

        private void pass_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookid_Click(object sender, EventArgs e)
        {


        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void borrowhistory_Click(object sender, EventArgs e)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
            string s = "select * from borrow_history where User_Name='"+name.Text+"'";
            MySqlCommand command = new MySqlCommand(s, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
           // label3.Text = table.Rows.Count.ToString();*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime idate = DateTime.Now;

            //Ctime.Text = idate.ToShortDateString();
            Cdate.Text = idate.ToString("dd/MM/yyyy");
            timer1.Start();
        }

        private void Borrow_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Borrorbook_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=LMS");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from user where Username='"+name.Text+"'and Password='" + password.Text + "'", mcon);

                // MySqlDataAdapter mss = new MySqlDataAdapter("select count(*) from user where que='" + que.Text + "'", mcon);

                mcon.Open();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                msd.Fill(dt);
                // mss.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {




                 /*   cmd.CommandText = "update user set password='" + newpasswordbox.Text + "' where Id='" + idbox.Text + "'";
                    // cmd.CommandText = "update user set password='" + pass.Text + "' where Username='" + name.Text + "'";
                    cmd.ExecuteNonQuery();*/

                   MessageBox.Show("User name and Password authintication Done");
                   cmd.CommandText = "insert into borrow_history(User_Name,Book_Id,Borrow_Date,Return_Date)values ('" + name.Text + "','" + book_id.Text + "','" + Borrow_date.Text + "','" + return_date.Text + "')";
                   cmd.ExecuteNonQuery();
                 //  mcon.Open();


                   MessageBox.Show("Book Borrow Successfully Done");
                }

                else
                {
                    MessageBox.Show("Please insert your correct id and password !!!!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
         }

        private void num_of_day_TextChanged(object sender, EventArgs e)
        {

        }

        private void Set_Click(object sender, EventArgs e)
        {
            DateTime BookDueDate;
            DateTime idate = DateTime.Now;

            switch (num_of_day.Text)
            {
                case "0":
                    BookLoan = 0;
                    System.DateTime today = System.DateTime.Now;
                    System.TimeSpan duration = new System.TimeSpan(BookLoan, 0, 0, 0);
                    System.DateTime answear = today.Add(duration);
                   // return_back.Text = answear.ToShortDateString();
                return_date.Text = answear.ToString("dd/MM/yyyy");
           // timer1.Start();

                    break;

                case "1":
                    BookLoan = 1;
                    System.DateTime today1 = System.DateTime.Now;
                    System.TimeSpan duration1 = new System.TimeSpan(BookLoan, 0, 0, 0);
                    System.DateTime answear1 = today1.Add(duration1);
                  //  return_back.Text = answear1.ToShortDateString();
                    return_date.Text = answear1.ToString("dd/MM/yyyy");
                    break;

                case "2":
                    BookLoan = 2;
                    System.DateTime today2 = System.DateTime.Now;
                    System.TimeSpan duration2 = new System.TimeSpan(BookLoan, 0, 0, 0);
                    System.DateTime answear2 = today2.Add(duration2);
                   // return_back.Text = answear2.ToShortDateString();
                    return_date.Text = answear2.ToString("dd/MM/yyyy");
                    break;

                case "3":
                    BookLoan = 3;
                    System.DateTime today3 = System.DateTime.Now;
                    System.TimeSpan duration3 = new System.TimeSpan(BookLoan, 0, 0, 0);
                    System.DateTime answear3 = today3.Add(duration3);
                   // return_back.Text = answear3.ToShortDateString();
                    return_date.Text = answear3.ToString("dd/MM/yyyy");
                    break;

                case "4":
                    BookLoan = 4;
                    System.DateTime today4 = System.DateTime.Now;
                    System.TimeSpan duration4 = new System.TimeSpan(BookLoan, 0, 0, 0);
                    System.DateTime answear4 = today4.Add(duration4);
                    //return_back.Text = answear4.ToShortDateString();
                    return_date.Text = answear4.ToString("dd/MM/yyyy");
                    break;

                case "5":
                    BookLoan = 5;
                    System.DateTime today5 = System.DateTime.Now;
                    System.TimeSpan duration5 = new System.TimeSpan(BookLoan, 0, 0, 0);
                    System.DateTime answear5 = today5.Add(duration5);
                    //return_back.Text = answear5.ToShortDateString();
                    return_date.Text = answear5.ToString("dd/MM/yyyy");
                    break;

                case "6":
                    BookLoan = 6;
                    System.DateTime today6 = System.DateTime.Now;
                    System.TimeSpan duration6 = new System.TimeSpan(BookLoan, 0, 0, 0);
                    System.DateTime answear6 = today6.Add(duration6);
                    //return_back.Text = answear6.ToShortDateString();
                    return_date.Text = answear6.ToString("dd/MM/yyyy");
                    break;

                case "7":
                    BookLoan = 7;
                    System.DateTime today7 = System.DateTime.Now;
                    System.TimeSpan duration7 = new System.TimeSpan(BookLoan, 0, 0, 0);
                    System.DateTime answear7 = today7.Add(duration7);
                    //return_back.Text = answear7.ToShortDateString();
                    return_date.Text = answear7.ToString("dd/MM/yyyy");
                    break;

            }




        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            userhome u = new userhome();
            u.Show();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            name.Clear();
            password.Clear();
            book_id.Clear();
            return_date.Clear();
            num_of_day.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bdate_Click(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {

        }

        private void return_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cdate_Click(object sender, EventArgs e)
        {

        }

        
    }
}
