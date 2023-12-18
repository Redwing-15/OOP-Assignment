namespace OOP_Assignment
{
    internal class Purchase
    {
        private string item;
        private string date; // Needs to be DateTime, will implement when possible
        private double price;
        private int quantity;

        public Purchase(string item, string date, double price, int quantity)
        {
            this.item = item;
            this.date = date;
            this.price = price;
            this.quantity = quantity;
        }

        public string Item
        {
            get { return item; }
        }
        public string Date
        {
            get { return date; }
        }
        public double Price
        {
            get { return 
                    price; }
        }
        public int Quantity
        {
            get { return quantity; }
        }

        public override string ToString()
        {
            return $"{date}:  {quantity}x\"{item}\" - £{(price * quantity).ToString("0.00")}";
        }
    }
}