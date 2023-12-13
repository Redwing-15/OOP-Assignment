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
            restockButton = new Button();
            restockAmountEntry = new NumericUpDown();
            label2 = new Label();
            stockTextbox = new TextBox();
            restockCheckbox = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            purchaseAmountEntry = new NumericUpDown();
            purchaseButton = new Button();
            label4 = new Label();
            customerCombobox = new ComboBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)restockAmountEntry).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseAmountEntry).BeginInit();
            SuspendLayout();
            // 
            // itemsCombobox
            // 
            itemsCombobox.FormattingEnabled = true;
            itemsCombobox.Location = new Point(154, 15);
            itemsCombobox.Name = "itemsCombobox";
            itemsCombobox.Size = new Size(151, 28);
            itemsCombobox.TabIndex = 0;
            itemsCombobox.SelectedIndexChanged += itemsCombobox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Item:";
            // 
            // restockButton
            // 
            restockButton.Location = new Point(89, 354);
            restockButton.Name = "restockButton";
            restockButton.Size = new Size(94, 29);
            restockButton.TabIndex = 2;
            restockButton.Text = "Restock";
            restockButton.UseVisualStyleBackColor = true;
            restockButton.Click += restockButton_Click;
            // 
            // restockAmountEntry
            // 
            restockAmountEntry.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            restockAmountEntry.Location = new Point(138, 321);
            restockAmountEntry.Name = "restockAmountEntry";
            restockAmountEntry.Size = new Size(60, 27);
            restockAmountEntry.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 323);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Amount:";
            // 
            // stockTextbox
            // 
            stockTextbox.Location = new Point(67, 260);
            stockTextbox.Name = "stockTextbox";
            stockTextbox.ReadOnly = true;
            stockTextbox.Size = new Size(37, 27);
            stockTextbox.TabIndex = 6;
            stockTextbox.TextChanged += stockTextbox_TextChanged;
            // 
            // restockCheckbox
            // 
            restockCheckbox.AutoCheck = false;
            restockCheckbox.AutoSize = true;
            restockCheckbox.Location = new Point(117, 263);
            restockCheckbox.Name = "restockCheckbox";
            restockCheckbox.Size = new Size(146, 24);
            restockCheckbox.TabIndex = 7;
            restockCheckbox.Text = "Requires restock?";
            restockCheckbox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 8;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(purchaseAmountEntry);
            tabPage1.Controls.Add(purchaseButton);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(customerCombobox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(itemsCombobox);
            tabPage1.Controls.Add(restockCheckbox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(stockTextbox);
            tabPage1.Controls.Add(restockButton);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(restockAmountEntry);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(310, 84);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 13;
            label5.Text = "Amount:";
            // 
            // purchaseAmountEntry
            // 
            purchaseAmountEntry.Location = new Point(381, 82);
            purchaseAmountEntry.Name = "purchaseAmountEntry";
            purchaseAmountEntry.Size = new Size(55, 27);
            purchaseAmountEntry.TabIndex = 12;
            // 
            // purchaseButton
            // 
            purchaseButton.Location = new Point(362, 115);
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
            label4.Location = new Point(507, 23);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Customer:";
            // 
            // customerCombobox
            // 
            customerCombobox.FormattingEnabled = true;
            customerCombobox.Location = new Point(588, 20);
            customerCombobox.Name = "customerCombobox";
            customerCombobox.Size = new Size(151, 28);
            customerCombobox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 263);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "Stock:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)restockAmountEntry).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseAmountEntry).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox itemsCombobox;
        private Label label1;
        private Button restockButton;
        private NumericUpDown restockAmountEntry;
        private Label label2;
        private TextBox stockTextbox;
        private CheckBox restockCheckbox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private TabPage tabPage2;
        private Label label4;
        private ComboBox customerCombobox;
        private Button purchaseButton;
        private NumericUpDown purchaseAmountEntry;
        private Label label5;
    }
}
