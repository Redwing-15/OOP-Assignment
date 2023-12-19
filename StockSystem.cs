// BIG TODO:
// UNIT TEST??
//
// OPTIONAL FUNCTIONALITY:
// ADD ENUMS FOR ITEM TYPES (Clothing, Shoe, Bag, Nutrition, Watch)
// ENHANCE CREATE ERROR HANDLING BY HANDLING CORRECT DATATYPES
// ADD QUICK RESTOCK ALL BUTTON

namespace OOP_Assignment
{
    internal sealed class StockSystem
    {
        List<Supplier> suppliers = new List<Supplier>();
        List<Customer> customers = new List<Customer>();
        List<Purchase> purchases = new List<Purchase>();
        List<Item> items = new List<Item>();

        // Populates system with customers, suppliers and items
        public StockSystem()
        {
            customers.Add(new Customer("Reece", "rf287@canterbury.ac.uk", 50));
            customers.Add(new Customer("Tina", "tina.eager@canterbury.ac.uk", 1500));

            suppliers.Add(new Supplier("MIKE"));
            suppliers.Add(new Supplier("Super Nutrition"));
            suppliers.Add(new Supplier("Pear"));


            add_item("Clothing", "Tracksuit Top", 80, 15, "MIKE", new Dictionary<string, string> {
                {"Size",  "M"},
                {"Colour", "Black/White"},
                {"Style", "Top"}});
            add_item("Shoe", "Racer", 65, 20, "MIKE", new Dictionary<string, string> {
                {"Size",  "9"},
                {"Type", "Racer"}});
            add_item("Bag", "Heritage", 30, 15, "MIKE", new Dictionary<string, string> {
                {"Capacity",  "25"}});
            add_item("Nutrition", "Muscle Fuel", 15, 10, "Super Nutrition", new Dictionary<string, string> {
                {"Quantity",  "1000"},
                {"Type", "Proteins"}});
            add_item("Watch", "Pear Watch Series X", 500, 20, "Pear", new Dictionary<string, string> {
                {"Type",  "GPSandHeartRate"}});
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

        public Item add_item(string type, string name, double price, int stockOrderLevel, string supplierName, Dictionary<string, string> misc)
        {
            Item item;
            if (type == "Clothing")
            {
                item = new Clothing((ClothingSize)Enum.Parse(typeof(ClothingSize), misc["Size"]), misc["Colour"],
                    (ClothingStyle)Enum.Parse(typeof(ClothingStyle), misc["Style"]), name, price);
            }
            else if (type == "Shoe")
            {
                item = new Shoe(Convert.ToInt32(misc["Size"]), (ShoeType)Enum.Parse(typeof(ShoeType), misc["Type"]),
                    name, price);
            }
            else if (type == "Bag")
            {
                item = new Bag(Convert.ToInt32(misc["Capacity"]), "Bag", name, price);
            }
            else if (type == "Nutrition")
            {
                item = new Nutrition(misc["Quantity"], (NutrientType)Enum.Parse(typeof(NutrientType), misc["Type"]), "Nutrition",
                    name, price);
            }
            else if (type == "Watch")
            {
                item = new Watch((WatchType)Enum.Parse(typeof(WatchType), misc["Type"]), "Watch", name, price);
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
            item.become_inventory(stockOrderLevel, supplierName);
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
            Purchase purchase = new Purchase(item.Name, DateTime.Now, item.Price, itemQuantity);
            purchases.Add(purchase);
            customer.add_purchase(purchase);
            item.Stock -= itemQuantity;
            return "Success";
        }
    }
}