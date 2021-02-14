using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CashOut
{
    public partial class HistoryDetails : ContentPage
    {
        public HistoryDetails(History history)
        {
            InitializeComponent();
            Title = history.name;
            name.Text = history.name;
            quantity.Text = history.quantity.ToString();
            purchaseDate.Text = history.purchaseDate.ToString();
            totalPrice.Text = string.Format("Total amount: {0:F2}", history.price);
        }
    }
}
