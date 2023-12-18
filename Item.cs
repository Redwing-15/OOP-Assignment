namespace OOP_Assignment
{
    abstract class Item
    {
        private string name;
        private double price;
        private int stock;
        private int stockOrderLevel;
        private string supplier;
        public Item(string name, double price, int stock, int stockorderlevel, string supplier)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.stockOrderLevel = stockorderlevel;
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
        public string Supplier
        {
            get { return supplier;}
            set { supplier = value; }
        }
    }
}