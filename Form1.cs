using System.Diagnostics;

namespace OOP_Assignment
{
    public partial class Form1 : Form
    {
        List<Supplier> suppliers = new List<Supplier> { new Supplier("Jim's items") };
        List<Customer> customers = new List<Customer> { new Customer("Dave", "Dave@Dave.com") };
        List<Item> items = new List<Item>();
        public Form1()
        {
            InitializeComponent();

            items.Add(new Clothing(10, "Red", "Top", "Pink top", 11, 15, 10, suppliers[0].Name));
            suppliers[0].add_product(items[0]);
            foreach (Item item in items) itemsCombobox.Items.Add(item.Name);
            customerCombobox.Items.Add(customers[0].Name);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                itemsCombobox.Items.Clear();
                foreach (Item item in items)
                {
                    itemsCombobox.Items.Add(item.Name);
                }
            }
        }

        private void itemsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = items[itemsCombobox.SelectedIndex];
            stockTextbox.Text = item.Stock.ToString();
            supplierTextbox.Text = item.Supplier;
        }

        private void stockTextbox_TextChanged(object sender, EventArgs e)
        {
            Item item = items[itemsCombobox.SelectedIndex];

            purchaseAmountEntry.Maximum = item.Stock;

            if (item.Stock < item.StockOrderLevel)
            {
                restockCheckbox.Checked = true;
            }
            else
            {
                restockCheckbox.Checked = false;
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            Customer customer = customers[customerCombobox.SelectedIndex];
            Item item = items[itemsCombobox.SelectedIndex];

            if (item.Stock < 1)
            {
                Debug.WriteLine("Not enough stock");
                return;
            }

            item.sell(customer, Convert.ToInt32(purchaseAmountEntry.Text));
            stockTextbox.Text = item.Stock.ToString();
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            Item item = items[itemsCombobox.SelectedIndex];
            // No need to limit restocks as of yet but code here incase
            //if (item.Stock >= item.StockOrderLevel)
            //{
            //    Debug.WriteLine("Stock not at minimum level to require restock");
            //    return;
            //}

            item.restock(Convert.ToInt32(restockAmountEntry.Text));

            stockTextbox.Text = item.Stock.ToString();
        }
    }
}
