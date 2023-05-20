namespace _05_Lesson__Multi_Forms_
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonShow = new Button();
            buttonRemove = new Button();
            listBoxProducts = new ListBox();
            labelProductList = new Label();
            toolTipEasterEgg = new ToolTip(components);
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(157, 491);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(291, 491);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(426, 491);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(94, 29);
            buttonShow.TabIndex = 7;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(32, 491);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 6;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 20;
            listBoxProducts.Location = new Point(32, 61);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(488, 404);
            listBoxProducts.TabIndex = 5;
            // 
            // labelProductList
            // 
            labelProductList.AutoSize = true;
            labelProductList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductList.Location = new Point(221, 9);
            labelProductList.Name = "labelProductList";
            labelProductList.Size = new Size(138, 31);
            labelProductList.TabIndex = 10;
            labelProductList.Text = "Product list";
            toolTipEasterEgg.SetToolTip(labelProductList, "This is a some tool tip like a Easter Egg");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 561);
            Controls.Add(labelProductList);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonShow);
            Controls.Add(buttonRemove);
            Controls.Add(listBoxProducts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonShow;
        private Button buttonRemove;
        private ListBox listBoxProducts;
        private Label labelProductList;
        private ToolTip toolTipEasterEgg;
    }
}