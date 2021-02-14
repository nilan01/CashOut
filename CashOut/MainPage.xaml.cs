using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashOut.Models;
using Xamarin.Forms;

namespace CashOut
{
    public partial class MainPage : ContentPage
    {
        int num1, num2;
        string op;
        Manager manager = new Manager();


        public MainPage()
        {
            InitializeComponent();
            mylist.ItemsSource = manager.products;

        }
        public void clearScreen() {
            quantity.Text = "";
            total.Text = "";
            number.Text = "";
        }
        public void Number_Clicked(object sender, EventArgs e) {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            quantity.Text += ((Button)sender).Text;
            //total.Text = Convert.ToString(product.price * Convert.ToDouble(quantity.Text));
        }
        public void Clear_Clicked(object sender, EventArgs e)
        {
            clearScreen();
        }
        private void mylist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Product product)
            {
                number.Text = product.name;
                if (quantity.Text == "")
                {
                    quantity.Text = "0";
                    total.Text = Convert.ToString(product.price * Convert.ToDouble(quantity.Text));
                }
                else {
                    total.Text = Convert.ToString(product.price * Convert.ToDouble(quantity.Text));
                }
            }
        }
        void Button_Clicked(System.Object sender, System.EventArgs e) {
            int newQuantity = (mylist.SelectedItem as Product).quantity - Convert.ToInt32(quantity.Text);
            if ((mylist.SelectedItem as Product).quantity == 0 || newQuantity < 0)
            {
                DisplayAlert("Out of Stock", "More on the way", "OK");
                clearScreen();
            }
            else
            {
                if (manager.history == null) {
                    manager.history = new ObservableCollection<History>();
                }
                (mylist.SelectedItem as Product).quantity = newQuantity;
                History temp = new History((mylist.SelectedItem as Product).name, newQuantity, total.Text);
                manager.history.Add(temp);
                clearScreen();
            }
        }
        async void Manager_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ManagerPage(manager));
        }

    }
}
