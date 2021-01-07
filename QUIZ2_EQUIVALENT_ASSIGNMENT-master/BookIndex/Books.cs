using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace BookIndex
{
   public class Books
    {
        SqlConnection conn;
        public Books(SqlConnection conn)
        {
            this.conn = conn;
        }
        
        public ArrayList GetAllBooks()
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string quary = string.Format("SELECT * FROM Books ");
            SqlCommand cmd = new SqlCommand(quary, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                
                book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));

                books.Add(book);
            }
          
            conn.Close();
            return books;

        }
    }
}
