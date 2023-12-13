using System.Diagnostics;

namespace OOP_Assignment
{
    internal class Customer
    {
        private string name;
        private string email;
        private bool GDPR = true; // Unsure as to what this variable is used for??
        private List<Purchase> purchases = new List<Purchase>();
        public Customer(string Name, string Email)
        {
            name = Name;
            email = Email;
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
        public List<Purchase> Purchases
        {
            get { return purchases; }
        }

        public void add_purchase(Purchase purchase)
        {
            purchases.Add(purchase);
        }
    }
}