namespace _07_tree_list_view
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
            TreeNode treeNode1 = new TreeNode("Employee 1");
            TreeNode treeNode2 = new TreeNode("Employee 2");
            TreeNode treeNode3 = new TreeNode("Manager 1", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Node6");
            TreeNode treeNode5 = new TreeNode("Node5", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Node4", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("Manager 2", new TreeNode[] { treeNode6 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            treeView1 = new TreeView();
            imageList1 = new ImageList(components);
            toolStrip1 = new ToolStrip();
            toolStripButtonOpenRoot = new ToolStripButton();
            toolStripLabelView = new ToolStripLabel();
            toolStripComboBoxView = new ToolStripComboBox();
            toolStripButtonMinus = new ToolStripButton();
            toolStripButtonPlus = new ToolStripButton();
            toolStripButtonNewDirectory = new ToolStripButton();
            toolStripTextBoxNewDirectory = new ToolStripTextBox();
            toolStripButtonRenameDirectory = new ToolStripButton();
            toolStripTextBoxRenameDirectory = new ToolStripTextBox();
            toolStripButtonRenameFile = new ToolStripButton();
            toolStripTextBoxRenameFile = new ToolStripTextBox();
            toolStripButtonDeleteFile = new ToolStripButton();
            toolStripButtonDublicate = new ToolStripButton();
            toolStripButtonShowHidden = new ToolStripButton();
            listView1 = new ListView();
            imageList2 = new ImageList(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(11, 83);
            treeView1.Margin = new Padding(2);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Employee 1";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Employee 2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Manager 1";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Node6";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Node4";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Manager 2";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode7 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(405, 543);
            treeView1.TabIndex = 0;
            treeView1.AfterCollapse += treeView1_AfterCollapse;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-folder-30.png");
            imageList1.Images.SetKeyName(1, "icons8-opened-folder-30.png");
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonOpenRoot, toolStripLabelView, toolStripComboBoxView, toolStripButtonMinus, toolStripButtonPlus, toolStripButtonNewDirectory, toolStripTextBoxNewDirectory, toolStripButtonRenameDirectory, toolStripTextBoxRenameDirectory, toolStripButtonRenameFile, toolStripTextBoxRenameFile, toolStripButtonDeleteFile, toolStripButtonDublicate, toolStripButtonShowHidden });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1296, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpenRoot
            // 
            toolStripButtonOpenRoot.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonOpenRoot.Image = (Image)resources.GetObject("toolStripButtonOpenRoot.Image");
            toolStripButtonOpenRoot.ImageTransparentColor = Color.Magenta;
            toolStripButtonOpenRoot.Name = "toolStripButtonOpenRoot";
            toolStripButtonOpenRoot.Size = new Size(85, 25);
            toolStripButtonOpenRoot.Text = "Open Root";
            toolStripButtonOpenRoot.Click += toolStripButtonOpenRoot_Click;
            // 
            // toolStripLabelView
            // 
            toolStripLabelView.Name = "toolStripLabelView";
            toolStripLabelView.Size = new Size(44, 25);
            toolStripLabelView.Text = "View:";
            // 
            // toolStripComboBoxView
            // 
            toolStripComboBoxView.Items.AddRange(new object[] { "Tiles", "Details", "Large Icons", "Small Icons", "List" });
            toolStripComboBoxView.Name = "toolStripComboBoxView";
            toolStripComboBoxView.Size = new Size(125, 28);
            toolStripComboBoxView.SelectedIndexChanged += toolStripComboBoxView_SelectedIndexChanged;
            // 
            // toolStripButtonMinus
            // 
            toolStripButtonMinus.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonMinus.Image = Properties.Resources.icons8_minus_50;
            toolStripButtonMinus.ImageTransparentColor = Color.Magenta;
            toolStripButtonMinus.Name = "toolStripButtonMinus";
            toolStripButtonMinus.Size = new Size(36, 36);
            toolStripButtonMinus.Text = "toolStripButton1";
            toolStripButtonMinus.Visible = false;
            toolStripButtonMinus.Click += toolStripButtonMinus_Click;
            // 
            // toolStripButtonPlus
            // 
            toolStripButtonPlus.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPlus.Image = Properties.Resources.icons8_plus_50;
            toolStripButtonPlus.ImageTransparentColor = Color.Magenta;
            toolStripButtonPlus.Name = "toolStripButtonPlus";
            toolStripButtonPlus.Size = new Size(36, 36);
            toolStripButtonPlus.Text = "toolStripButton2";
            toolStripButtonPlus.Visible = false;
            toolStripButtonPlus.Click += toolStripButtonPlus_Click;
            // 
            // toolStripButtonNewDirectory
            // 
            toolStripButtonNewDirectory.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonNewDirectory.Image = (Image)resources.GetObject("toolStripButtonNewDirectory.Image");
            toolStripButtonNewDirectory.ImageTransparentColor = Color.Magenta;
            toolStripButtonNewDirectory.Name = "toolStripButtonNewDirectory";
            toolStripButtonNewDirectory.Size = new Size(106, 25);
            toolStripButtonNewDirectory.Text = "New directory";
            toolStripButtonNewDirectory.Click += toolStripButtonNewDirectory_Click;
            // 
            // toolStripTextBoxNewDirectory
            // 
            toolStripTextBoxNewDirectory.Name = "toolStripTextBoxNewDirectory";
            toolStripTextBoxNewDirectory.Size = new Size(100, 28);
            // 
            // toolStripButtonRenameDirectory
            // 
            toolStripButtonRenameDirectory.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonRenameDirectory.Image = (Image)resources.GetObject("toolStripButtonRenameDirectory.Image");
            toolStripButtonRenameDirectory.ImageTransparentColor = Color.Magenta;
            toolStripButtonRenameDirectory.Name = "toolStripButtonRenameDirectory";
            toolStripButtonRenameDirectory.Size = new Size(130, 25);
            toolStripButtonRenameDirectory.Text = "Rename directory";
            toolStripButtonRenameDirectory.Click += toolStripButtonRenameDirectory_Click;
            // 
            // toolStripTextBoxRenameDirectory
            // 
            toolStripTextBoxRenameDirectory.Name = "toolStripTextBoxRenameDirectory";
            toolStripTextBoxRenameDirectory.Size = new Size(100, 28);
            // 
            // toolStripButtonRenameFile
            // 
            toolStripButtonRenameFile.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonRenameFile.Image = (Image)resources.GetObject("toolStripButtonRenameFile.Image");
            toolStripButtonRenameFile.ImageTransparentColor = Color.Magenta;
            toolStripButtonRenameFile.Name = "toolStripButtonRenameFile";
            toolStripButtonRenameFile.Size = new Size(94, 25);
            toolStripButtonRenameFile.Text = "Rename File";
            toolStripButtonRenameFile.Click += toolStripButtonRenameFile_Click;
            // 
            // toolStripTextBoxRenameFile
            // 
            toolStripTextBoxRenameFile.Name = "toolStripTextBoxRenameFile";
            toolStripTextBoxRenameFile.Size = new Size(100, 28);
            // 
            // toolStripButtonDeleteFile
            // 
            toolStripButtonDeleteFile.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonDeleteFile.Image = (Image)resources.GetObject("toolStripButtonDeleteFile.Image");
            toolStripButtonDeleteFile.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteFile.Name = "toolStripButtonDeleteFile";
            toolStripButtonDeleteFile.Size = new Size(84, 25);
            toolStripButtonDeleteFile.Text = "Delete File";
            toolStripButtonDeleteFile.Click += toolStripButtonDeleteFile_Click;
            // 
            // toolStripButtonDublicate
            // 
            toolStripButtonDublicate.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonDublicate.Image = (Image)resources.GetObject("toolStripButtonDublicate.Image");
            toolStripButtonDublicate.ImageTransparentColor = Color.Magenta;
            toolStripButtonDublicate.Name = "toolStripButtonDublicate";
            toolStripButtonDublicate.Size = new Size(77, 25);
            toolStripButtonDublicate.Text = "Dublicate";
            toolStripButtonDublicate.Click += toolStripButtonDublicate_Click;
            // 
            // toolStripButtonShowHidden
            // 
            toolStripButtonShowHidden.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonShowHidden.Image = (Image)resources.GetObject("toolStripButtonShowHidden.Image");
            toolStripButtonShowHidden.ImageTransparentColor = Color.Magenta;
            toolStripButtonShowHidden.Name = "toolStripButtonShowHidden";
            toolStripButtonShowHidden.Size = new Size(102, 25);
            toolStripButtonShowHidden.Text = "Show Hidden";
            toolStripButtonShowHidden.Click += toolStripButtonShowHidden_Click;
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList2;
            listView1.Location = new Point(436, 83);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(802, 543);
            listView1.SmallImageList = imageList2;
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth4Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "icons8-file-26.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 665);
            Controls.Add(listView1);
            Controls.Add(toolStrip1);
            Controls.Add(treeView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonOpenRoot;
        private ListView listView1;
        private ImageList imageList1;
        private ImageList imageList2;
        private ToolStripLabel toolStripLabelView;
        private ToolStripComboBox toolStripComboBoxView;
        private ToolStripButton toolStripButtonNewDirectory;
        private ToolStripButton toolStripButtonRenameDirectory;
        private ToolStripButton toolStripButtonRenameFile;
        private ToolStripButton toolStripButtonDeleteFile;
        private ToolStripButton toolStripButtonDublicate;
        private ToolStripButton toolStripButtonShowHidden;
        private ToolStripTextBox toolStripTextBoxNewDirectory;
        private ToolStripTextBox toolStripTextBoxRenameDirectory;
        private ToolStripTextBox toolStripTextBoxRenameFile;
        private ToolStripButton toolStripButtonMinus;
        private ToolStripButton toolStripButtonPlus;
    }
}