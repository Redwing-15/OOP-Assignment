using System.Diagnostics;

namespace OOP_Assignment
{
    internal class Item
    {
        private string name;
        private double price;
        private int stock;
        private int stockOrderLevel;
        private Supplier supplier;
        public Item(string name, double price, int stock, int stockorderlevel, Supplier supplier)
        {
            this.name = name;
            this.price = price;
            stock = Stock;
            stockOrderLevel = stockorderlevel;
            this.supplier = supplier;
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
        public Supplier Supplier
        {
            get { return supplier;}
            set { supplier = value; }
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