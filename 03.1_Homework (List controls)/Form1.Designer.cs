namespace _03._1_Lesson__List_controls_
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
            components = new System.ComponentModel.Container();
            comboBoxModelToFind = new ComboBox();
            carBindingSource1 = new BindingSource(components);
            comboBoxModel = new ComboBox();
            listBoxCars = new ListBox();
            carBindingSource = new BindingSource(components);
            labelCars = new Label();
            buttonRemoveCar = new Button();
            labelAddCar = new Label();
            labelModel = new Label();
            labelColor = new Label();
            comboBoxColor = new ComboBox();
            labelYear = new Label();
            textBoxYear = new TextBox();
            textBoxNumber = new TextBox();
            labelNumber = new Label();
            textBoxVIN = new TextBox();
            labelVIN = new Label();
            buttonAddCar = new Button();
            labelFindCar = new Label();
            label1 = new Label();
            buttonShowDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)carBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxModelToFind
            // 
            comboBoxModelToFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxModelToFind.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxModelToFind.FormattingEnabled = true;
            comboBoxModelToFind.Location = new Point(534, 299);
            comboBoxModelToFind.Name = "comboBoxModelToFind";
            comboBoxModelToFind.Size = new Size(271, 28);
            comboBoxModelToFind.TabIndex = 16;
            // 
            // carBindingSource1
            // 
            carBindingSource1.DataSource = typeof(Car);
            // 
            // comboBoxModel
            // 
            comboBoxModel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxModel.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Items.AddRange(new object[] { "VW Golf", "VW Passat", "Suzuki Jimni", "Mercedese Vito", "Reno Megan", "Reno Scenic" });
            comboBoxModel.Location = new Point(116, 71);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(271, 28);
            comboBoxModel.TabIndex = 0;
            // 
            // listBoxCars
            // 
            listBoxCars.FormattingEnabled = true;
            listBoxCars.ItemHeight = 20;
            listBoxCars.Location = new Point(439, 68);
            listBoxCars.Name = "listBoxCars";
            listBoxCars.SelectionMode = SelectionMode.MultiExtended;
            listBoxCars.Size = new Size(506, 104);
            listBoxCars.TabIndex = 1;
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
            // 
            // labelCars
            // 
            labelCars.AutoSize = true;
            labelCars.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCars.Location = new Point(683, 25);
            labelCars.Name = "labelCars";
            labelCars.Size = new Size(52, 28);
            labelCars.TabIndex = 2;
            labelCars.Text = "Cars";
            // 
            // buttonRemoveCar
            // 
            buttonRemoveCar.Location = new Point(439, 201);
            buttonRemoveCar.Name = "buttonRemoveCar";
            buttonRemoveCar.Size = new Size(94, 29);
            buttonRemoveCar.TabIndex = 3;
            buttonRemoveCar.Text = "Remove";
            buttonRemoveCar.UseVisualStyleBackColor = true;
            buttonRemoveCar.Click += RemoveCarBtnClick;
            // 
            // labelAddCar
            // 
            labelAddCar.AutoSize = true;
            labelAddCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddCar.Location = new Point(185, 25);
            labelAddCar.Name = "labelAddCar";
            labelAddCar.Size = new Size(85, 28);
            labelAddCar.TabIndex = 4;
            labelAddCar.Text = "Add car";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(24, 71);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(52, 20);
            labelModel.TabIndex = 5;
            labelModel.Text = "Model";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(24, 114);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(45, 20);
            labelColor.TabIndex = 7;
            labelColor.Text = "Color";
            // 
            // comboBoxColor
            // 
            comboBoxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxColor.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Items.AddRange(new object[] { "Black", "White", "Yellow", "Red", "Green", "Orange", "Blue" });
            comboBoxColor.Location = new Point(116, 114);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(271, 28);
            comboBoxColor.TabIndex = 6;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(24, 155);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(37, 20);
            labelYear.TabIndex = 8;
            labelYear.Text = "Year";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(116, 148);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(271, 27);
            textBoxYear.TabIndex = 9;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(116, 190);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(271, 27);
            textBoxNumber.TabIndex = 11;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(24, 197);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(63, 20);
            labelNumber.TabIndex = 10;
            labelNumber.Text = "Number";
            // 
            // textBoxVIN
            // 
            textBoxVIN.Location = new Point(116, 239);
            textBoxVIN.Name = "textBoxVIN";
            textBoxVIN.Size = new Size(271, 27);
            textBoxVIN.TabIndex = 13;
            // 
            // labelVIN
            // 
            labelVIN.AutoSize = true;
            labelVIN.Location = new Point(24, 246);
            labelVIN.Name = "labelVIN";
            labelVIN.Size = new Size(33, 20);
            labelVIN.TabIndex = 12;
            labelVIN.Text = "VIN";
            // 
            // buttonAddCar
            // 
            buttonAddCar.Location = new Point(24, 299);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(94, 29);
            buttonAddCar.TabIndex = 14;
            buttonAddCar.Text = "Add car";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // labelFindCar
            // 
            labelFindCar.AutoSize = true;
            labelFindCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFindCar.Location = new Point(622, 246);
            labelFindCar.Name = "labelFindCar";
            labelFindCar.Size = new Size(173, 28);
            labelFindCar.TabIndex = 15;
            labelFindCar.Text = "Get find your car";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 299);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 17;
            label1.Text = "Model";
            // 
            // buttonShowDetail
            // 
            buttonShowDetail.Location = new Point(442, 344);
            buttonShowDetail.Name = "buttonShowDetail";
            buttonShowDetail.Size = new Size(129, 29);
            buttonShowDetail.TabIndex = 18;
            buttonShowDetail.Text = "Show detail";
            buttonShowDetail.UseVisualStyleBackColor = true;
            buttonShowDetail.Click += buttonShowDetail_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 459);
            Controls.Add(buttonShowDetail);
            Controls.Add(label1);
            Controls.Add(comboBoxModelToFind);
            Controls.Add(labelFindCar);
            Controls.Add(buttonAddCar);
            Controls.Add(textBoxVIN);
            Controls.Add(labelVIN);
            Controls.Add(textBoxNumber);
            Controls.Add(labelNumber);
            Controls.Add(textBoxYear);
            Controls.Add(labelYear);
            Controls.Add(labelColor);
            Controls.Add(comboBoxColor);
            Controls.Add(labelModel);
            Controls.Add(labelAddCar);
            Controls.Add(buttonRemoveCar);
            Controls.Add(labelCars);
            Controls.Add(listBoxCars);
            Controls.Add(comboBoxModel);
            Name = "Form1";
            Text = "Car list";
            ((System.ComponentModel.ISupportInitialize)carBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxModel;
        private ListBox listBoxCars;
        private Label labelCars;
        private Button buttonRemoveCar;
        private Label labelAddCar;
        private Label labelModel;
        private Label labelColor;
        private ComboBox comboBoxColor;
        private Label labelYear;
        private TextBox textBoxYear;
        private TextBox textBoxNumber;
        private Label labelNumber;
        private TextBox textBoxVIN;
        private Label labelVIN;
        private Button buttonAddCar;
        private Label labelFindCar;
        private Label label1;
        private ComboBox comboBoxModelToFind;
        private Button buttonShowDetail;
        private BindingSource carBindingSource;
        private BindingSource carBindingSource1;
    }
}