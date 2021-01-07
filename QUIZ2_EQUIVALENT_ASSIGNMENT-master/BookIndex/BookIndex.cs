using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookIndex
{
    public partial class BookIndex : Form
    {
        public BookIndex()
        {
           
            InitializeComponent();
            dataGridView.DataSource = BookController.GetAllBooks();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Clck(object sender, EventArgs e)
        {
            string connString = @"Server=DESKTOP-90T47VU\SQLEXPRESS;User Id=sa;Password=123456;Database=aiub_demo";
            SqlConnection conn = new SqlConnection(connString);
            string query = "Select * From books Where Id ='" + SchBox.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable d = new DataTable();
            sda.Fill(d);
            dataGridView.DataSource = d;
            conn.Close();
            

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookDetailsForm b = new BookDetailsForm();
            b.textBoxId.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            b.textBoxBookName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            b.textBoxAuthor.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            b.textBoxEdition.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            b.ShowDialog();
        }

        
    }
}
