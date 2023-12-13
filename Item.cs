using System.Diagnostics;

namespace OOP_Assignment
{
    internal class Item
    {
        private string name;
        private double price;
        private int stock;
        private int stockOrderLevel;
        public Item(string Name, double Price, int Stock, int StockOrderLevel)
        {
            name = Name;
            price = Price;
            stock = Stock;
            stockOrderLevel = StockOrderLevel;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int StockOrderLevel
        {
            get { return stockOrderLevel; }
            set { stockOrderLevel = value; }
        }

        public void restock(int amount)
        {
            stock += amount;
            return;
        }

        public void sell(Customer customer, int amount)
        {
            Purchase purchase = new Purchase(name, DateTime.Now.ToString(), price, amount);
            customer.add_purchase(purchase);

            stock -= amount;
        }
    }
}