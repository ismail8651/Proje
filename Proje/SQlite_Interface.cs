using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proje
{
    public interface SQlite_Interface
    {
        SQLiteConnection GetConnection();
    }
}
