using System.Diagnostics;

namespace OOP_Assignment
{
    public partial class Form1 : Form
    {
        List<Supplier> suppliers = new List<Supplier>();
        List<Customer> customers = new List<Customer>();
        List<Item> items = new List<Item>();
        public Form1()
        {
            InitializeComponent();

            Populate();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                itemsCombobox.Items.Clear();
                foreach (Item entry in items)
                {
                    itemsCombobox.Items.Add(entry.Name);
                }

                UpdateTransactions();
            }
        }

        private void itemsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTransactions();
        }
        private void customerCombobox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateTransactions();
        }

        //private void stockTextbox_TextChanged(object sender, EventArgs e)
        //{
        //    Item item = items[itemsCombobox.SelectedIndex];

        //    purchaseAmountEntry.Maximum = item.Stock;

        //    if (item.Stock < item.StockOrderLevel)
        //    {
        //        restockCheckbox.Checked = true;
        //    }
        //    else
        //    {
        //        restockCheckbox.Checked = false;
        //    }
        //}

        private void purchaseAmountEntry_ValueChanged(object sender, EventArgs e)
        {
            UpdateTransactions();
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

            UpdateTransactions();
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

        private void UpdateTransactions()
        {
            if (itemsCombobox.SelectedIndex != -1)
            {
                Item item = items[itemsCombobox.SelectedIndex];
                itemInfoTextbox.Text = item.ToString();
                purchaseAmountEntry.Maximum = item.Stock;
                purchaseTotal.Text = (item.Price * Convert.ToDouble(purchaseAmountEntry.Value)).ToString("£0.00");
            }

            if (customerCombobox.SelectedIndex != -1)
            {
                purchasesTextbox.Text = "";
                Customer customer = customers[customerCombobox.SelectedIndex];
                foreach (Purchase purchase in customer.Purchases)
                {
                    purchasesTextbox.Text += ($"{purchase.Item} X{purchase.Quantity}:  £{(purchase.Price * purchase.Quantity).ToString("0.00")}\r\n");
                }
            }
        }

        // Creates all pre-existing instances of items, customers etc.
        private void Populate()
        {
            customers.Add(new Customer("Dave", "Dave@Dave.com"));
            suppliers.Add(new Supplier("Jim's items"));

            suppliers[0].add_product(new Clothing(10, "Red", "Top", "Red top", 11, 15, 10, suppliers[0].Name));

            foreach (Supplier supplier in suppliers) items.AddRange(supplier.Products);
            foreach (Item item in items) itemsCombobox.Items.Add(item.Name);

            customerCombobox.Items.Add(customers[0].Name);
        }
    }
}
