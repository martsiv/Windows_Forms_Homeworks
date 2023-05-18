namespace _04._1_Lesson__Range_Controls_
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
            labelMain = new Label();
            buttonStart = new Button();
            labelWords = new Label();
            labelCaseSensetive = new Label();
            progressBar1 = new ProgressBar();
            labelProgress = new Label();
            textBoxInput = new TextBox();
            numericUpDown1 = new NumericUpDown();
            radioButtonYes = new RadioButton();
            radioButtonNo = new RadioButton();
            textBoxOutput = new TextBox();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelMain.ForeColor = Color.MediumTurquoise;
            labelMain.Location = new Point(277, 12);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(247, 41);
            labelMain.TabIndex = 0;
            labelMain.Text = "Keyboard trainer";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(59, 76);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelWords
            // 
            labelWords.AutoSize = true;
            labelWords.Location = new Point(228, 80);
            labelWords.Name = "labelWords";
            labelWords.Size = new Size(54, 20);
            labelWords.TabIndex = 2;
            labelWords.Text = "Words:";
            // 
            // labelCaseSensetive
            // 
            labelCaseSensetive.AutoSize = true;
            labelCaseSensetive.Location = new Point(460, 85);
            labelCaseSensetive.Name = "labelCaseSensetive";
            labelCaseSensetive.Size = new Size(109, 20);
            labelCaseSensetive.TabIndex = 3;
            labelCaseSensetive.Text = "Case Sensetive:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(383, 399);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(357, 29);
            progressBar1.TabIndex = 4;
            // 
            // labelProgress
            // 
            labelProgress.AutoSize = true;
            labelProgress.Location = new Point(275, 399);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(68, 20);
            labelProgress.TabIndex = 5;
            labelProgress.Text = "Progress:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(57, 205);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(683, 181);
            textBoxInput.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(303, 78);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.Checked = true;
            radioButtonYes.Location = new Point(575, 83);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(51, 24);
            radioButtonYes.TabIndex = 8;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Yes";
            radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Location = new Point(632, 83);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(50, 24);
            radioButtonNo.TabIndex = 9;
            radioButtonNo.Text = "No";
            radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // textBoxOutput
            // 
            textBoxOutput.BorderStyle = BorderStyle.FixedSingle;
            textBoxOutput.Location = new Point(57, 126);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(681, 53);
            textBoxOutput.TabIndex = 10;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(99, 399);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(63, 20);
            labelTime.TabIndex = 11;
            labelTime.Text = "Time: 0s";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTime);
            Controls.Add(textBoxOutput);
            Controls.Add(radioButtonNo);
            Controls.Add(radioButtonYes);
            Controls.Add(numericUpDown1);
            Controls.Add(textBoxInput);
            Controls.Add(labelProgress);
            Controls.Add(progressBar1);
            Controls.Add(labelCaseSensetive);
            Controls.Add(labelWords);
            Controls.Add(buttonStart);
            Controls.Add(labelMain);
            Name = "Form1";
            Text = "Keyboard trainer";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMain;
        private Button buttonStart;
        private Label labelWords;
        private Label labelCaseSensetive;
        private ProgressBar progressBar1;
        private Label labelProgress;
        private TextBox textBoxInput;
        private NumericUpDown numericUpDown1;
        private RadioButton radioButtonYes;
        private RadioButton radioButtonNo;
        private TextBox textBoxOutput;
        private Label labelTime;
        private System.Windows.Forms.Timer timer1;
    }
}