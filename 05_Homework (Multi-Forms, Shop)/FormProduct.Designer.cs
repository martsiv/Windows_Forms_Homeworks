namespace _05_Lesson__Multi_Forms_
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            buttonOK = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
            labelPrice = new Label();
            labelQuantity = new Label();
            labelCountry = new Label();
            labelDiscount = new Label();
            numericDiscount = new NumericUpDown();
            numericPrice = new NumericUpDown();
            numericQuantity = new NumericUpDown();
            buttonCancel = new Button();
            labelProduct = new Label();
            comboBoxCountry = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(28, 237);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(220, 29);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(148, 54);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(357, 27);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += CheckedButtonOK;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(28, 57);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(28, 90);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.TabIndex = 4;
            labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(28, 123);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(65, 20);
            labelQuantity.TabIndex = 6;
            labelQuantity.Text = "Quantity";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(28, 156);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(60, 20);
            labelCountry.TabIndex = 8;
            labelCountry.Text = "Country";
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(28, 189);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(67, 20);
            labelDiscount.TabIndex = 10;
            labelDiscount.Text = "Discount";
            // 
            // numericDiscount
            // 
            numericDiscount.Location = new Point(148, 186);
            numericDiscount.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericDiscount.Name = "numericDiscount";
            numericDiscount.Size = new Size(357, 27);
            numericDiscount.TabIndex = 11;
            // 
            // numericPrice
            // 
            numericPrice.DecimalPlaces = 2;
            numericPrice.Location = new Point(148, 87);
            numericPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(357, 27);
            numericPrice.TabIndex = 12;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(148, 120);
            numericQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(357, 27);
            numericQuantity.TabIndex = 13;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(310, 237);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(195, 29);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelProduct.Location = new Point(148, 9);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(233, 31);
            labelProduct.TabIndex = 15;
            labelProduct.Text = "Product infarmation";
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Items.AddRange(new object[] { "Ukraine", "USA", "Poland", "Italy", "Germany", "UK" });
            comboBoxCountry.Location = new Point(148, 152);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(357, 28);
            comboBoxCountry.TabIndex = 16;
            comboBoxCountry.SelectedValueChanged += CheckedButtonOK;
            comboBoxCountry.TextChanged += CheckedButtonOK;
            // 
            // FormProduct
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(547, 305);
            Controls.Add(comboBoxCountry);
            Controls.Add(labelProduct);
            Controls.Add(buttonCancel);
            Controls.Add(numericQuantity);
            Controls.Add(numericPrice);
            Controls.Add(numericDiscount);
            Controls.Add(labelDiscount);
            Controls.Add(labelCountry);
            Controls.Add(labelQuantity);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonOK);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormProduct";
            Text = "Product manager";
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelPrice;
        private Label labelQuantity;
        private Label labelCountry;
        private Label labelDiscount;
        private NumericUpDown numericDiscount;
        private NumericUpDown numericPrice;
        private NumericUpDown numericQuantity;
        private Button buttonCancel;
        private Label labelProduct;
        private ComboBox comboBoxCountry;
    }
}