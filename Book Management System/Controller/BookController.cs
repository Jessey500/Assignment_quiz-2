using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.Controller
{
    public class BookController
    {
        public static Database db = new Database();
        public static ArrayList GetAllBook(int id)
        {
            return db.Books.GetAllBook(id);
        }

    }
}
