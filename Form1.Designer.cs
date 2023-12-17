namespace OOP_Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemsCombobox = new ComboBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            transactionsPage = new TabPage();
            purchaseTotal = new TextBox();
            label7 = new Label();
            label6 = new Label();
            purchasesTextbox = new TextBox();
            itemInfoTextbox = new TextBox();
            label5 = new Label();
            purchaseAmountEntry = new NumericUpDown();
            purchaseButton = new Button();
            label4 = new Label();
            customerCombobox = new ComboBox();
            restockPage = new TabPage();
            label3 = new Label();
            restockCheckbox = new CheckBox();
            stockTextbox = new TextBox();
            restockButton = new Button();
            label2 = new Label();
            restockAmountEntry = new NumericUpDown();
            tabControl1.SuspendLayout();
            transactionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseAmountEntry).BeginInit();
            restockPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)restockAmountEntry).BeginInit();
            SuspendLayout();
            // 
            // itemsCombobox
            // 
            itemsCombobox.FormattingEnabled = true;
            itemsCombobox.Location = new Point(600, 22);
            itemsCombobox.Name = "itemsCombobox";
            itemsCombobox.Size = new Size(151, 28);
            itemsCombobox.TabIndex = 0;
            itemsCombobox.SelectedIndexChanged += itemsCombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Item:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(transactionsPage);
            tabControl1.Controls.Add(restockPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 8;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // transactionsPage
            // 
            transactionsPage.BackColor = SystemColors.Menu;
            transactionsPage.Controls.Add(purchaseTotal);
            transactionsPage.Controls.Add(label7);
            transactionsPage.Controls.Add(label6);
            transactionsPage.Controls.Add(purchasesTextbox);
            transactionsPage.Controls.Add(itemInfoTextbox);
            transactionsPage.Controls.Add(label5);
            transactionsPage.Controls.Add(purchaseAmountEntry);
            transactionsPage.Controls.Add(purchaseButton);
            transactionsPage.Controls.Add(label4);
            transactionsPage.Controls.Add(customerCombobox);
            transactionsPage.Controls.Add(itemsCombobox);
            transactionsPage.Controls.Add(label1);
            transactionsPage.Location = new Point(4, 29);
            transactionsPage.Name = "transactionsPage";
            transactionsPage.Padding = new Padding(3);
            transactionsPage.Size = new Size(792, 417);
            transactionsPage.TabIndex = 0;
            transactionsPage.Text = "Transactions";
            // 
            // purchaseTotal
            // 
            purchaseTotal.BackColor = SystemColors.Window;
            purchaseTotal.Location = new Point(633, 229);
            purchaseTotal.Name = "purchaseTotal";
            purchaseTotal.ReadOnly = true;
            purchaseTotal.Size = new Size(86, 27);
            purchaseTotal.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(546, 232);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 19;
            label7.Text = "Total Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 53);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 18;
            label6.Text = "Purchases:";
            // 
            // purchasesTextbox
            // 
            purchasesTextbox.BackColor = SystemColors.Window;
            purchasesTextbox.Location = new Point(22, 76);
            purchasesTextbox.Multiline = true;
            purchasesTextbox.Name = "purchasesTextbox";
            purchasesTextbox.ReadOnly = true;
            purchasesTextbox.Size = new Size(259, 306);
            purchasesTextbox.TabIndex = 17;
            // 
            // itemInfoTextbox
            // 
            itemInfoTextbox.BackColor = SystemColors.Menu;
            itemInfoTextbox.BorderStyle = BorderStyle.None;
            itemInfoTextbox.Location = new Point(546, 66);
            itemInfoTextbox.Multiline = true;
            itemInfoTextbox.Name = "itemInfoTextbox";
            itemInfoTextbox.ReadOnly = true;
            itemInfoTextbox.Size = new Size(137, 125);
            itemInfoTextbox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(546, 199);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 13;
            label5.Text = "Amount:";
            // 
            // purchaseAmountEntry
            // 
            purchaseAmountEntry.Location = new Point(633, 197);
            purchaseAmountEntry.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            purchaseAmountEntry.Name = "purchaseAmountEntry";
            purchaseAmountEntry.Size = new Size(55, 27);
            purchaseAmountEntry.TabIndex = 12;
            purchaseAmountEntry.ValueChanged += purchaseAmountEntry_ValueChanged;
            // 
            // purchaseButton
            // 
            purchaseButton.Location = new Point(565, 262);
            purchaseButton.Name = "purchaseButton";
            purchaseButton.Size = new Size(94, 29);
            purchaseButton.TabIndex = 11;
            purchaseButton.Text = "Purchase";
            purchaseButton.UseVisualStyleBackColor = true;
            purchaseButton.Click += purchaseButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 22);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Customer:";
            // 
            // customerCombobox
            // 
            customerCombobox.FormattingEnabled = true;
            customerCombobox.Location = new Point(115, 19);
            customerCombobox.Name = "customerCombobox";
            customerCombobox.Size = new Size(151, 28);
            customerCombobox.TabIndex = 9;
            customerCombobox.SelectedIndexChanged += customerCombobox_SelectedIndexChanged_1;
            // 
            // restockPage
            // 
            restockPage.Controls.Add(label3);
            restockPage.Controls.Add(restockCheckbox);
            restockPage.Controls.Add(stockTextbox);
            restockPage.Controls.Add(restockButton);
            restockPage.Controls.Add(label2);
            restockPage.Controls.Add(restockAmountEntry);
            restockPage.Location = new Point(4, 29);
            restockPage.Name = "restockPage";
            restockPage.Padding = new Padding(3);
            restockPage.Size = new Size(792, 417);
            restockPage.TabIndex = 1;
            restockPage.Text = "Restock";
            restockPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 150);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 14;
            label3.Text = "Stock:";
            // 
            // restockCheckbox
            // 
            restockCheckbox.AutoCheck = false;
            restockCheckbox.AutoSize = true;
            restockCheckbox.Location = new Point(375, 150);
            restockCheckbox.Name = "restockCheckbox";
            restockCheckbox.Size = new Size(146, 24);
            restockCheckbox.TabIndex = 13;
            restockCheckbox.Text = "Requires restock?";
            restockCheckbox.UseVisualStyleBackColor = true;
            // 
            // stockTextbox
            // 
            stockTextbox.Location = new Point(325, 147);
            stockTextbox.Name = "stockTextbox";
            stockTextbox.ReadOnly = true;
            stockTextbox.Size = new Size(37, 27);
            stockTextbox.TabIndex = 12;
            // 
            // restockButton
            // 
            restockButton.Location = new Point(347, 241);
            restockButton.Name = "restockButton";
            restockButton.Size = new Size(94, 29);
            restockButton.TabIndex = 9;
            restockButton.Text = "Restock";
            restockButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 210);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 11;
            label2.Text = "Amount:";
            // 
            // restockAmountEntry
            // 
            restockAmountEntry.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            restockAmountEntry.Location = new Point(396, 208);
            restockAmountEntry.Name = "restockAmountEntry";
            restockAmountEntry.Size = new Size(60, 27);
            restockAmountEntry.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            transactionsPage.ResumeLayout(false);
            transactionsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseAmountEntry).EndInit();
            restockPage.ResumeLayout(false);
            restockPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)restockAmountEntry).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox itemsCombobox;
        private Label label1;
        private TabControl tabControl1;
        private TabPage transactionsPage;
        private TabPage restockPage;
        private Label label4;
        private ComboBox customerCombobox;
        private Button purchaseButton;
        private NumericUpDown purchaseAmountEntry;
        private Label label5;
        private Label label3;
        private CheckBox restockCheckbox;
        private TextBox stockTextbox;
        private Button restockButton;
        private Label label2;
        private NumericUpDown restockAmountEntry;
        private TextBox itemInfoTextbox;
        private Label label6;
        private TextBox purchasesTextbox;
        private TextBox purchaseTotal;
        private Label label7;
    }
}
