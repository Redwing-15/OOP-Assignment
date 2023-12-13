using System.Diagnostics;

namespace OOP_Assignment
{
    public partial class Form1 : Form
    {
        List<Item> items = new List<Item> { new Item("Bag", 12, 5, 10) };
        List<Customer> customers = new List<Customer> { new Customer("Dave", "Dave@Dave.com") };

        public Form1()
        {
            InitializeComponent();

            itemsCombobox.Items.Add(items[0].Name);
            customerCombobox.Items.Add(customers[0].Name);
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
        }

        private void stockTextbox_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Textbox changed");
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
    }
}
