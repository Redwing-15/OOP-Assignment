namespace OOP_Assignment
{
    internal class Purchase
    {
        private string itemName;
        private string saleDate; // Needs to be DateTime, will implement when possible
        private double salePrice;
        private int saleQuantity;

        public Purchase(string item, string date, double price, int amount)
        {
            itemName = item;
            saleDate = date;
            salePrice = price;
            saleQuantity = amount;
        }

        public string Item
        {
            get { return itemName; }
        }
        public string Date
        {
            get { return saleDate; }
        }
        public double Price
        {
            get { return salePrice; }
        }
        public int Quantity
        {
            get { return saleQuantity; }
        }
    }
}