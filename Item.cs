namespace OOP_Assignment
{
    abstract class Item
    {
        private string name;
        private double price;
        private int stock = 0;
        private int stockOrderLevel;
        private string supplier;

        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
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

        public void become_inventory(int stockOrderLevel, string supplier)
        {
            this.stock = 20;
            this.stockOrderLevel = stockOrderLevel;
            this.supplier = supplier;
        }
    }
}