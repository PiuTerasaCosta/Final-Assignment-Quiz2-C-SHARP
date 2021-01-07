using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookIndex
{
    class BookController
    {
        static Database db = new Database();

       
        public static ArrayList GetAllBooks()
        {
            return db.Books.GetAllBooks();
        }
    }
}
