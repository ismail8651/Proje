using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proje.DB_Model
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } 
        public string fName { get; set; }
        public string pNumber { get; set; }
        public string jName { get; set; }

    }
}
