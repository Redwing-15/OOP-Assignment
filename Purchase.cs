namespace OOP_Assignment
{
    internal class Purchase
    {
        private static int count = 1;
        private string item;
        private DateTime date;
        private double price;
        private int quantity;
        private int orderNumber;

        public Purchase(string item, DateTime date, double price, int quantity)
        {
            this.item = item;
            this.date = date;
            this.price = price;
            this.quantity = quantity;
            orderNumber = count;
            count++;
        }

        public string Item
        {
            get { return item; }
        }
        public DateTime Date
        {
            get { return date; }
        }
        public double Price
        {
            get { return price; }
        }
        public int Quantity
        {
            get { return quantity; }
        }

        public override string ToString()
        {
            return $"Order #{orderNumber}: {date} - {quantity}x\"{item}\" - £{(price * quantity).ToString("0.00")}";
        }
    }
}