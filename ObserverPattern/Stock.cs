using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObserverPattern
{
    public delegate void PriceChangedHandler(string name,decimal price);
    public class Stock
    {
        public string name;
        private decimal price;
        public event PriceChangedHandler PriceChanged;
        public Stock(string name, decimal initialprice)
        {
            this.name = name;
            this.price = initialprice;
        }
       
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPriceChanged();
                }
            }
        }
        public void OnPriceChanged()
        {
            PriceChanged?.Invoke(name, price);
        }
    }
}
