namespace _08_Lesson__GDI__
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            toolStripButtonColor = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip1 = new ToolStrip();
            toolStripLabelInstruments = new ToolStripLabel();
            toolStripComboBoxInstruments = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonUndo = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            labelSize = new Label();
            trackBarSize = new TrackBar();
            toolStripButtonOpenImage = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(967, 528);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // toolStripButtonColor
            // 
            toolStripButtonColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonColor.Image = (Image)resources.GetObject("toolStripButtonColor.Image");
            toolStripButtonColor.ImageTransparentColor = Color.Magenta;
            toolStripButtonColor.Name = "toolStripButtonColor";
            toolStripButtonColor.Size = new Size(49, 25);
            toolStripButtonColor.Text = "Color";
            toolStripButtonColor.Click += toolStripButtonColor_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripLabelInstruments, toolStripComboBoxInstruments, toolStripSeparator2, toolStripButtonColor, toolStripButtonUndo, toolStripButtonSave, toolStripButtonOpenImage });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(995, 28);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelInstruments
            // 
            toolStripLabelInstruments.Name = "toolStripLabelInstruments";
            toolStripLabelInstruments.Size = new Size(85, 25);
            toolStripLabelInstruments.Text = "Instruments";
            // 
            // toolStripComboBoxInstruments
            // 
            toolStripComboBoxInstruments.Name = "toolStripComboBoxInstruments";
            toolStripComboBoxInstruments.Size = new Size(121, 28);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // toolStripButtonUndo
            // 
            toolStripButtonUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUndo.Image = Properties.Resources.Icons8_Windows_8_Arrows_Undo_48;
            toolStripButtonUndo.ImageTransparentColor = Color.Magenta;
            toolStripButtonUndo.Name = "toolStripButtonUndo";
            toolStripButtonUndo.Size = new Size(29, 25);
            toolStripButtonUndo.Text = "toolStripButtonUndo";
            toolStripButtonUndo.Click += toolStripButtonUndo_Click;
            // 
            // toolStripButtonSave
            // 
            toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave.Image = Properties.Resources.Custom_Icon_Design_Mono_General_1_Save_48;
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(29, 25);
            toolStripButtonSave.Text = "toolStripButtonSave";
            toolStripButtonSave.Click += toolStripButtonSave_Click;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(12, 27);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(36, 20);
            labelSize.TabIndex = 2;
            labelSize.Text = "Size";
            // 
            // trackBarSize
            // 
            trackBarSize.Location = new Point(54, 27);
            trackBarSize.Maximum = 9;
            trackBarSize.Minimum = 1;
            trackBarSize.Name = "trackBarSize";
            trackBarSize.Size = new Size(120, 56);
            trackBarSize.TabIndex = 3;
            trackBarSize.Value = 2;
            trackBarSize.ValueChanged += trackBarSize_ValueChanged;
            // 
            // toolStripButtonOpenImage
            // 
            toolStripButtonOpenImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonOpenImage.Image = Properties.Resources.Ionic_Ionicons_Open_48;
            toolStripButtonOpenImage.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpenImage.Name = "toolStripButtonOpenImage";
            toolStripButtonOpenImage.Size = new Size(29, 25);
            toolStripButtonOpenImage.Text = "toolStripButton1";
            toolStripButtonOpenImage.Click += toolStripButtonOpenImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 616);
            Controls.Add(trackBarSize);
            Controls.Add(labelSize);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Painter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private ToolStripButton toolStripButtonColor;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStrip toolStrip1;
        private Label labelSize;
        private TrackBar trackBarSize;
        private ToolStripLabel toolStripLabelInstruments;
        private ToolStripComboBox toolStripComboBoxInstruments;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonUndo;
        private ToolStripButton toolStripButtonSave;
        private ToolStripButton toolStripButtonOpenImage;
    }
}