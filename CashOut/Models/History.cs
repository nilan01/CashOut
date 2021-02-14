using System;
using System.ComponentModel;

namespace CashOut
{
    public class History
    {
        public string name { get; set; }

        public int quantity { get; set; }

        public string price { get; set; }

        public string purchaseDate { get; set; }

        public History() 
        {
        }
        public History(string name, int quantity, string price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.purchaseDate = DateTime.Now.ToString();
        }
    }
}
