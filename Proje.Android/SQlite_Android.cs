using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Proje.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQlite_Android))]

namespace Proje.Droid
{
    public class SQlite_Android:SQlite_Interface
    {
        public SQLiteConnection GetConnection()
        {
            var DB_Name = "My_DB.sql";
            var DB_Path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var Full_Path = System.IO.Path.Combine(DB_Path, DB_Name);
            var Conn = new SQLiteConnection(Full_Path);
            return Conn;
        }
    }
}