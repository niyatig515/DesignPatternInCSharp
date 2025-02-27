using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class Investor
    {
        public string InvestorName;
        public Investor(string name)
        {
           InvestorName = name;
        }
        public void PriceChangedUpdate(string name, decimal price)
        {
            Console.WriteLine($" Hello {InvestorName} {name} price is now updated to {price}");
        }

    }
}
