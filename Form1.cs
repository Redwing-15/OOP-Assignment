using System.Diagnostics;
namespace OOP_Assignment
{
    public partial class Form1 : Form
    {
        StockSystem system = new StockSystem();

        public Form1()
        {
            InitializeComponent();

            T_customerCombobox.Items.Clear();
            foreach (Customer customer in system.Customers)
            {
                T_customerCombobox.Items.Add(customer.Name);
            }

            T_itemCombobox.Items.Clear();
            foreach (Item item in system.Items)
            {
                T_itemCombobox.Items.Add(item.Name);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                T_customerCombobox.SelectedIndex = -1;
                T_customerCombobox.Items.Clear();
                foreach (Customer customer in system.Customers)
                {
                    T_customerCombobox.Items.Add(customer.Name);
                }


                T_itemCombobox.SelectedIndex = -1;
                T_itemCombobox.Items.Clear();
                foreach (Item item in system.Items)
                {
                    T_itemCombobox.Items.Add(item.Name);
                }

                T_purchaseAmountEntry.Minimum = 0;
                T_purchaseAmountEntry.Maximum = 0;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                R_supplierSelectCombobox.SelectedIndex = -1;
                R_supplierSelectCombobox.Items.Clear();
                R_supplierSelectCombobox.Items.Add("<None>");
                foreach (Supplier supplier in (List<Supplier>)system.Suppliers)
                {
                    R_supplierSelectCombobox.Items.Add(supplier.Name);
                }

                R_itemCombobox.SelectedIndex = -1;
                R_itemCombobox.Items.Clear();
                foreach (Item item in system.Items)
                {
                    R_itemCombobox.Items.Add(item.Name);
                }

                R_restockableItemsListbox.Items.Clear();
                foreach (Item item in system.Items)
                {
                    if (item.Stock >= item.StockOrderLevel) continue;
                    R_restockableItemsListbox.Items.Add($"\"{item.Name}\"  {item.Stock}/{item.StockOrderLevel}");
                }
            }
        }

        // Transactions Page
        private void T_customerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T_customerCombobox.SelectedIndex == -1)
            {
                T_balanceTextbox.Text = "";
                T_addFundsEntry.Maximum = 0;
                T_addFundsEntry.Value = 0;
                T_purchasesTextbox.Text = "";
                return;
            }

            Customer customer = system.get_customer(T_customerCombobox.SelectedIndex);

