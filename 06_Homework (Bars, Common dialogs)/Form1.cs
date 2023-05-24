namespace _06_Lesson__Bars__Common_dialogs_
{
    public partial class Form1 : Form
    {
        private string? filename = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void newDocument_Click(object sender, EventArgs e)
        {
            if (!IsTextSaved())
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            richTextBox.Clear();
            filename = null;
        }
        private bool IsTextSaved()
        {
            if (filename == null) // Якщо змінна filename має значення null, це означає, що немає активного відкритого файлу
            {
                return string.IsNullOrEmpty(richTextBox.Text); // Перевіряємо, чи текстове поле пусте або не містить тексту
            }
            if (Path.GetExtension(filename) == ".txt")
            {
                // Якщо файл має розширення .txt, порівнюємо текст з richTextBox.Text
                return richTextBox.Text == File.ReadAllText(filename);
            }
            else if (Path.GetExtension(filename) == ".rtf")
            {
                // Якщо файл має розширення .rtf, порівнюємо RTF-представлення з вмістом файлу
                using (RichTextBox tempRichTextBox = new RichTextBox())
                {
                    tempRichTextBox.LoadFile(filename, RichTextBoxStreamType.RichText);
                    string fileRtf = tempRichTextBox.Rtf;

                    return richTextBox.Rtf == fileRtf;
                }
                //Тут простіший метод порівняння не працює, бо з файлу rtf завжди довший на 1 символ, але його не видно
            }

            // Якщо розширення файлу не відповідає .txt або .rtf, вважаємо, що текст не збережений
            return false;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsTextSaved())
            {
                DialogResult result = MessageBox.Show("Do you want to save the unsaved text?", "Save Changes", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = dialog.FileName;
                filename = selectedFile;
                string fileExtension = Path.GetExtension(selectedFile).ToLower();

                if (fileExtension == ".txt")
                {
                    richTextBox.Text = File.ReadAllText(selectedFile);
                }
                else if (fileExtension == ".rtf")
                {
                    richTextBox.LoadFile(selectedFile, RichTextBoxStreamType.RichText);
                }

                MessageBox.Show("File opened successfully.");
            }
        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filename))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                string fileExtension = Path.GetExtension(filename).ToLower();

                if (fileExtension == ".txt")
                {
                    File.WriteAllText(filename, richTextBox.Text);
                }
                else if (fileExtension == ".rtf")
                {
                    richTextBox.SaveFile(filename, RichTextBoxStreamType.RichText);
                }

                MessageBox.Show("Text saved successfully.");
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            dialog.Title = "Save Text";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                filename = filePath;
                string fileExtension = Path.GetExtension(filePath).ToLower();

                if (fileExtension == ".txt")
                {
                    File.WriteAllText(filePath, richTextBox.Text);
                }
                else if (fileExtension == ".rtf")
                {
                    richTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }

                MessageBox.Show("Text saved successfully.");
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Undo();
        private void redoToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Redo();
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Cut();
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Copy();
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Paste();
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.Clear();
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.SelectAll();
        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e) => richTextBox.DeselectAll();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                richTextBox.SelectionFont = dialog.Font;
        }
        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                richTextBox.SelectionColor = dialog.Color;
        }
        private void themeDarkwhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (themeDarkwhiteToolStripMenuItem.Checked)
            {
                menuStrip1.BackColor = Color.Black;
                menuStrip1.ForeColor = SystemColors.Control;

                //toolStrip1.BackColor = Color.Black;
                //toolStrip1.ForeColor = SystemColors.Control;

                statusStrip1.BackColor = Color.Black;
                statusStrip1.ForeColor = SystemColors.Control;

                contextMenuStrip1.BackColor = Color.Black;
                contextMenuStrip1.ForeColor = SystemColors.Control;

                richTextBox.BackColor = Color.Black;
                richTextBox.ForeColor = SystemColors.Control;

                this.BackColor = Color.Black;
                this.ForeColor = SystemColors.Control;
            }
            else
            {
                menuStrip1.BackColor = SystemColors.Control;
                menuStrip1.ForeColor = Color.Black;

                //toolStrip1.BackColor = SystemColors.Control;
                //toolStrip1.ForeColor = Color.Black;

                statusStrip1.BackColor = SystemColors.Control;
                statusStrip1.ForeColor = Color.Black;

                contextMenuStrip1.BackColor = SystemColors.Control;
                contextMenuStrip1.ForeColor = Color.Black;

                richTextBox.BackColor = SystemColors.Control;
                richTextBox.ForeColor = Color.Black;

                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.Black;
            }
        }
        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Maximized;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Text editor 1.0");

    }
}