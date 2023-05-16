namespace _02._1_Homework__controls_
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
            groupBoxDrinks = new GroupBox();
            labelPriceAlcohol = new Label();
            labelPriceCoffee = new Label();
            labelPriceTea = new Label();
            labelPriceWater = new Label();
            labelPriceCola = new Label();
            radioButtonAlcohol = new RadioButton();
            radioButtonCoffee = new RadioButton();
            radioButtonTea = new RadioButton();
            radioButtonWater = new RadioButton();
            radioButtonCola = new RadioButton();
            groupBoxFood = new GroupBox();
            labelPriceMeat = new Label();
            radioButtonMeat = new RadioButton();
            labelPriceDries = new Label();
            radioButtonPizza = new RadioButton();
            labelPriceSalad = new Label();
            radioButtonFries = new RadioButton();
            labelPriceBurger = new Label();
            radioButtonBurger = new RadioButton();
            labelPricePizza = new Label();
            radioButtonSalad = new RadioButton();
            groupBoxDessert = new GroupBox();
            labelPriceSorbet = new Label();
            radioButtonSorbet = new RadioButton();
            labelPriceCheesecake = new Label();
            radioButtonCake = new RadioButton();
            labelPricePie = new Label();
            radioButtonCheesecake = new RadioButton();
            labelPricePudding = new Label();
            radioButtonPudding = new RadioButton();
            labelPriceCake = new Label();
            radioButtonPie = new RadioButton();
            labelTotalPrice = new Label();
            buttonOrder = new Button();
            labelOrders = new Label();
            textBoxTotalPrice = new TextBox();
            listBoxOrders = new ListBox();
            groupBoxDrinks.SuspendLayout();
            groupBoxFood.SuspendLayout();
            groupBoxDessert.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDrinks
            // 
            groupBoxDrinks.Controls.Add(labelPriceAlcohol);
            groupBoxDrinks.Controls.Add(labelPriceCoffee);
            groupBoxDrinks.Controls.Add(labelPriceTea);
            groupBoxDrinks.Controls.Add(labelPriceWater);
            groupBoxDrinks.Controls.Add(labelPriceCola);
            groupBoxDrinks.Controls.Add(radioButtonAlcohol);
            groupBoxDrinks.Controls.Add(radioButtonCoffee);
            groupBoxDrinks.Controls.Add(radioButtonTea);
            groupBoxDrinks.Controls.Add(radioButtonWater);
            groupBoxDrinks.Controls.Add(radioButtonCola);
            groupBoxDrinks.Location = new Point(53, 21);
            groupBoxDrinks.Name = "groupBoxDrinks";
            groupBoxDrinks.Size = new Size(250, 228);
            groupBoxDrinks.TabIndex = 0;
            groupBoxDrinks.TabStop = false;
            groupBoxDrinks.Text = "Drinks";
            // 
            // labelPriceAlcohol
            // 
            labelPriceAlcohol.AutoSize = true;
            labelPriceAlcohol.Location = new Point(194, 158);
            labelPriceAlcohol.Name = "labelPriceAlcohol";
            labelPriceAlcohol.Size = new Size(33, 20);
            labelPriceAlcohol.TabIndex = 9;
            labelPriceAlcohol.Text = "10$";
            // 
            // labelPriceCoffee
            // 
            labelPriceCoffee.AutoSize = true;
            labelPriceCoffee.Location = new Point(194, 130);
            labelPriceCoffee.Name = "labelPriceCoffee";
            labelPriceCoffee.Size = new Size(25, 20);
            labelPriceCoffee.TabIndex = 8;
            labelPriceCoffee.Text = "5$";
            // 
            // labelPriceTea
            // 
            labelPriceTea.AutoSize = true;
            labelPriceTea.Location = new Point(194, 100);
            labelPriceTea.Name = "labelPriceTea";
            labelPriceTea.Size = new Size(25, 20);
            labelPriceTea.TabIndex = 7;
            labelPriceTea.Text = "4$";
            // 
            // labelPriceWater
            // 
            labelPriceWater.AutoSize = true;
            labelPriceWater.Location = new Point(194, 70);
            labelPriceWater.Name = "labelPriceWater";
            labelPriceWater.Size = new Size(25, 20);
            labelPriceWater.TabIndex = 6;
            labelPriceWater.Text = "2$";
            // 
            // labelPriceCola
            // 
            labelPriceCola.AutoSize = true;
            labelPriceCola.Location = new Point(194, 40);
            labelPriceCola.Name = "labelPriceCola";
            labelPriceCola.Size = new Size(25, 20);
            labelPriceCola.TabIndex = 5;
            labelPriceCola.Text = "3$";
            // 
            // radioButtonAlcohol
            // 
            radioButtonAlcohol.AutoSize = true;
            radioButtonAlcohol.Location = new Point(6, 156);
            radioButtonAlcohol.Name = "radioButtonAlcohol";
            radioButtonAlcohol.Size = new Size(81, 24);
            radioButtonAlcohol.TabIndex = 4;
            radioButtonAlcohol.TabStop = true;
            radioButtonAlcohol.Tag = "10";
            radioButtonAlcohol.Text = "Alcohol";
            radioButtonAlcohol.UseVisualStyleBackColor = true;
            radioButtonAlcohol.CheckedChanged += radioButtonCheckedChanged;
            // 
            // radioButtonCoffee
            // 
            radioButtonCoffee.AutoSize = true;
            radioButtonCoffee.Location = new Point(6, 126);
            radioButtonCoffee.Name = "radioButtonCoffee";
            radioButtonCoffee.Size = new Size(74, 24);
            radioButtonCoffee.TabIndex = 3;
            radioButtonCoffee.TabStop = true;
            radioButtonCoffee.Tag = "5";
            radioButtonCoffee.Text = "Coffee";
            radioButtonCoffee.UseVisualStyleBackColor = true;
            radioButtonCoffee.CheckedChanged += radioButtonCheckedChanged;
            // 
            // radioButtonTea
            // 
            radioButtonTea.AutoSize = true;
            radioButtonTea.Location = new Point(6, 96);
            radioButtonTea.Name = "radioButtonTea";
            radioButtonTea.Size = new Size(53, 24);
            radioButtonTea.TabIndex = 2;
            radioButtonTea.TabStop = true;
            radioButtonTea.Tag = "4";
            radioButtonTea.Text = "Tea";
            radioButtonTea.UseVisualStyleBackColor = true;
            radioButtonTea.CheckedChanged += radioButtonCheckedChanged;
            // 
            // radioButtonWater
            // 
            radioButtonWater.AutoSize = true;
            radioButtonWater.Location = new Point(6, 66);
            radioButtonWater.Name = "radioButtonWater";
            radioButtonWater.Size = new Size(69, 24);
            radioButtonWater.TabIndex = 1;
            radioButtonWater.TabStop = true;
            radioButtonWater.Tag = "2";
            radioButtonWater.Text = "Water";
            radioButtonWater.UseVisualStyleBackColor = true;
            radioButtonWater.CheckedChanged += radioButtonCheckedChanged;
            // 
            // radioButtonCola
            // 
            radioButtonCola.AutoSize = true;
            radioButtonCola.Location = new Point(6, 36);
            radioButtonCola.Name = "radioButtonCola";
            radioButtonCola.Size = new Size(60, 24);
            radioButtonCola.TabIndex = 0;
            radioButtonCola.TabStop = true;
            radioButtonCola.Tag = "3";
            radioButtonCola.Text = "Cola";
            radioButtonCola.UseVisualStyleBackColor = true;
            radioButtonCola.CheckedChanged += radioButtonCheckedChanged;
            // 
            // groupBoxFood
            // 
            groupBoxFood.Controls.Add(labelPriceMeat);
            groupBoxFood.Controls.Add(radioButtonMeat);
            groupBoxFood.Controls.Add(labelPriceDries);
            groupBoxFood.Controls.Add(radioButtonPizza);
            groupBoxFood.Controls.Add(labelPriceSalad);
            groupBoxFood.Controls.Add(radioButtonFries);
            groupBoxFood.Controls.Add(labelPriceBurger);
            groupBoxFood.Controls.Add(radioButtonBurger);
            groupBoxFood.Controls.Add(labelPricePizza);
            groupBoxFood.Controls.Add(radioButtonSalad);
            groupBoxFood.Location = new Point(334, 21);
            groupBoxFood.Name = "groupBoxFood";
            groupBoxFood.Size = new Size(250, 228);
            groupBoxFood.TabIndex = 1;
            groupBoxFood.TabStop = false;
            groupBoxFood.Text = "Food";
            // 
            // labelPriceMeat
            // 
            labelPriceMeat.AutoSize = true;
            labelPriceMeat.Location = new Point(192, 158);
            labelPriceMeat.Name = "labelPriceMeat";
            labelPriceMeat.Size = new Size(33, 20);
            labelPriceMeat.TabIndex = 14;
            labelPriceMeat.Text = "18$";
            // 
            // radioButtonMeat
            // 
            radioButtonMeat.AutoSize = true;
            radioButtonMeat.Location = new Point(6, 156);
            radioButtonMeat.Name = "radioButtonMeat";
            radioButtonMeat.Size = new Size(64, 24);
            radioButtonMeat.TabIndex = 9;
            radioButtonMeat.TabStop = true;
            radioButtonMeat.Tag = "18";
            radioButtonMeat.Text = "Meat";
            radioButtonMeat.UseVisualStyleBackColor = true;
            radioButtonMeat.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelPriceDries
            // 
            labelPriceDries.AutoSize = true;
            labelPriceDries.Location = new Point(192, 130);
            labelPriceDries.Name = "labelPriceDries";
            labelPriceDries.Size = new Size(25, 20);
            labelPriceDries.TabIndex = 13;
            labelPriceDries.Text = "6$";
            // 
            // radioButtonPizza
            // 
            radioButtonPizza.AutoSize = true;
            radioButtonPizza.Location = new Point(6, 36);
            radioButtonPizza.Name = "radioButtonPizza";
            radioButtonPizza.Size = new Size(64, 24);
            radioButtonPizza.TabIndex = 5;
            radioButtonPizza.TabStop = true;
            radioButtonPizza.Tag = "12";
            radioButtonPizza.Text = "Pizza";
            radioButtonPizza.UseVisualStyleBackColor = true;
            radioButtonPizza.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelPriceSalad
            // 
            labelPriceSalad.AutoSize = true;
            labelPriceSalad.Location = new Point(192, 100);
            labelPriceSalad.Name = "labelPriceSalad";
            labelPriceSalad.Size = new Size(25, 20);
            labelPriceSalad.TabIndex = 12;
            labelPriceSalad.Text = "9$";
            // 
            // radioButtonFries
            // 
            radioButtonFries.AutoSize = true;
            radioButtonFries.Location = new Point(6, 126);
            radioButtonFries.Name = "radioButtonFries";
            radioButtonFries.Size = new Size(60, 24);
            radioButtonFries.TabIndex = 8;
            radioButtonFries.TabStop = true;
            radioButtonFries.Tag = "6";
            radioButtonFries.Text = "Fries";
            radioButtonFries.UseVisualStyleBackColor = true;
            radioButtonFries.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelPriceBurger
            // 
            labelPriceBurger.AutoSize = true;
            labelPriceBurger.Location = new Point(192, 70);
            labelPriceBurger.Name = "labelPriceBurger";
            labelPriceBurger.Size = new Size(25, 20);
            labelPriceBurger.TabIndex = 11;
            labelPriceBurger.Text = "8$";
            // 
            // radioButtonBurger
            // 
            radioButtonBurger.AutoSize = true;
            radioButtonBurger.Location = new Point(6, 66);
            radioButtonBurger.Name = "radioButtonBurger";
            radioButtonBurger.Size = new Size(74, 24);
            radioButtonBurger.TabIndex = 6;
            radioButtonBurger.TabStop = true;
            radioButtonBurger.Tag = "8";
            radioButtonBurger.Text = "Burger";
            radioButtonBurger.UseVisualStyleBackColor = true;
            radioButtonBurger.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelPricePizza
            // 
            labelPricePizza.AutoSize = true;
            labelPricePizza.Location = new Point(192, 40);
            labelPricePizza.Name = "labelPricePizza";
            labelPricePizza.Size = new Size(33, 20);
            labelPricePizza.TabIndex = 10;
            labelPricePizza.Text = "12$";
            // 
            // radioButtonSalad
            // 
            radioButtonSalad.AutoSize = true;
            radioButtonSalad.Location = new Point(6, 96);
            radioButtonSalad.Name = "radioButtonSalad";
            radioButtonSalad.Size = new Size(67, 24);
            radioButtonSalad.TabIndex = 7;
            radioButtonSalad.TabStop = true;
            radioButtonSalad.Tag = "9";
            radioButtonSalad.Text = "Salad";
            radioButtonSalad.UseVisualStyleBackColor = true;
            radioButtonSalad.CheckedChanged += radioButtonCheckedChanged;
            // 
            // groupBoxDessert
            // 
            groupBoxDessert.Controls.Add(labelPriceSorbet);
            groupBoxDessert.Controls.Add(radioButtonSorbet);
            groupBoxDessert.Controls.Add(labelPriceCheesecake);
            groupBoxDessert.Controls.Add(radioButtonCake);
            groupBoxDessert.Controls.Add(labelPricePie);
            groupBoxDessert.Controls.Add(radioButtonCheesecake);
            groupBoxDessert.Controls.Add(labelPricePudding);
            groupBoxDessert.Controls.Add(radioButtonPudding);
            groupBoxDessert.Controls.Add(labelPriceCake);
            groupBoxDessert.Controls.Add(radioButtonPie);
            groupBoxDessert.Location = new Point(616, 21);
            groupBoxDessert.Name = "groupBoxDessert";
            groupBoxDessert.Size = new Size(250, 228);
            groupBoxDessert.TabIndex = 2;
            groupBoxDessert.TabStop = false;
            groupBoxDessert.Text = "Dessert";
            // 
            // labelPriceSorbet
            // 
            labelPriceSorbet.AutoSize = true;
            labelPriceSorbet.Location = new Point(188, 156);
            labelPriceSorbet.Name = "labelPriceSorbet";
            labelPriceSorbet.Size = new Size(33, 20);
            labelPriceSorbet.TabIndex = 19;
            labelPriceSorbet.Text = "14$";
            // 
            // radioButtonSorbet
            // 
            radioButtonSorbet.AutoSize = true;
            radioButtonSorbet.Location = new Point(6, 156);
            radioButtonSorbet.Name = "radioButtonSorbet";
            radioButtonSorbet.Size = new Size(74, 24);
            radioButtonSorbet.TabIndex = 14;
            radioButtonSorbet.TabStop = true;
            radioButtonSorbet.Tag = "14";
            radioButtonSorbet.Text = "Sorbet";
            radioButtonSorbet.UseVisualStyleBackColor = true;
            radioButtonSorbet.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelPriceCheesecake
            // 
            labelPriceCheesecake.AutoSize = true;
            labelPriceCheesecake.Location = new Point(188, 128);
            labelPriceCheesecake.Name = "labelPriceCheesecake";
            labelPriceCheesecake.Size = new Size(33, 20);
            labelPriceCheesecake.TabIndex = 18;
            labelPriceCheesecake.Text = "17$";
            // 
            // radioButtonCake
            // 
            radioButtonCake.AutoSize = true;
            radioButtonCake.Location = new Point(6, 36);
            radioButtonCake.Name = "radioButtonCake";
            radioButtonCake.Size = new Size(62, 24);
            radioButtonCake.TabIndex = 10;
            radioButtonCake.TabStop = true;
            radioButtonCake.Tag = "16";
            radioButtonCake.Text = "Cake";
            radioButtonCake.UseVisualStyleBackColor = true;
            radioButtonCake.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelPricePie
            // 
            labelPricePie.AutoSize = true;
            labelPricePie.Location = new Point(188, 98);
            labelPricePie.Name = "labelPricePie";
            labelPricePie.Size = new Size(33, 20);
            labelPricePie.TabIndex = 17;
            labelPricePie.Text = "18$";
            // 
            // radioButtonCheesecake
            // 
            radioButtonCheesecake.AutoSize = true;
            radioButtonCheesecake.Location = new Point(6, 126);
            radioButtonCheesecake.Name = "radioButtonCheesecake";
            radioButtonCheesecake.Size = new Size(107, 24);
            radioButtonCheesecake.TabIndex = 13;
            radioButtonCheesecake.TabStop = true;
            radioButtonCheesecake.Tag = "17";
            radioButtonCheesecake.Text = "Cheesecake";
            radioButtonCheesecake.UseVisualStyleBackColor = true;
            radioButtonCheesecake.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelPricePudding
            // 
            labelPricePudding.AutoSize = true;
            labelPricePudding.Location = new Point(188, 68);
            labelPricePudding.Name = "labelPricePudding";
            labelPricePudding.Size = new Size(33, 20);
            labelPricePudding.TabIndex = 16;
            labelPricePudding.Text = "13$";
            // 
            // radioButtonPudding
            // 
            radioButtonPudding.AutoSize = true;
            radioButtonPudding.Location = new Point(6, 66);
            radioButtonPudding.Name = "radioButtonPudding";
            radioButtonPudding.Size = new Size(85, 24);
            radioButtonPudding.TabIndex = 11;
            radioButtonPudding.TabStop = true;
            radioButtonPudding.Tag = "13";
            radioButtonPudding.Text = "Pudding";
            radioButtonPudding.UseVisualStyleBackColor = true;
            radioButtonPudding.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelPriceCake
            // 
            labelPriceCake.AutoSize = true;
            labelPriceCake.Location = new Point(188, 38);
            labelPriceCake.Name = "labelPriceCake";
            labelPriceCake.Size = new Size(33, 20);
            labelPriceCake.TabIndex = 15;
            labelPriceCake.Text = "16$";
            // 
            // radioButtonPie
            // 
            radioButtonPie.AutoSize = true;
            radioButtonPie.Location = new Point(6, 96);
            radioButtonPie.Name = "radioButtonPie";
            radioButtonPie.Size = new Size(50, 24);
            radioButtonPie.TabIndex = 12;
            radioButtonPie.TabStop = true;
            radioButtonPie.Tag = "18";
            radioButtonPie.Text = "Pie";
            radioButtonPie.UseVisualStyleBackColor = true;
            radioButtonPie.CheckedChanged += radioButtonCheckedChanged;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(636, 363);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(86, 20);
            labelTotalPrice.TabIndex = 4;
            labelTotalPrice.Text = "Total price: ";
            // 
            // buttonOrder
            // 
            buttonOrder.Enabled = false;
            buttonOrder.Location = new Point(720, 389);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(129, 29);
            buttonOrder.TabIndex = 5;
            buttonOrder.Text = "Order";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Location = new Point(59, 265);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(60, 20);
            labelOrders.TabIndex = 7;
            labelOrders.Text = "Orders: ";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(720, 363);
            textBoxTotalPrice.Multiline = true;
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(129, 24);
            textBoxTotalPrice.TabIndex = 8;
            textBoxTotalPrice.Text = "0$";
            textBoxTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // listBoxOrders
            // 
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.ItemHeight = 20;
            listBoxOrders.Location = new Point(59, 300);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.Size = new Size(525, 204);
            listBoxOrders.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 531);
            Controls.Add(listBoxOrders);
            Controls.Add(textBoxTotalPrice);
            Controls.Add(labelOrders);
            Controls.Add(buttonOrder);
            Controls.Add(labelTotalPrice);
            Controls.Add(groupBoxDessert);
            Controls.Add(groupBoxFood);
            Controls.Add(groupBoxDrinks);
            Name = "Form1";
            Text = "Menu";
            groupBoxDrinks.ResumeLayout(false);
            groupBoxDrinks.PerformLayout();
            groupBoxFood.ResumeLayout(false);
            groupBoxFood.PerformLayout();
            groupBoxDessert.ResumeLayout(false);
            groupBoxDessert.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxDrinks;
        private RadioButton radioButtonAlcohol;
        private RadioButton radioButtonCoffee;
        private RadioButton radioButtonTea;
        private RadioButton radioButtonWater;
        private RadioButton radioButtonCola;
        private GroupBox groupBoxFood;
        private RadioButton radioButtonMeat;
        private RadioButton radioButtonPizza;
        private RadioButton radioButtonFries;
        private RadioButton radioButtonBurger;
        private RadioButton radioButtonSalad;
        private GroupBox groupBoxDessert;
        private RadioButton radioButtonSorbet;
        private RadioButton radioButtonCake;
        private RadioButton radioButtonCheesecake;
        private RadioButton radioButtonPudding;
        private RadioButton radioButtonPie;
        private Label labelPriceAlcohol;
        private Label labelPriceCoffee;
        private Label labelPriceTea;
        private Label labelPriceWater;
        private Label labelPriceCola;
        private Label labelPriceMeat;
        private Label labelPriceDries;
        private Label labelPriceSalad;
        private Label labelPriceBurger;
        private Label labelPricePizza;
        private Label labelPriceSorbet;
        private Label labelPriceCheesecake;
        private Label labelPricePie;
        private Label labelPricePudding;
        private Label labelPriceCake;
        private Label labelTotalPrice;
        private Button buttonOrder;
        private Label labelOrders;
        private TextBox textBoxTotalPrice;
        private ListBox listBoxOrders;
    }
}