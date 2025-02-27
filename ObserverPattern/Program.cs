

using ObserverPattern;

class Program
{
    static void Main(string[] args)
    {
        Stock st1 = new Stock("Epam", 350);

        Stock st2 = new Stock("Milton", 250);
        Investor Alice = new Investor("Alice");
        Investor Bob = new Investor("Bob");
        st1.PriceChanged += Alice.PriceChangedUpdate;
        st1.PriceChanged += Bob.PriceChangedUpdate;
        st2.PriceChanged += Bob.PriceChangedUpdate;

        st1.Price = 500;
        st2.Price = 300;
        st1.PriceChanged -= Bob.PriceChangedUpdate;
        st1.Price = 550;

    }
}