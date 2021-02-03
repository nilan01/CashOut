using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CashOut
{
    public partial class MainPage : ContentPage
    {
        int num1, num2;
        string op;
        ObservableCollection<Product> products;
        public MainPage()
        {
            InitializeComponent();
            Product hats = new Product("Hat", 30, 25.99);
            Product pants = new Product("Jeans", 30, 35.99);
            Product jackets = new Product("Jackets", 40, 255.99);
            Product shoes = new Product("Shoes", 20, 115.99);
            Product shirts = new Product("Shirts", 30, 35.99);
            Product socks = new Product("Socks", 30, 15.99);

            products = new ObservableCollection<Product>();
            products.Add(hats);
            products.Add(pants);
            products.Add(jackets);
            products.Add(shoes);
            products.Add(shirts);
            products.Add(socks);

            mylist.ItemsSource = products;
        }
        public void Number_Clicked(object sender, EventArgs e) {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            quantity.Text += ((Button)sender).Text;
        }
        public void Clear_Clicked(object sender, EventArgs e)
        {
            quantity.Text = "";

        }
        private void mylist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // This line null checks the object and also gives you a reference
            if (e.SelectedItem is Product product)
            {
                number.Text = product.name;
            }
        }
        void Button_Clicked(System.Object sender, System.EventArgs e) {
            (mylist.SelectedItem as Product).quantity -= Convert.ToInt32(quantity.Text);
        }
    }
}
