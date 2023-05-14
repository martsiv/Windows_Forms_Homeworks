namespace _01._2_Homework__Nu_pogodi_
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
            egg = new PictureBox();
            ScoreLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            basket = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)egg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)basket).BeginInit();
            SuspendLayout();
            // 
            // egg
            // 
            egg.BackColor = Color.Transparent;
            egg.BackgroundImageLayout = ImageLayout.Stretch;
            egg.Image = Properties.Resources.Egg;
            egg.Location = new Point(385, 65);
            egg.Name = "egg";
            egg.Size = new Size(65, 46);
            egg.SizeMode = PictureBoxSizeMode.StretchImage;
            egg.TabIndex = 0;
            egg.TabStop = false;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.BackColor = SystemColors.InactiveCaption;
            ScoreLabel.BorderStyle = BorderStyle.Fixed3D;
            ScoreLabel.Location = new Point(27, 13);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(63, 22);
            ScoreLabel.TabIndex = 2;
            ScoreLabel.Text = "Score: 0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 400;
            timer1.Tick += timer1_Tick;
            // 
            // basket
            // 
            basket.BackColor = Color.Transparent;
            basket.Image = Properties.Resources.basket;
            basket.Location = new Point(350, 445);
            basket.Name = "basket";
            basket.Size = new Size(149, 99);
            basket.SizeMode = PictureBoxSizeMode.StretchImage;
            basket.TabIndex = 3;
            basket.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(814, 565);
            Controls.Add(basket);
            Controls.Add(ScoreLabel);
            Controls.Add(egg);
            Name = "Form1";
            Text = "Ну постривай!";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)egg).EndInit();
            ((System.ComponentModel.ISupportInitialize)basket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox egg;
        private Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private PictureBox basket;
    }
}