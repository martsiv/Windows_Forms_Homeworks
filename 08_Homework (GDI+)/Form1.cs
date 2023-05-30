using System.Collections.Generic;

namespace _08_Lesson__GDI__
{
    public partial class Form1 : Form
    {
        private List<IDrawable> shapes = new List<IDrawable>();
        private enum DrawingTools { Pencil, Point, Line, Rectangle, Ellipse, Curve };
        private IDrawable currentTool;

        private Color colorBrush = Color.Black;
        float sizeBrush = 2f;
        private Bitmap bitmap = null;
        private bool isDrawing = false;
        public Form1()
        {
            InitializeComponent();

            //bitmap
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;

            foreach (var item in Enum.GetValues<DrawingTools>())
            {
                toolStripComboBoxInstruments.Items.Add(item);
            }
            toolStripComboBoxInstruments.SelectedIndex = 0;
            currentTool = new MyPencil(colorBrush, sizeBrush);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            foreach (IDrawable shape in shapes)
                shape.Draw(graphics);
            graphics.Dispose();
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            DrawingTools tool = (DrawingTools)toolStripComboBoxInstruments.SelectedItem;
            switch (tool)
            {
                case DrawingTools.Pencil:
                    currentTool = new MyPencil(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Point:
                    currentTool = new MyPoint(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Line:
                    currentTool = new MyLine(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Rectangle:
                    currentTool = new MyRectangle(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Ellipse:
                    currentTool = new MyEllipse(colorBrush, sizeBrush);
                    break;
                case DrawingTools.Curve:
                    currentTool = new MyCurve(colorBrush, sizeBrush);
                    break;
                default:
                    break;
            }

            if (currentTool != null)
            {
                currentTool.StartDrawing(e.Location);
                shapes.Add(currentTool as IDrawable);
                pictureBox1.Invalidate();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.ContinueDrawing(e.Location);
                currentTool = null;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.ContinueDrawing(e.Location);
                pictureBox1.Invalidate();
            }
        }

        private void toolStripButtonColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                colorBrush = dlg.Color;
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            sizeBrush = (float)trackBarSize.Value;
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                var lastItem = shapes[shapes.Count - 1];
                shapes.Remove(lastItem);
                pictureBox1.Invalidate();
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Image not saved.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string tempFilePath = Path.GetTempFileName(); // Створення тимчасового файлу

                    pictureBox1.Image.Save(tempFilePath);

                    File.Delete(saveFileDialog.FileName); // Видалення початкового файлу
                    File.Move(tempFilePath, saveFileDialog.FileName); // Перейменування тимчасового файлу на бажане ім'я

                    MessageBox.Show("Image was saved.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save error image: " + ex.Message);
                }
            }
        }

        private void toolStripButtonOpenImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All Files|*.*";
                openFileDialog.Title = "Open image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        bitmap = new Bitmap(filePath);
                        pictureBox1.Image = bitmap;
                        shapes.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error open image: " + ex.Message);
                    }
                }
            }
        }
    }
}