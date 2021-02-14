using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CashOut
{
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage(Models.Manager manager)
        {
            InitializeComponent();
            mylist.ItemsSource = manager.history;

        }
        async void HistoryDetails(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new HistoryDetails(e.SelectedItem as History));

        }
    }
}
