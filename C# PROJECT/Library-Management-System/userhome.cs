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
    public partial class userhome : Form
    {
        public userhome()
        {
            InitializeComponent();
        }

        private void userhome_Load(object sender, EventArgs e)
        {
            searchdata("");

        }
        public void searchdata(string valueTosearch)
        {
            MySqlConnection mcon = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Lms");
            string s = "select * from book_details where CONCAT(`Book_Id`, `Book_Name`, `Edition`, `Writer_Name`, `Shelf_No`)like '%" + valueTosearch + "%'";
            MySqlCommand command = new MySqlCommand(s, mcon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
           label3.Text = table.Rows.Count.ToString();

        }

        private void Search_Click(object sender, EventArgs e)
        {
          
            string valueTosearch = textBox1.Text.ToString();
            searchdata(valueTosearch);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            this.Close();
            Fpage f = new Fpage();
            f.Show();

        }

        private void return_date_Click(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void borrow_book_Click(object sender, EventArgs e)
        {
            this.Close();
            Borrow b = new Borrow();
            b.Show();
        }

        private void Cpass_Click(object sender, EventArgs e)
        {
            this.Close();
            Password_Change pc = new Password_Change();
            pc.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
      
    }
}
