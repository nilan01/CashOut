using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CashOut
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            /*
            Product hats = new Product("Hat", 30, 25.99);
            Product pants = new Product("Hat", 30, 35.99);
            Product jackets = new Product("Hat", 40, 255.99);
            Product shoes = new Product("Hat", 20, 115.99);
            Product shirts = new Product("Hat", 30, 35.99);
            Product socks = new Product("Hat", 30, 15.99);


            ObservableCollection<Product> products = new ObservableCollection<Product>();
            products.Add(hats);
            Console.WriteLine(products[0].name);
            */
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
