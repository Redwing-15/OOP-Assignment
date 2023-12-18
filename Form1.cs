// NEED TO MAKE SYSTEM CLASS AND REWORK BOTH UPDATE PAGE FUNCTIONS OUT OF THE SYSTEM
using System.Diagnostics;
using System.Xml.Linq;

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
                UpdateTransactions(true);
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                UpdateRestock(true);
            }
        }

        private void T_itemsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTransactions(false);
        }

        private void T_customerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            T_addFundsEntry.Value = 0;
            UpdateTransactions(false);
        }

        private void T_addFundsButton_Click(object sender, EventArgs e)
        {
            Customer customer = customers[T_customerCombobox.SelectedIndex];
            customer.Balance += (double)T_addFundsEntry.Value;

            T_addFundsEntry.Value = 0;
            UpdateTransactions(false);
        }

        private void T_purchaseAmountEntry_ValueChanged(object sender, EventArgs e)
        {
            if (T_itemsCombobox.SelectedIndex == 0)
            {
                T_purchaseTotal.Text = "";
                return;
            }
            Item item = items[T_itemsCombobox.SelectedIndex];
            T_purchaseTotal.Text = (item.Price * Convert.ToDouble(T_purchaseAmountEntry.Value)).ToString("£0.00");
        }

        private void T_purchaseButton_Click(object sender, EventArgs e)
        {
            Customer customer = customers[T_customerCombobox.SelectedIndex];
            Item item = items[T_itemsCombobox.SelectedIndex];

            if (item.Stock < 1)
            {
                Debug.WriteLine("Not enough stock");
                return;
            }
            Debug.WriteLine($"Bal: {customer.Balance} Price: {item.Price * (double)T_purchaseAmountEntry.Value}");
            if (customer.Balance < item.Price*(double)T_purchaseAmountEntry.Value)
            {
                Debug.WriteLine("Not enough funds");
                return;
            }

            Purchase purchase = new Purchase(item.Name, DateTime.Now.ToString(), item.Price, (int)T_purchaseAmountEntry.Value);
            customer.add_purchase(purchase);
            item.Stock -= purchase.Quantity;

            T_purchaseAmountEntry.Value = 1;
            UpdateTransactions(false);
        }

        private void R_supplierSelectCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRestock(false);
        }
        private void R_itemCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRestock(false);
        }
        private void R_stockTextbox_TextChanged(object sender, EventArgs e)
        {
            if (R_itemCombobox.SelectedIndex == -1) return;
            Item item = items[R_itemCombobox.SelectedIndex];
            R_restockAmountEntry.Value = 0;
            if (item.Stock < item.StockOrderLevel)
            {
                R_restockCheckbox.Checked = true;
            }
            else
            {
                R_restockCheckbox.Checked = false;
            }
            UpdateRestock(false);
        }

        private void R_restockButton_Click(object sender, EventArgs e)
        {
            Item item = items[R_itemCombobox.SelectedIndex];
            item.Stock += Convert.ToInt32(R_restockAmountEntry.Text);

            UpdateRestock(false);
        }

        private void UpdateTransactions(bool refresh)
        {
            if (refresh)
            {
                T_customerCombobox.SelectedIndex = -1;
                T_itemsCombobox.SelectedIndex = -1;
            }

            if (T_itemsCombobox.SelectedIndex == -1)
            {
                T_itemsCombobox.Items.Clear();
                foreach (Item entry in items)
                {
                    T_itemsCombobox.Items.Add(entry.Name);
                }

                T_itemInfoTextbox.Text = "";
                T_purchaseAmountEntry.Minimum = 0;
                T_purchaseAmountEntry.Value = 0;
                T_purchaseTotal.Text = "";
            }
            else
            {
                Item item = items[T_itemsCombobox.SelectedIndex];
                T_itemInfoTextbox.Text = item.ToString();
                T_purchaseAmountEntry.Maximum = item.Stock;
                if (item.Stock == 0) T_purchaseAmountEntry.Minimum = 0;
                else T_purchaseAmountEntry.Minimum = 1;
            }

            T_purchasesTextbox.Text = "";
            if (T_customerCombobox.SelectedIndex == -1)
            {
                T_customerCombobox.Items.Clear();
                foreach (Customer customer in customers)
                {
                    T_customerCombobox.Items.Add(customer.Name);
                }
                T_balanceTextbox.Text = "";
                T_addFundsEntry.Value = 0;
            }
            else
            {
                Customer customer = customers[T_customerCombobox.SelectedIndex];
                T_balanceTextbox.Text = $"£{customer.Balance.ToString("0.00")}";

                foreach (Purchase purchase in customer.Purchases)
                {
                    T_purchasesTextbox.Text += ($"{purchase.Item} X{purchase.Quantity}:  £{(purchase.Price * purchase.Quantity).ToString("0.00")}\r\n");
                }
            }
        }

        private void UpdateRestock(bool refresh)
        {
            if (refresh)
            {
                R_supplierSelectCombobox.SelectedIndex = -1;
                R_itemCombobox.SelectedIndex = -1;

            }

            bool supplierSelected = true;
            if (R_supplierSelectCombobox.SelectedIndex < 1)
            {
                supplierSelected = false;
                if (R_supplierSelectCombobox.SelectedIndex == -1)
                {
                    R_supplierSelectCombobox.Items.Clear();
                    R_supplierSelectCombobox.Items.Add("<None>");
                    foreach (Supplier supplier in suppliers)
                    {
                        R_supplierSelectCombobox.Items.Add(supplier.Name);
                    }
                }

            }
            R_restockableItemsListbox.Items.Clear();
            foreach (Item item in items)
            {
                if (supplierSelected == true & item.Supplier != R_supplierSelectCombobox.Text) continue;
                if (item.Stock >= item.StockOrderLevel) continue;
                R_restockableItemsListbox.Items.Add($"{item.Name}  {item.Stock}/{item.StockOrderLevel}");
            }

            if (R_itemCombobox.SelectedIndex == -1)
            {
                R_itemCombobox.Items.Clear();
                foreach (Item item in items)
                {
                    R_itemCombobox.Items.Add(item.Name);
                }
                R_supplierTextbbox.Text = "";
                R_stockTextbox.Text = "";
            }
            else
            {
                Item item = items[R_itemCombobox.SelectedIndex];
                R_supplierTextbbox.Text = item.Supplier;
                R_stockTextbox.Text = item.Stock.ToString();
            }
        }

        // Creates all pre-existing instances of items, customers etc.
        private void Populate()
        {
            customers.Add(new Customer("Reece", "rf287@canterbury.ac.uk", 50));
            customers.Add(new Customer("Tina", "tina.eager@canterbury.ac.uk", 1500));

            suppliers.Add(new Supplier("Jim's items"));
            suppliers.Add(new Supplier("MIKE"));

            suppliers[0].add_product(new Clothing(10, "Red", "Top", "Red top", 15, 15, 10, "Jim's items"));
            suppliers[0].add_product(new Shoe(9, "Racer", "MIKE Racers", 65, 10, 20, "MIKE"));

            foreach (Supplier supplier in suppliers) items.AddRange(supplier.Products);

            UpdateTransactions(false);
        }
    }
}
