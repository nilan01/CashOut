using System;
using System.ComponentModel;

namespace CashOut
{
    public class Product : INotifyPropertyChanged
    {
        public string name { get; set; }

        private int _quantity { get; set; }

        public double price { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public int quantity {
            get { return _quantity; }

            set {
                if (_quantity != value) {
                    _quantity = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs(nameof(quantity)));
                    }
                }
            }
        }


        public Product()
        {
        }
        public Product(string name, int quantity, double price) {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }
    }
}
