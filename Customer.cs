namespace OOP_Assignment
{
    internal class Customer
    {
        private string name;
        private string email;
        private double balance;
        private List<Purchase> purchases = new List<Purchase>();

        public Customer(string name, string email, int balance)
        {
            this.name = name;
            this.email = email;
            this.balance = balance;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public List<Purchase> Purchases
        {
            get { return purchases; }
        }

        public void add_purchase(Purchase purchase)
        {
            purchases.Add(purchase);
            balance -= purchase.Price * purchase.Quantity;
        }
    }
}