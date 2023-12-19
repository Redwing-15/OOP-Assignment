namespace OOP_Assignment
{
    public partial class Form1 : Form
    {
        StockSystem system = new StockSystem();

        public Form1()
        {
            InitializeComponent();

            // Cant find a method to initiate a tabIndex change so values for comboboxes need to be manually added.
            T_customerCombobox.Items.Clear();
            foreach (Customer customer in system.Customers)
            {
                T_customerCombobox.Items.Add(customer.Name);
            }

            T_itemCombobox.Items.Clear();
            foreach (Item item in system.Items)
            {
                T_itemCombobox.Items.Add($"{item.Supplier} {item.Name}");
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
                    T_itemCombobox.Items.Add($"{item.Supplier} {item.Name}");
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
            else if (tabControl1.SelectedIndex == 2)
            {
                C_itemCombobox.SelectedIndex = -1;
                C_createControl.TabPages.Clear();
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
            T_purchaseAmountEntry.Minimum = 0;
            T_purchaseAmountEntry.Maximum = item.Stock;
            T_purchaseAmountEntry.Value = 0;
            if (item.Stock > 0) T_purchaseAmountEntry.Value = 1;
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

        private void C_createControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (C_createControl.TabPages.Count == 0) return;
            switch (C_createControl.TabPages[0].Name)
            {
                case "customerPage":
                    C_customerEntry.Text = "";
                    C_emailEntry.Text = "";
                    C_balanceEntry.Text = "";
                    return;
                case "supplierPage":
                    C_supplierNameEntry.Text = "";
                    return;
                case "clothingPage":
                    C_clothingSupplierCombobox.SelectedIndex = -1;
                    C_clothingSupplierCombobox.Items.Clear();
                    foreach (Supplier supplier in system.Suppliers)
                    {
                        C_clothingSupplierCombobox.Items.Add(supplier.Name);
                    }
                    C_clothingNameEntry.Text = "";
                    C_clothingPriceEntry.Value = 0;
                    C_clothingRestockEntry.Value = 0;
                    C_clothingSizeCombobox.SelectedIndex = -1;
                    C_clothingColourEntry.Text = "";
                    C_clothingTypeCombobox.SelectedIndex = -1;
                    return;
                case "shoePage":
                    C_shoeSupplierCombobox.SelectedIndex = -1;
                    C_shoeSupplierCombobox.Items.Clear();
                    foreach (Supplier supplier in system.Suppliers)
                    {
                        C_shoeSupplierCombobox.Items.Add(supplier.Name);
                    }
                    C_shoeNameEntry.Text = "";
                    C_shoePriceEntry.Value = 0;
                    C_shoeRestockEntry.Value = 0;
                    C_shoeSizeCombobox.SelectedIndex = -1;
                    C_shoeTypeCombobox.SelectedIndex = -1;
                    return;
                case "bagPage":
                    C_bagSupplierCombobox.SelectedIndex = -1;
                    C_bagSupplierCombobox.Items.Clear();
                    foreach (Supplier supplier in system.Suppliers)
                    {
                        C_bagSupplierCombobox.Items.Add(supplier.Name);
                    }
                    C_bagNameEntry.Text = "";
                    C_bagPriceEntry.Value = 0;
                    C_bagRestockEntry.Value = 0;
                    C_capacityEntry.Value = 0;
                    return;
                case "nutritionPage":
                    C_nutrientSupplierCombobox.SelectedIndex = -1;
                    C_nutrientSupplierCombobox.Items.Clear();
                    foreach (Supplier supplier in system.Suppliers)
                    {
                        C_nutrientSupplierCombobox.Items.Add(supplier.Name);
                    }
                    C_nutrientNameEntry.Text = "";
                    C_nutrientPriceEntry.Value = 0;
                    C_nutrientRestockEntry.Value = 0;
                    C_quantityEntry.Text = "";
                    C_nutrientCombobox.SelectedIndex = -1;
                    return;
                case "watchPage":
                    C_watchSupplierCombobox.SelectedIndex = -1;
                    C_watchSupplierCombobox.Items.Clear();
                    foreach (Supplier supplier in system.Suppliers)
                    {
                        C_watchSupplierCombobox.Items.Add(supplier.Name);
                    }
                    C_watchNameEntry.Text = "";
                    C_watchPriceEntry.Value = 0;
                    C_watchRestockEntry.Value = 0;
                    C_watchTypeCombobox.SelectedIndex = -1;
                    return;
            }
        }

        private void C_itemCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            C_createControl.TabPages.Clear();
            switch (C_itemCombobox.SelectedIndex)
            {
                case 0:
                    C_createControl.TabPages.Add(customerPage);
                    break;
                case 1:
                    C_createControl.TabPages.Add(supplierPage);
                    break;
                case 2:
                    C_createControl.TabPages.Add(clothingPage);
                    break;
                case 3:
                    C_createControl.TabPages.Add(shoePage);
                    break;
                case 4:
                    C_createControl.TabPages.Add(bagPage);
                    break;
                case 5:
                    C_createControl.TabPages.Add(nutritionPage);
                    break;
                case 6:
                    C_createControl.TabPages.Add(watchPage);
                    break;
            }
            C_createControl.SelectedIndex = 1;

        }

        private void C_customerCreateButton_Click(object sender, EventArgs e)
        {
            string name = C_customerEntry.Text;
            if (name == "")
            {
                MessageBox.Show("Must enter a name");
                return;
            }

            string email = C_emailEntry.Text;
            if (email == "")
            {
                MessageBox.Show("Must enter an Email");
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email must contain an \"@\" symbol and a domain name (.com)");
                return;
            }

            int balance = (int)C_balanceEntry.Value;

            system.add_customer(name, email, balance);
            MessageBox.Show("Successfully added customer!");
            C_createControl.SelectedIndex = 1;
        }

        private void C_supplierCreateButton_Click(object sender, EventArgs e)
        {
            string name = C_supplierNameEntry.Text;
            if (name == "")
            {
                MessageBox.Show("Must enter a name");
                return;
            }

            system.add_supplier(name);
            MessageBox.Show("Successfully added supplier!");
            C_createControl.SelectedIndex = 1;
        }

        // NEED TO UPDATE SUPPLIER COMBOBOX FOR ALL ITEMS
        private void C_clothingCreateButton_Click(object sender, EventArgs e)
        {
            string size = C_clothingSizeCombobox.Text;
            if (C_clothingSizeCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("No size selected");
                return;
            }
            string colour = C_clothingColourEntry.Text;
            if (colour == "")
            {
                MessageBox.Show("No colour entered");
                return;
            }
            string style = C_clothingTypeCombobox.Text;
            if (C_clothingTypeCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("No clothing type selected");
                return;
            }

            string result = handle_item_errors(C_itemCombobox.Text, C_clothingNameEntry.Text, (double)C_clothingPriceEntry.Value,
                (int)C_clothingRestockEntry.Value, C_clothingSupplierCombobox.Text, new Dictionary<string, string> {
                {"Size", size },
                { "Colour", colour},
                {"Style", style }});
            if (result != "Success")
            {
                MessageBox.Show(result);
                return;
            }
            MessageBox.Show("Successfully added clothing item!");
            C_createControl.SelectedIndex = 1;
        }

        private void C_shoeCreateButton_Click(object sender, EventArgs e)
        {
            string size = C_shoeSizeCombobox.Text;
            if (C_shoeSizeCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("No shoe size selected");
                return;
            }
            string shoeType = C_shoeTypeCombobox.Text;
            if (C_shoeTypeCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("No shoe type selected");
                return;
            }

            string result = handle_item_errors(C_itemCombobox.Text, C_shoeNameEntry.Text, (double)C_shoePriceEntry.Value, (int)C_shoeRestockEntry.Value,
                C_shoeSupplierCombobox.Text, new Dictionary<string, string> {
                {"Size", size },
                { "Type", shoeType}});
            if (result != "Success")
            {
                MessageBox.Show(result);
                return;
            }
            MessageBox.Show("Successfully added shoe!");
            C_createControl.SelectedIndex = 1;
        }

        private void C_bagCreateButton_Click(object sender, EventArgs e)
        {
            string capacity = C_capacityEntry.Value.ToString();
            if (capacity == "0")
            {
                MessageBox.Show("No capacity entered");
                return;
            }

            string result = handle_item_errors(C_itemCombobox.Text, C_bagNameEntry.Text, (double)C_bagPriceEntry.Value, (int)C_bagRestockEntry.Value,
                C_bagSupplierCombobox.Text, new Dictionary<string, string> {
                {"Capacity", capacity }});
            if (result != "Success")
            {
                MessageBox.Show(result);
                return;
            }
            MessageBox.Show("Successfully added bag!");
            C_createControl.SelectedIndex = 1;
        }

        private void C_nutrientCreateButton_Click(object sender, EventArgs e)
        {
            string quantity = C_quantityEntry.Text;
            if (quantity == "")
            {
                MessageBox.Show("No quantity entered");
                return;
            }
            string nutrient = C_nutrientCombobox.Text;
            if (C_nutrientCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("No nutrient type selected");
                return;
            }

            string result = handle_item_errors(C_itemCombobox.Text, C_nutrientNameEntry.Text, (double)C_nutrientPriceEntry.Value,
                (int)C_nutrientRestockEntry.Value, C_nutrientSupplierCombobox.Text, new Dictionary<string, string> {
                {"Quantity", quantity },
                {"Type", nutrient }});
            if (result != "Success")
            {
                MessageBox.Show(result);
                return;
            }
            MessageBox.Show("Successfully added nutrient!");
            C_createControl.SelectedIndex = 1;
        }

        private void C_watchCreateButton_Click(object sender, EventArgs e)
        {
            string watchType = C_watchTypeCombobox.Text;
            if (C_watchTypeCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("No watch type selected");
                return;
            }

            string result = handle_item_errors(C_itemCombobox.Text, C_watchNameEntry.Text, (double)C_watchPriceEntry.Value, (int)C_watchRestockEntry.Value,
                C_watchSupplierCombobox.Text, new Dictionary<string, string> {
                {"Type", watchType }});
            if (result != "Success")
            {
                MessageBox.Show(result);
                return;
            }
            MessageBox.Show("Successfully added watch!");
            C_createControl.SelectedIndex = 1;
        }

        private string handle_item_errors(string type, string name, double price, int stockOrderLevel, string supplierName, Dictionary<string, string> misc)
        {
            // Error handling references
            if (name == "")
            {
                return "No name entered";
            }
            else if (price < 1)
            {
                return "Price must be greater than 0";
            }
            else if (stockOrderLevel < 1)
            {
                return "Restock amount must be greater than 0";
            }
            else if (supplierName == "")
            {
                return "No supplier selected";
            }
            //string name = C_clothingNameEntry.Text;
            //double price = (double)C_clothingPriceEntry.Value;
            //int stockOrderLevel = (int)C_clothingRestocklEntry.Value;
            //string supplierName = C_clothingSupplierCombobox.Text;
            system.add_item(type, name, price, stockOrderLevel, supplierName, misc);
            return "Success";
        }
    }
}