            T_balanceTextbox.Text = $"£{customer.Balance.ToString("0.00")}";
            T_purchasesTextbox.Text = "";
            foreach (Purchase purchase in customer.Purchases)
            {
                T_purchasesTextbox.Text += $"{purchase.ToString()}\r\n";
            }
            T_addFundsEntry.Maximum = 1000;
            T_addFundsEntry.Value = 0;
        }

        private void T_addFundsButton_Click(object sender, EventArgs e)
        {
            if (T_customerCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("No customer selected");
                return;
            }

            system.add_customer_funds(T_customerCombobox.SelectedIndex, (double)T_addFundsEntry.Value);

            T_balanceTextbox.Text = $"£{system.get_customer(T_customerCombobox.SelectedIndex).Balance.ToString("0.00")}";
            T_addFundsEntry.Value = 0;
        }

        private void T_itemsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (T_itemCombobox.SelectedIndex == -1)
            {
                T_itemInfoTextbox.Text = "";
                T_purchaseAmountEntry.Minimum = 0;
                T_purchaseAmountEntry.Maximum = 0;
                T_purchaseAmountEntry.Value = 0;
                return;
            }

            Item item = system.get_item(T_itemCombobox.SelectedIndex);
            T_itemInfoTextbox.Text = item.ToString();
            T_purchaseAmountEntry.Minimum = 1;
            T_purchaseAmountEntry.Maximum = item.Stock;
            T_purchaseAmountEntry.Value = 1;
            T_purchaseTotal.Text = (item.Price * Convert.ToDouble(T_purchaseAmountEntry.Value)).ToString("£0.00");
        }

        private void T_purchaseAmountEntry_ValueChanged(object sender, EventArgs e)
        {
            if (T_itemCombobox.SelectedIndex == -1)
            {
                T_purchaseTotal.Text = "";
                return;
            }

            Item item = system.get_item(T_itemCombobox.SelectedIndex);
            T_purchaseTotal.Text = (item.Price * Convert.ToDouble(T_purchaseAmountEntry.Value)).ToString("£0.00");
        }

        private void T_purchaseButton_Click(object sender, EventArgs e)
        {
            if (T_customerCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Must select a customer to make the purchase");
                return;
            }
            else if (T_itemCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Must select an item to purchase");
                return;
            }
            string purchaseResult = system.handle_purchase(T_customerCombobox.SelectedIndex, T_itemCombobox.SelectedIndex,
                (int)T_purchaseAmountEntry.Value);
            if (purchaseResult != "Success")
            {
                MessageBox.Show(purchaseResult);
                return;
            }
            T_balanceTextbox.Text = $"£{system.get_customer(T_customerCombobox.SelectedIndex).Balance.ToString("0.00")}";
            T_purchaseAmountEntry.Value = 1;
            T_itemInfoTextbox.Text = system.get_item(T_itemCombobox.SelectedIndex).ToString();

            T_purchasesTextbox.Text = "";
            foreach (Purchase purchase in system.get_customer(T_customerCombobox.SelectedIndex).Purchases)
            {
                T_purchasesTextbox.Text += $"{purchase.ToString()}\r\n";
            }
        }

        // Restock Page
        private void R_supplierSelectCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            R_restockableItemsListbox.Items.Clear();
            foreach (Item item in system.Items)
            {
                if (R_supplierSelectCombobox.SelectedIndex != 0 & item.Supplier != R_supplierSelectCombobox.Text) continue;
                if (item.Stock >= item.StockOrderLevel) continue;
                R_restockableItemsListbox.Items.Add($"\"{item.Name}\"  {item.Stock}/{item.StockOrderLevel}");
            }
        }
        private void R_restockableItemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gets the Item name from the string in the form: "NAME" 0/1
            string item = ((string)R_restockableItemsListbox.SelectedItem).Split('"')[1];
            Debug.WriteLine($"{item}");
            R_itemCombobox.SelectedIndex = R_itemCombobox.Items.IndexOf(item);
        }

        private void R_itemCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (R_itemCombobox.SelectedIndex == -1)
            {
                R_supplierTextbbox.Text = "";
                R_stockTextbox.Text = "";
                R_restockAmountEntry.Maximum = 0;
                R_restockCheckbox.Checked = false;
                return;
            }

            Item item = system.get_item(R_itemCombobox.SelectedIndex);
            R_supplierTextbbox.Text = item.Supplier;
            R_stockTextbox.Text = item.Stock.ToString();
        }

        private void R_stockTextbox_TextChanged(object sender, EventArgs e)
        {
            if (R_itemCombobox.SelectedIndex == -1) return;
            Item item = system.Items[R_itemCombobox.SelectedIndex];
            R_restockAmountEntry.Maximum = 100;
            R_restockAmountEntry.Value = 0;

            if (item.Stock < item.StockOrderLevel)
            {
                R_restockCheckbox.Checked = true;
            }
            else
            {
                R_restockCheckbox.Checked = false;
            }
        }

        private void R_restockButton_Click(object sender, EventArgs e)
        {
            if (R_itemCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("No item selected");
                return;
            }
            else if (R_restockAmountEntry.Value == 0)
            {
                MessageBox.Show("Restock amount not selected");
                return;
            }
            system.restock_item(R_itemCombobox.SelectedIndex, Convert.ToInt32(R_restockAmountEntry.Text));

            Item item = system.get_item(R_itemCombobox.SelectedIndex);
            R_stockTextbox.Text = item.Stock.ToString();

            R_restockableItemsListbox.Items.Clear();
            foreach (Item entry in system.Items)
            {
                if (R_supplierSelectCombobox.SelectedIndex < 1)
                {
                    if (entry.Stock >= entry.StockOrderLevel) continue;
                    R_restockableItemsListbox.Items.Add($"\"{entry.Name}\"  {entry.Stock}/{entry.StockOrderLevel}");
                }
                else
                {
                    if (entry.Supplier != R_supplierSelectCombobox.Text) continue;
                    if (entry.Stock >= entry.StockOrderLevel) continue;
                    R_restockableItemsListbox.Items.Add($"\"{entry.Name}\"  {entry.Stock}/{entry.StockOrderLevel}");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            system.add_item("Bag", "MIKE Heritage", 30, 20, 15, "MIKE", new Dictionary<string, string> { { "Capacity", "25" } });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            system.add_customer("Brain", "brain@brian.com", 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            system.add_supplier("ADIBAS");
        }
    }
}
