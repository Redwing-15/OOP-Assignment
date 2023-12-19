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
            T_itemCombobox = new ComboBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            transactionsPage = new TabPage();
            T_addFundsButton = new Button();
            T_addFundsEntry = new NumericUpDown();
            T_balanceTextbox = new TextBox();
            label13 = new Label();
            label12 = new Label();
            T_purchaseTotal = new TextBox();
            label7 = new Label();
            label6 = new Label();
            T_purchasesTextbox = new TextBox();
            T_itemInfoTextbox = new TextBox();
            label5 = new Label();
            T_purchaseAmountEntry = new NumericUpDown();
            T_purchaseButton = new Button();
            label4 = new Label();
            T_customerCombobox = new ComboBox();
            restockPage = new TabPage();
            R_supplierSelectCombobox = new ComboBox();
            label11 = new Label();
            R_supplierTextbbox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            R_itemCombobox = new ComboBox();
            label8 = new Label();
            R_restockableItemsListbox = new ListBox();
            label3 = new Label();
            R_restockCheckbox = new CheckBox();
            R_stockTextbox = new TextBox();
            R_restockButton = new Button();
            label2 = new Label();
            R_restockAmountEntry = new NumericUpDown();
            createPage = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            transactionsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)T_addFundsEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)T_purchaseAmountEntry).BeginInit();
            restockPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)R_restockAmountEntry).BeginInit();
            createPage.SuspendLayout();
            SuspendLayout();
            // 
            // T_itemCombobox
            // 
            T_itemCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            T_itemCombobox.FormattingEnabled = true;
            T_itemCombobox.Location = new Point(600, 22);
            T_itemCombobox.Name = "T_itemCombobox";
            T_itemCombobox.Size = new Size(151, 28);
            T_itemCombobox.TabIndex = 0;
            T_itemCombobox.SelectedIndexChanged += T_itemsCombobox_SelectedIndexChanged;
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
            tabControl1.Controls.Add(createPage);
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
            transactionsPage.Controls.Add(T_addFundsButton);
            transactionsPage.Controls.Add(T_addFundsEntry);
            transactionsPage.Controls.Add(T_balanceTextbox);
            transactionsPage.Controls.Add(label13);
            transactionsPage.Controls.Add(label12);
            transactionsPage.Controls.Add(T_purchaseTotal);
            transactionsPage.Controls.Add(label7);
            transactionsPage.Controls.Add(label6);
            transactionsPage.Controls.Add(T_purchasesTextbox);
            transactionsPage.Controls.Add(T_itemInfoTextbox);
            transactionsPage.Controls.Add(label5);
            transactionsPage.Controls.Add(T_purchaseAmountEntry);
            transactionsPage.Controls.Add(T_purchaseButton);
            transactionsPage.Controls.Add(label4);
            transactionsPage.Controls.Add(T_customerCombobox);
            transactionsPage.Controls.Add(T_itemCombobox);
            transactionsPage.Controls.Add(label1);
            transactionsPage.Location = new Point(4, 29);
            transactionsPage.Name = "transactionsPage";
            transactionsPage.Padding = new Padding(3);
            transactionsPage.Size = new Size(792, 417);
            transactionsPage.TabIndex = 0;
            transactionsPage.Text = "Transactions";
            // 
            // T_addFundsButton
            // 
            T_addFundsButton.Location = new Point(55, 122);
            T_addFundsButton.Name = "T_addFundsButton";
            T_addFundsButton.Size = new Size(94, 29);
            T_addFundsButton.TabIndex = 25;
            T_addFundsButton.Text = "Add Funds";
            T_addFundsButton.UseVisualStyleBackColor = true;
            T_addFundsButton.Click += T_addFundsButton_Click;
            // 
            // T_addFundsEntry
            // 
            T_addFundsEntry.DecimalPlaces = 2;
            T_addFundsEntry.Location = new Point(115, 89);
            T_addFundsEntry.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            T_addFundsEntry.Name = "T_addFundsEntry";
            T_addFundsEntry.Size = new Size(105, 27);
            T_addFundsEntry.TabIndex = 24;
            T_addFundsEntry.TextAlign = HorizontalAlignment.Right;
            T_addFundsEntry.ThousandsSeparator = true;
            // 
            // T_balanceTextbox
            // 
            T_balanceTextbox.BackColor = SystemColors.Window;
            T_balanceTextbox.Location = new Point(115, 53);
            T_balanceTextbox.Name = "T_balanceTextbox";
            T_balanceTextbox.ReadOnly = true;
            T_balanceTextbox.Size = new Size(105, 27);
            T_balanceTextbox.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 91);
            label13.Name = "label13";
            label13.Size = new Size(82, 20);
            label13.TabIndex = 22;
            label13.Text = "Add Funds:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 56);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 21;
            label12.Text = "Balance:";
            // 
            // T_purchaseTotal
            // 
            T_purchaseTotal.BackColor = SystemColors.Window;
            T_purchaseTotal.Location = new Point(633, 229);
            T_purchaseTotal.Name = "T_purchaseTotal";
            T_purchaseTotal.ReadOnly = true;
            T_purchaseTotal.Size = new Size(86, 27);
            T_purchaseTotal.TabIndex = 20;
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
            label6.Location = new Point(23, 162);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 18;
            label6.Text = "Purchases:";
            // 
            // T_purchasesTextbox
            // 
            T_purchasesTextbox.BackColor = SystemColors.Window;
            T_purchasesTextbox.Location = new Point(23, 185);
            T_purchasesTextbox.Multiline = true;
            T_purchasesTextbox.Name = "T_purchasesTextbox";
            T_purchasesTextbox.ReadOnly = true;
            T_purchasesTextbox.ScrollBars = ScrollBars.Vertical;
            T_purchasesTextbox.Size = new Size(467, 224);
            T_purchasesTextbox.TabIndex = 17;
            // 
            // T_itemInfoTextbox
            // 
            T_itemInfoTextbox.BackColor = SystemColors.Menu;
            T_itemInfoTextbox.BorderStyle = BorderStyle.None;
            T_itemInfoTextbox.Location = new Point(546, 66);
            T_itemInfoTextbox.Multiline = true;
            T_itemInfoTextbox.Name = "T_itemInfoTextbox";
            T_itemInfoTextbox.ReadOnly = true;
            T_itemInfoTextbox.Size = new Size(137, 125);
            T_itemInfoTextbox.TabIndex = 16;
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
            // T_purchaseAmountEntry
            // 
            T_purchaseAmountEntry.Location = new Point(633, 197);
            T_purchaseAmountEntry.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            T_purchaseAmountEntry.Name = "T_purchaseAmountEntry";
            T_purchaseAmountEntry.Size = new Size(55, 27);
            T_purchaseAmountEntry.TabIndex = 12;
            T_purchaseAmountEntry.TextAlign = HorizontalAlignment.Right;
            T_purchaseAmountEntry.ValueChanged += T_purchaseAmountEntry_ValueChanged;
            // 
            // T_purchaseButton
            // 
            T_purchaseButton.Location = new Point(565, 262);
            T_purchaseButton.Name = "T_purchaseButton";
            T_purchaseButton.Size = new Size(94, 29);
            T_purchaseButton.TabIndex = 11;
            T_purchaseButton.Text = "Purchase";
            T_purchaseButton.UseVisualStyleBackColor = true;
            T_purchaseButton.Click += T_purchaseButton_Click;
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
            // T_customerCombobox
            // 
            T_customerCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            T_customerCombobox.FormattingEnabled = true;
            T_customerCombobox.Location = new Point(115, 19);
            T_customerCombobox.Name = "T_customerCombobox";
            T_customerCombobox.Size = new Size(151, 28);
            T_customerCombobox.TabIndex = 9;
            T_customerCombobox.SelectedIndexChanged += T_customerCombobox_SelectedIndexChanged;
            // 
            // restockPage
            // 
            restockPage.Controls.Add(R_supplierSelectCombobox);
            restockPage.Controls.Add(label11);
            restockPage.Controls.Add(R_supplierTextbbox);
            restockPage.Controls.Add(label10);
            restockPage.Controls.Add(label9);
            restockPage.Controls.Add(R_itemCombobox);
            restockPage.Controls.Add(label8);
            restockPage.Controls.Add(R_restockableItemsListbox);
            restockPage.Controls.Add(label3);
            restockPage.Controls.Add(R_restockCheckbox);
            restockPage.Controls.Add(R_stockTextbox);
            restockPage.Controls.Add(R_restockButton);
            restockPage.Controls.Add(label2);
            restockPage.Controls.Add(R_restockAmountEntry);
            restockPage.Location = new Point(4, 29);
            restockPage.Name = "restockPage";
            restockPage.Padding = new Padding(3);
            restockPage.Size = new Size(792, 417);
            restockPage.TabIndex = 1;
            restockPage.Text = "Restock";
            restockPage.UseVisualStyleBackColor = true;
            // 
            // R_supplierSelectCombobox
            // 
            R_supplierSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            R_supplierSelectCombobox.FormattingEnabled = true;
            R_supplierSelectCombobox.Items.AddRange(new object[] { "<None>" });
            R_supplierSelectCombobox.Location = new Point(6, 39);
            R_supplierSelectCombobox.Name = "R_supplierSelectCombobox";
            R_supplierSelectCombobox.Size = new Size(151, 28);
            R_supplierSelectCombobox.TabIndex = 22;
            R_supplierSelectCombobox.SelectedIndexChanged += R_supplierSelectCombobox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 16);
            label11.Name = "label11";
            label11.Size = new Size(136, 20);
            label11.TabIndex = 21;
            label11.Text = "Supplier (Optional)";
            // 
            // R_supplierTextbbox
            // 
            R_supplierTextbbox.BackColor = SystemColors.Window;
            R_supplierTextbbox.Location = new Point(597, 45);
            R_supplierTextbbox.Name = "R_supplierTextbbox";
            R_supplierTextbbox.ReadOnly = true;
            R_supplierTextbbox.Size = new Size(125, 27);
            R_supplierTextbbox.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(524, 45);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 19;
            label10.Text = "Supplier:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(524, 13);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 18;
            label9.Text = "Item:";
            // 
            // R_itemCombobox
            // 
            R_itemCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            R_itemCombobox.FormattingEnabled = true;
            R_itemCombobox.Location = new Point(597, 13);
            R_itemCombobox.Name = "R_itemCombobox";
            R_itemCombobox.Size = new Size(151, 28);
            R_itemCombobox.TabIndex = 17;
            R_itemCombobox.SelectedIndexChanged += R_itemCombobox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 70);
            label8.Name = "label8";
            label8.Size = new Size(163, 20);
            label8.TabIndex = 16;
            label8.Text = "Items requiring restock:";
            // 
            // R_restockableItemsListbox
            // 
            R_restockableItemsListbox.FormattingEnabled = true;
            R_restockableItemsListbox.Items.AddRange(new object[] { " " });
            R_restockableItemsListbox.Location = new Point(6, 93);
            R_restockableItemsListbox.Name = "R_restockableItemsListbox";
            R_restockableItemsListbox.Size = new Size(215, 304);
            R_restockableItemsListbox.TabIndex = 15;
            R_restockableItemsListbox.SelectedIndexChanged += R_restockableItemsListbox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 81);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 14;
            label3.Text = "Stock:";
            // 
            // R_restockCheckbox
            // 
            R_restockCheckbox.AutoCheck = false;
            R_restockCheckbox.AutoSize = true;
            R_restockCheckbox.Location = new Point(640, 81);
            R_restockCheckbox.Name = "R_restockCheckbox";
            R_restockCheckbox.Size = new Size(146, 24);
            R_restockCheckbox.TabIndex = 13;
            R_restockCheckbox.Text = "Requires restock?";
            R_restockCheckbox.UseVisualStyleBackColor = true;
            // 
            // R_stockTextbox
            // 
            R_stockTextbox.Location = new Point(595, 78);
            R_stockTextbox.Name = "R_stockTextbox";
            R_stockTextbox.ReadOnly = true;
            R_stockTextbox.Size = new Size(37, 27);
            R_stockTextbox.TabIndex = 12;
            R_stockTextbox.TextChanged += R_stockTextbox_TextChanged;
            // 
            // R_restockButton
            // 
            R_restockButton.Location = new Point(595, 164);
            R_restockButton.Name = "R_restockButton";
            R_restockButton.Size = new Size(94, 29);
            R_restockButton.TabIndex = 9;
            R_restockButton.Text = "Restock";
            R_restockButton.UseVisualStyleBackColor = true;
            R_restockButton.Click += R_restockButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 122);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 11;
            label2.Text = "Amount:";
            // 
            // R_restockAmountEntry
            // 
            R_restockAmountEntry.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            R_restockAmountEntry.Location = new Point(597, 120);
            R_restockAmountEntry.Name = "R_restockAmountEntry";
            R_restockAmountEntry.Size = new Size(60, 27);
            R_restockAmountEntry.TabIndex = 10;
            R_restockAmountEntry.TextAlign = HorizontalAlignment.Right;
            // 
            // createPage
            // 
            createPage.Controls.Add(button1);
            createPage.Location = new Point(4, 29);
            createPage.Name = "createPage";
            createPage.Size = new Size(792, 417);
            createPage.TabIndex = 2;
            createPage.Text = "Create New";
            createPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(335, 103);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Create Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            ((System.ComponentModel.ISupportInitialize)T_addFundsEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)T_purchaseAmountEntry).EndInit();
            restockPage.ResumeLayout(false);
            restockPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)R_restockAmountEntry).EndInit();
            createPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox T_itemCombobox;
        private Label label1;
        private TabControl tabControl1;
        private TabPage transactionsPage;
        private TabPage restockPage;
        private Label label4;
        private ComboBox T_customerCombobox;
        private Button T_purchaseButton;
        private NumericUpDown T_purchaseAmountEntry;
        private Label label5;
        private Label label3;
        private CheckBox R_restockCheckbox;
        private TextBox R_stockTextbox;
        private Button R_restockButton;
        private Label label2;
        private NumericUpDown R_restockAmountEntry;
        private TextBox T_itemInfoTextbox;
        private Label label6;
        private TextBox T_purchasesTextbox;
        private TextBox T_purchaseTotal;
        private Label label7;
        private ListBox R_restockableItemsListbox;
        private Label label8;
        private TextBox R_supplierTextbbox;
        private Label label10;
        private Label label9;
        private ComboBox R_itemCombobox;
        private ComboBox R_supplierSelectCombobox;
        private Label label11;
        private Button T_addFundsButton;
        private NumericUpDown T_addFundsEntry;
        private TextBox T_balanceTextbox;
        private Label label13;
        private Label label12;
        private TabPage createPage;
        private Button button1;
    }
}
