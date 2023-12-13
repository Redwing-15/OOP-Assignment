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
            amountEntry = new NumericUpDown();
            label2 = new Label();
            stockTextbox = new TextBox();
            restockCheckbox = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)amountEntry).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            restockButton.Location = new Point(165, 152);
            restockButton.Name = "restockButton";
            restockButton.Size = new Size(94, 29);
            restockButton.TabIndex = 2;
            restockButton.Text = "Restock";
            restockButton.UseVisualStyleBackColor = true;
            restockButton.Click += restockButton_Click;
            // 
            // amountEntry
            // 
            amountEntry.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            amountEntry.Location = new Point(225, 119);
            amountEntry.Name = "amountEntry";
            amountEntry.Size = new Size(43, 27);
            amountEntry.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 121);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Amount:";
            // 
            // stockTextbox
            // 
            stockTextbox.Location = new Point(154, 58);
            stockTextbox.Name = "stockTextbox";
            stockTextbox.ReadOnly = true;
            stockTextbox.Size = new Size(37, 27);
            stockTextbox.TabIndex = 6;
            // 
            // restockCheckbox
            // 
            restockCheckbox.AutoCheck = false;
            restockCheckbox.AutoSize = true;
            restockCheckbox.Location = new Point(204, 61);
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
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(itemsCombobox);
            tabPage1.Controls.Add(restockCheckbox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(stockTextbox);
            tabPage1.Controls.Add(restockButton);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(amountEntry);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 61);
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
            ((System.ComponentModel.ISupportInitialize)amountEntry).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox itemsCombobox;
        private Label label1;
        private Button restockButton;
        private NumericUpDown amountEntry;
        private Label label2;
        private TextBox stockTextbox;
        private CheckBox restockCheckbox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private TabPage tabPage2;
    }
}
