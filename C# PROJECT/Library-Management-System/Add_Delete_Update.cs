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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void Role_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("insert into book_details(Book_Id,Book_Name,Edition,Writer_Name,shelf_No)values ('" + book_id.Text + "','" + book_name.Text + "','" + edition.Text + "','" + writer_name.Text + "','" + shelf_no.Text + "')", mcon);
               DataTable dt = new DataTable();

                msd.Fill(dt);
                mcon.Open();

             /*   MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=LMS");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from book_details where Book_ID='"+textBox1.Text+"',Book_Name='"+textBox2.Text+"',Edition'"+textBox3.Text+"',Writer_Name'"+textBox4.Text+"',Shelf_No'"+textBox5.Text+"'", mcon);

                mcon.Open();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                msd.Fill(dt);*/
           
             //  if(dt.Rows.Count==1)
              //  if (dt.Rows[0][0].ToString() == "1")
                
                   /* cmd.CommandText = "insert into book_details(Book_Id,Book_Name,Edition,Writer_Name,shelf_No)values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'";
                    cmd.ExecuteNonQuery();*/
                    MessageBox.Show("1 Row is added correctly");
                
              /*  else
                {
                    MessageBox.Show("Insert all data correctly");

                }*/
               book_id.Clear();
                book_name.Clear();
                edition.Clear();
                writer_name.Clear();
                shelf_no.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from book_details where Book_Id='"+book_id.Text+"'", mcon);
                mcon.Open();
            //  MySqlDataAdapter msd = new MySqlDataAdapter("delete from book_details where Book_Id='"+textBox1.Text+"'", mcon);
                DataTable dt = new DataTable();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                msd.Fill(dt);
                

              //  if (mcon.State == ConnectionState.Open)
               if (dt.Rows[0][0].ToString() == "1")
                {

                   cmd.CommandText= "delete from book_details where Book_Id='" + book_id.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
               else
               {
                   MessageBox.Show("Book_Id does not found for delete!!!");
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            book_id.Clear();
            book_name.Clear();
            edition.Clear();
            writer_name.Clear();
            shelf_no.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=LMS");
                MySqlDataAdapter msd = new MySqlDataAdapter("select count(*) from book_details where Book_Id='" + book_id.Text + "'", mcon);

                mcon.Open();
                MySqlCommand cmd = mcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                msd.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {




                    cmd.CommandText = "update book_details set Book_Name='" + book_name.Text + "',Edition='" + edition.Text + "',Writer_Name='" + writer_name.Text + "',Shelf_No='" + shelf_no.Text + "' where Book_Id='" + book_id.Text + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Done");
                }

                else
                {
                    MessageBox.Show("Book_Id does not found for update!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            book_id.Clear();
            book_name.Clear();
            edition.Clear();
            writer_name.Clear();
            shelf_no.Clear();
        }


          /*  try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
              
                
                    // MySqlDataAdapter msd = new MySqlDataAdapter(@"UPDATE  book_details SET Book_Name='" + textBox2.Text + "'Edition='" + textBox3.Text + "'Writer_Name='" + textBox4.Text + "'Shelf_No='" + textBox5.Text + "' WHERE (Book_Id='" + textBox1.Text + "')", mcon);
                    MySqlDataAdapter msd = new MySqlDataAdapter("update book_details set Book_Id='" + textBox1.Text + "',Book_Name='" + textBox2.Text + "',Edition='" + textBox3.Text + "',Writer_Name='" + textBox4.Text + "',shelf_No='" + textBox5.Text + "' where (Book_Id='" + textBox1.Text + "')", mcon);

                    DataTable dt = new DataTable();
                    msd.Fill(dt);
                    
                        MessageBox.Show("update success full");
                    
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }*/

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("select * from book_details", mcon);
               
                mcon.Open();
                DataSet ds = new DataSet();
                msd.Fill(ds, "lms");
                Showbox.DataSource = ds.Tables["lms"];
                mcon.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Get_details_Click(object sender, EventArgs e)
        {
            string query="select * from book_details where Book_Id='"+book_id.Text+"'";
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
          //  MySqlDataAdapter msd = new MySqlDataAdapter("select * from book_details", mcon);
            MySqlCommand cmd=new MySqlCommand(query,mcon);
            MySqlDataReader myReader;
            try
            {
                mcon.Open();
                myReader=cmd.ExecuteReader();
                while(myReader.Read())
                {
                    string sBook_Id = myReader.GetString("Book_Id");
                    string sBook_Name = myReader.GetString("Book_Name");
                    string sEdition = myReader.GetString("Edition");
                    string sWriter_Name = myReader.GetString("Writer_Name");
                    string sShelf_No = myReader.GetString("Shelf_No");
                    book_id.Text = sBook_Id;
                    book_name.Text = sBook_Name;
                    edition.Text = sEdition;
                    writer_name.Text = sWriter_Name;
                    shelf_no.Text = sShelf_No;
                }
            }
           catch(Exception ex)
            {

            }




           
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            book_id.Clear();
            book_name.Clear();
            edition.Clear();
            writer_name.Clear();
            shelf_no.Clear();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home();
            h.Show();
        }
    }
}
