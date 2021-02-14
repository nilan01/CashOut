using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CashOut.Models;
using Xamarin.Forms;

namespace CashOut
{
    public partial class ManagerPage : ContentPage
    {
        public Manager managerClass { get; set; }
        public ManagerPage(Manager manager) {
            InitializeComponent();
            managerClass = manager;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var HistoryPage = new HistoryPage(managerClass);
            await Navigation.PushAsync(HistoryPage);

        }
        async void GoToRestockPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Restock(managerClass));
        }

    }
}
