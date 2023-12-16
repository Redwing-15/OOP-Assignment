using System.Diagnostics;

namespace OOP_Assignment
{
    internal class Supplier
    {
        private string name;
        private List<Item> products = new List<Item>();
        public Supplier(string name)
        {
            this.name = name;
            products.Add(new Item("Watch", 11, 15, 10, this.name));
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Item> Products
        {
            get { return products; }
        }

        public void add_product(Item product)
        {
            products.Add(product);
        }

        public List<Item> get_order_list()
        {
            List<Item> orderList = new List<Item>();
            foreach (Item item in products)
            {
                if (item.Stock < item.StockOrderLevel) orderList.Add(item);
            }
            return orderList;
        }
    }
}