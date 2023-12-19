namespace OOP_Assignment
{
    internal class Supplier
    {
        private string name;
        private List<Item> products = new List<Item>();

        public Supplier(string name)
        {
            this.name = name;
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
    }
}