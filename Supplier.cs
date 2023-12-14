// NEED TO REWORK ITEM SYSTEM SO THAT SUPPLIERS CREATE NEW ITEMS
using System.Diagnostics;

namespace OOP_Assignment
{
    internal class Supplier
    {
        private string name;
        private List<string> orderList = new List<string>();
        public Supplier(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> get_order_list()
        {
            return orderList;
        }
    }
}