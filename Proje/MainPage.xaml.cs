using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using SQLite;
using Proje.DB_Model;

namespace Proje
{
    public partial class MainPage : TabbedPage
    {
        private SQLiteConnection Conn;
        public Customer Cus_Data;
        public MainPage()
        {
            InitializeComponent();
            
            Conn = DependencyService.Get<SQlite_Interface>().GetConnection();
            Conn.CreateTable<Customer>();

        }

        private async void Cus_list_View_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var customer = e.Item as Customer;
            await DisplayAlert("Selected Customer", "Full Name : " + customer.fName + "\nPhone Number : " + customer.pNumber + "\nJob : " + customer.jName, "Ok");
        }
        private void add_Button_clicked(object sender, EventArgs e)
        {
            Cus_Data = new Customer();
            Cus_Data.fName = name.Text;
            Cus_Data.pNumber = number.Text;
            Cus_Data.jName = job.Text;
            Conn.Insert(Cus_Data);
            name.Text = "";
            number.Text = "";
            job.Text = "";
            DisplayAlert("Completed","Customer :  "+ Cus_Data.fName + " ,added","Ok");



        }
     
        private void OnDelete(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
         
            Conn.Delete<Customer>(mi.CommandParameter);
            DisplayAlert("Completed", "Customer" +" Deleted", "Ok");

        }
        private void refresh_Button_clicked(object sender, EventArgs e)
        {
            var data = (from cus in Conn.Table<Customer>() select cus);
            Cus_list_View.ItemsSource = data;
        }
        private void refresh_Button2_clicked(object sender, EventArgs e)
        {
            var data = (from cus in Conn.Table<Customer>() select cus);
            Cusdel_list_View.ItemsSource = data;
        }

    }
}
