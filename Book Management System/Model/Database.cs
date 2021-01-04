using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.Model
{
     public class Database
     {
            public Books Books { get; set; }
            public Database()
            {
               string connString = "Data Source=DESKTOP-MF28SRI;Database=Assignment_quiz 2;Integrated Security=true;";
               SqlConnection conn = new SqlConnection(connString);
               Books = new Books(conn);
               return conn;
    }
}
}