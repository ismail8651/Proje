using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.DB_Model
{
    class Delcustomer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string fName { get; set; }
        public string pNumber { get; set; }
        public string jName { get; set; }
    }
}
