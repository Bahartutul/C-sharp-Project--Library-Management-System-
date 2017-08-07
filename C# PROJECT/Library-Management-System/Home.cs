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
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
            
        }

        

        private void Home_Load(object sender, EventArgs e)
        {
           // this.Bounds = Screen.PrimaryScreen.Bounds;  //make full screen
        }

       

      

        private void Add_Book_Click(object sender, EventArgs e)
        {
            
           Role r = new Role();
            r.Show();
            this.Close();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Book_Click(object sender, EventArgs e)
        {
            Role r = new Role();
            r.Show();
            this.Close();
        }

        private void Update_Book_Click(object sender, EventArgs e)
        {
            Role r = new Role();
            r.Show();
            this.Close();
        }

        private void Show_Book_Details_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("select * from book_details", mcon);

                mcon.Open();
                DataSet ds = new DataSet();
                msd.Fill(ds, "lms");
                showdetails.DataSource = ds.Tables["lms"];
                mcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_details ed= new Employee_details();
            ed.Show();
            this.Close();
           /*   try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("select * from employee", mcon);
               
                mcon.Open();
                DataSet ds = new DataSet();
                msd.Fill(ds, "lms");
                showdetails.DataSource = ds.Tables["lms"];
                mcon.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void bookControlpanelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("select * from supplier", mcon);

                mcon.Open();
                DataSet ds = new DataSet();
                msd.Fill(ds, "lms");
                showdetails.DataSource = ds.Tables["lms"];
                mcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void Log_Out_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Fpage f = new Fpage();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void borrowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
                MySqlDataAdapter msd = new MySqlDataAdapter("select * from borrow_history", mcon);

                mcon.Open();
                DataSet ds = new DataSet();
                msd.Fill(ds, "lms");
                showdetails.DataSource = ds.Tables["lms"];
                mcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Book_Return b = new Book_Return();
            b.Show();
        }


     


        }

       

        
    }

