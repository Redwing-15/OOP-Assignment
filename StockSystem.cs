// TODO:
// ADD ABILITY TO CREATE NEW SUPPLIERS
// ADD ABILITY TO CREATE NEW CUSTOMERS
// ADD UI TO CREATE NEW ITEMS
// ADD ENUMS TO ITEMS
// REWORK PURCAHSE DATE TO USE DATETIME INSTEAD OF STRING
// REWORK PURCHASES TO BE TRACKED BY STOCKSYSTEM AND AGGREGATE INTO CUSTOMER
// REWORK ITEMS TO USE AN INTERFACE3

using System.Diagnostics;

namespace OOP_Assignment
{
    internal sealed class StockSystem
    {
        List<Supplier> suppliers = new List<Supplier>();
        List<Customer> customers = new List<Customer>();
        List<Item> items = new List<Item>();

        public StockSystem()
        {
            customers.Add(new Customer("Reece", "rf287@canterbury.ac.uk", 50));
            customers.Add(new Customer("Tina", "tina.eager@canterbury.ac.uk", 1500));

            suppliers.Add(new Supplier("Jim's items"));
            suppliers.Add(new Supplier("MIKE"));

            suppliers[0].add_product(new Clothing(10, "Red", "Top", "Red top", 15, 15, 10, "Jim's items"));
            suppliers[0].add_product(new Shoe(9, "Racer", "MIKE Racers", 65, 10, 20, "MIKE"));

            foreach (Supplier supplier in suppliers) items.AddRange(supplier.Products);
        }

        public List<Supplier> Suppliers
        {
            get { return suppliers; }
        }
        public List<Customer> Customers
        {
            get { return customers; }
        }
        public List<Item> Items
        {
            get { return items; }
        }

        public Supplier add_supplier(string name)
        {
            Supplier supplier = new Supplier(name);
            suppliers.Add(supplier);

            return supplier;
        }
        
        public Customer add_customer(string name, string email, int balance)
        {
            Customer customer = new Customer(name, email, balance);
            customers.Add(customer);

            return customer;
        }

        public Item add_item(string type, string name, double price, int stock, int stockOrderLevel, string supplierName, Dictionary<string, string> misc)
        {
            Item item;
            if (type == "Clothing")
            {
                item = new Clothing(Convert.ToInt32(misc["Size"]), misc["Colour"], misc["Style"], name, price, stock, stockOrderLevel, supplierName);
            }
            else if (type == "Shoe")
            {
                item = new Shoe(Convert.ToInt32(misc["Size"]), misc["Type"], name, price, stock, stockOrderLevel, supplierName);
            }
            else if (type == "Bag")
            {
                item = new Bag(misc["Capacity"], "Bag", name, price, stock, stockOrderLevel, supplierName);
            }
            else if (type == "Nutrition")
            {
                item = new Nutrition(misc["Quantity"], misc["NutritionType"], "Nutrition", name, price, stock, stockOrderLevel, supplierName);
            }
            else if (type == "Watch")
            {
                item = new Watch(misc["watchType"], "Watch", name, price, stock, stockOrderLevel, supplierName);
            }
            else
            {
                return null;
            }

            foreach (Supplier supplier in suppliers)
            {
                if (supplier.Name == supplierName)
                {
                    supplier.add_product(item);
                    break;
                }
            }
            items.Add(item);

            return item;
        }

        public Customer get_customer(int customerIndex)
        {
            return customers[customerIndex];
        }

        public Item get_item(int itemIndex)
        {
            return items[itemIndex];
        }

        public Supplier get_supplier(int supplierIndex)
        {
            return suppliers[supplierIndex];
        }

        public void add_customer_funds(int customerIndex, double amount)
        {
            customers[customerIndex].Balance += amount;
        }

        public void restock_item(int itemIndex, int Quantity)
        {
            items[itemIndex].Stock += Quantity;
        }

        public string handle_purchase(int customerIndex, int itemIndex, int itemQuantity)
        {
            Customer customer = customers[customerIndex];
            Item item = items[itemIndex];

            if (customer.Balance < item.Price * itemQuantity)
            {
                return "Not enough funds";
            }
            if (item.Stock < 1)
            {
                return "Not enough stock";
            }

            customer.add_purchase(new Purchase(item.Name, DateTime.Now.ToString(), item.Price, itemQuantity));
            item.Stock -= itemQuantity;
            return "Success";
        }
    }
}