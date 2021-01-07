using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookIndex
{
    public class Database
    {
        public Books Books { get; set; }

        public Database()
        {
            string connString = @"Server=DESKTOP-90T47VU\SQLEXPRESS;User Id=sa;Password=123456;Database=Q2Assignment";
            SqlConnection conn = new SqlConnection(connString);
            Books = new Books(conn);
            
        }

    }
}
