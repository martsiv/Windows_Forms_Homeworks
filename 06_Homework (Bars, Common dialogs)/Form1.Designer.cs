namespace _06_Lesson__Bars__Common_dialogs_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            deselectAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            fontToolStripMenuItem = new ToolStripMenuItem();
            textColorToolStripMenuItem = new ToolStripMenuItem();
            vievToolStripMenuItem = new ToolStripMenuItem();
            themeDarkwhiteToolStripMenuItem = new ToolStripMenuItem();
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            maximizeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButtNew = new ToolStripButton();
            toolStripButtOpen = new ToolStripButton();
            toolStripButtSave = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButtCut = new ToolStripButton();
            toolStripButtCopy = new ToolStripButton();
            toolStripButtPaste = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButtFont = new ToolStripButton();
            toolStripButtColor = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copyToolStripMenuCopy = new ToolStripMenuItem();
            cutToolStripMenuCut = new ToolStripMenuItem();
            pasteToolStripMenuPaste = new ToolStripMenuItem();
            clearToolStripMenuClear = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            richTextBox = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, vievToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator3, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(240, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newDocument_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(240, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(237, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(240, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(240, 26);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            exitToolStripMenuItem.Size = new Size(240, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator7, selectAllToolStripMenuItem, deselectAllToolStripMenuItem, toolStripSeparator6, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator2, fontToolStripMenuItem, textColorToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(261, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            redoToolStripMenuItem.Size = new Size(261, 26);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(258, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(261, 26);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // deselectAllToolStripMenuItem
            // 
            deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            deselectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.A;
            deselectAllToolStripMenuItem.Size = new Size(261, 26);
            deselectAllToolStripMenuItem.Text = "Deselect all";
            deselectAllToolStripMenuItem.Click += deselectAllToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(258, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(261, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(261, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            pasteToolStripMenuItem.Size = new Size(261, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(261, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(258, 6);
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(261, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // textColorToolStripMenuItem
            // 
            textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            textColorToolStripMenuItem.Size = new Size(261, 26);
            textColorToolStripMenuItem.Text = "Text color";
            textColorToolStripMenuItem.Click += textColorToolStripMenuItem_Click;
            // 
            // vievToolStripMenuItem
            // 
            vievToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeDarkwhiteToolStripMenuItem, minimizeToolStripMenuItem, maximizeToolStripMenuItem });
            vievToolStripMenuItem.Name = "vievToolStripMenuItem";
            vievToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Down;
            vievToolStripMenuItem.Size = new Size(51, 24);
            vievToolStripMenuItem.Text = "Viev";
            // 
            // themeDarkwhiteToolStripMenuItem
            // 
            themeDarkwhiteToolStripMenuItem.CheckOnClick = true;
            themeDarkwhiteToolStripMenuItem.Name = "themeDarkwhiteToolStripMenuItem";
            themeDarkwhiteToolStripMenuItem.Size = new Size(274, 26);
            themeDarkwhiteToolStripMenuItem.Text = "Theme dark/white";
            themeDarkwhiteToolStripMenuItem.Click += themeDarkwhiteToolStripMenuItem_Click;
            // 
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Down;
            minimizeToolStripMenuItem.Size = new Size(274, 26);
            minimizeToolStripMenuItem.Text = "Minimize";
            minimizeToolStripMenuItem.Click += minimizeToolStripMenuItem_Click;
            // 
            // maximizeToolStripMenuItem
            // 
            maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            maximizeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Up;
            maximizeToolStripMenuItem.Size = new Size(274, 26);
            maximizeToolStripMenuItem.Text = "Maximize";
            maximizeToolStripMenuItem.Click += maximizeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtNew, toolStripButtOpen, toolStripButtSave, toolStripSeparator4, toolStripButtCut, toolStripButtCopy, toolStripButtPaste, toolStripSeparator5, toolStripButtFont, toolStripButtColor });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtNew
            // 
            toolStripButtNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtNew.Image = Properties.Resources.icons8_новая_копия_30;
            toolStripButtNew.ImageTransparentColor = Color.Magenta;
            toolStripButtNew.Name = "toolStripButtNew";
            toolStripButtNew.Size = new Size(29, 24);
            toolStripButtNew.Text = "New document";
            toolStripButtNew.Click += newDocument_Click;
            // 
            // toolStripButtOpen
            // 
            toolStripButtOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtOpen.Image = Properties.Resources.icons8_открыть_документ_50;
            toolStripButtOpen.ImageTransparentColor = Color.Magenta;
            toolStripButtOpen.Name = "toolStripButtOpen";
            toolStripButtOpen.Size = new Size(29, 24);
            toolStripButtOpen.Text = "Open document";
            toolStripButtOpen.Click += openToolStripMenuItem_Click;
            // 
            // toolStripButtSave
            // 
            toolStripButtSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtSave.Image = Properties.Resources.icons8_сохранить_48;
            toolStripButtSave.ImageTransparentColor = Color.Magenta;
            toolStripButtSave.Name = "toolStripButtSave";
            toolStripButtSave.Size = new Size(29, 24);
            toolStripButtSave.Text = "Save document";
            toolStripButtSave.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // toolStripButtCut
            // 
            toolStripButtCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtCut.Image = Properties.Resources.icons8_вырезать_50;
            toolStripButtCut.ImageTransparentColor = Color.Magenta;
            toolStripButtCut.Name = "toolStripButtCut";
            toolStripButtCut.Size = new Size(29, 24);
            toolStripButtCut.Text = "Cut";
            toolStripButtCut.Click += cutToolStripMenuItem_Click;
            // 
            // toolStripButtCopy
            // 
            toolStripButtCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtCopy.Image = Properties.Resources.icons8_скопировать_50;
            toolStripButtCopy.ImageTransparentColor = Color.Magenta;
            toolStripButtCopy.Name = "toolStripButtCopy";
            toolStripButtCopy.Size = new Size(29, 24);
            toolStripButtCopy.Text = "Copy";
            toolStripButtCopy.Click += copyToolStripMenuItem_Click;
            // 
            // toolStripButtPaste
            // 
            toolStripButtPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtPaste.Image = Properties.Resources.icons8_вставить_как_текст_48;
            toolStripButtPaste.ImageTransparentColor = Color.Magenta;
            toolStripButtPaste.Name = "toolStripButtPaste";
            toolStripButtPaste.Size = new Size(29, 24);
            toolStripButtPaste.Text = "Paste";
            toolStripButtPaste.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 27);
            // 
            // toolStripButtFont
            // 
            toolStripButtFont.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtFont.Image = Properties.Resources.icons8_регистр_заглавной_буквы_предложения_50;
            toolStripButtFont.ImageTransparentColor = Color.Magenta;
            toolStripButtFont.Name = "toolStripButtFont";
            toolStripButtFont.Size = new Size(29, 24);
            toolStripButtFont.Text = "Font";
            toolStripButtFont.Click += fontToolStripMenuItem_Click;
            // 
            // toolStripButtColor
            // 
            toolStripButtColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtColor.Image = Properties.Resources.icons8_цвет_текста_50;
            toolStripButtColor.ImageTransparentColor = Color.Magenta;
            toolStripButtColor.Name = "toolStripButtColor";
            toolStripButtColor.Size = new Size(29, 24);
            toolStripButtColor.Text = "Color";
            toolStripButtColor.Click += textColorToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copyToolStripMenuCopy, cutToolStripMenuCut, pasteToolStripMenuPaste, clearToolStripMenuClear });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 100);
            // 
            // copyToolStripMenuCopy
            // 
            copyToolStripMenuCopy.Name = "copyToolStripMenuCopy";
            copyToolStripMenuCopy.Size = new Size(112, 24);
            copyToolStripMenuCopy.Text = "Copy";
            // 
            // cutToolStripMenuCut
            // 
            cutToolStripMenuCut.Name = "cutToolStripMenuCut";
            cutToolStripMenuCut.Size = new Size(112, 24);
            cutToolStripMenuCut.Text = "Cut";
            // 
            // pasteToolStripMenuPaste
            // 
            pasteToolStripMenuPaste.Name = "pasteToolStripMenuPaste";
            pasteToolStripMenuPaste.Size = new Size(112, 24);
            pasteToolStripMenuPaste.Text = "Paste";
            // 
            // clearToolStripMenuClear
            // 
            clearToolStripMenuClear.Name = "clearToolStripMenuClear";
            clearToolStripMenuClear.Size = new Size(112, 24);
            clearToolStripMenuClear.Text = "Clear";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(84, 20);
            toolStripStatusLabel1.Text = "Symbols: --";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(73, 20);
            toolStripStatusLabel2.Text = "Strings: --";
            // 
            // richTextBox
            // 
            richTextBox.ContextMenuStrip = contextMenuStrip1;
            richTextBox.Location = new Point(0, 58);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(800, 363);
            richTextBox.TabIndex = 4;
            richTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Notepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem textColorToolStripMenuItem;
        private ToolStripMenuItem vievToolStripMenuItem;
        private ToolStripMenuItem themeDarkwhiteToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maximizeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtNew;
        private ToolStripButton toolStripButtOpen;
        private ToolStripButton toolStripButtSave;
        private ToolStripButton toolStripButtCut;
        private ToolStripButton toolStripButtCopy;
        private ToolStripButton toolStripButtPaste;
        private ToolStripButton toolStripButtFont;
        private ToolStripButton toolStripButtColor;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuCopy;
        private ToolStripMenuItem cutToolStripMenuCut;
        private ToolStripMenuItem pasteToolStripMenuPaste;
        private ToolStripMenuItem clearToolStripMenuClear;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private RichTextBox richTextBox;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem deselectAllToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
    }
}