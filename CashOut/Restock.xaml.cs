using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace CashOut
{
    public partial class Restock : ContentPage
    {
        public Restock(Models.Manager manager)
        {
            InitializeComponent();
            mylist.ItemsSource = manager.products;
        }
        void restockClicked(object sender, EventArgs e)
        {
            if (!(mylist.SelectedItem as Product == null ||
                string.IsNullOrEmpty(enteredQuantity.Text) ||
                enteredQuantity.Text.Contains('.')))
            {
                int newQuantity = Convert.ToInt32(enteredQuantity.Text) + (mylist.SelectedItem as Product).quantity;
                (mylist.SelectedItem as Product).quantity = newQuantity;
            }
            else
            {
                DisplayAlert("Error", "N", "OK");
            }
        }

        async void cancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
