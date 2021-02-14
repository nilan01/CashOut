using System;
using System.Collections.ObjectModel;

namespace CashOut.Models
{
    public class Manager
    {
       public ObservableCollection<Product> products { get; set; }

       public ObservableCollection<History> history { get; set; }


        public Manager()
        {

            Product hats = new Product("Hat", 30, 25.99);
            Product pants = new Product("Jeans", 30, 35.99);
            Product jackets = new Product("Jackets", 40, 255.99);
            Product shoes = new Product("Shoes", 20, 115.99);
            Product shirts = new Product("Shirts", 30, 35.99);
            Product socks = new Product("Socks", 30, 15.99);

            products = new ObservableCollection<Product>();
            history = new ObservableCollection<History>();

            products.Add(hats);
            products.Add(pants);
            products.Add(jackets);
            products.Add(shoes);
            products.Add(shirts);
            products.Add(socks);


        }
    }
}
