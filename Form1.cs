using System.Diagnostics;

namespace OOP_Assignment
{
    public partial class Form1 : Form
    {
        List<Item> items = new List<Item>();
        public Form1()
        {
            items.Add(new Item("Bag", 12, 5, 10));
        
            InitializeComponent();

            itemsCombobox.Items.Add(items[0].Name);
        }

        private void restockButton_Click(object sender, EventArgs e)
        {
            Item item = items[itemsCombobox.SelectedIndex];
            if (item.Stock >= item.StockOrderLevel)
            {
                Debug.WriteLine("Stock not at minimum level to require restock");
                return;
            }

            item.restock(Convert.ToInt32(amountEntry.Text));

            stockTextbox.Text = item.Stock.ToString();
            restockCheckbox.Checked = false;
            if (item.Stock < item.StockOrderLevel)
            {
                restockCheckbox.Checked = true;
            }
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
            if (item.Stock < item.StockOrderLevel)
            {
                restockCheckbox.Checked = true;
            }
        }
    }
}
