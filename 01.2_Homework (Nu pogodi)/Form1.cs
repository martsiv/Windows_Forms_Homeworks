using System;
using System.Windows.Forms;

namespace _01._2_Homework__Nu_pogodi_
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int level = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateEgg()
        {
            Random random = new Random();
            egg = new PictureBox();
            egg.Image = Properties.Resources.Egg;
            egg.SizeMode = PictureBoxSizeMode.StretchImage;
            egg.Size = new Size(65, 46);
            egg.Location = new Point(random.Next(this.ClientSize.Width - egg.Width), 0);
            this.Controls.Add(egg);
        }
        private void MoveEgg()
        {
            egg.Top += 40;
            if (egg.Bounds.IntersectsWith(basket.Bounds))
            {
                score++;
                int newLevel = score / 10;
                if (level != newLevel)
                {
                    timer1.Interval -= timer1.Interval * 10 / 100;
                    level++;
                }
                ScoreLabel.Text = "Score: " + score.ToString();
                this.Controls.Remove(egg);
                CreateEgg();
            }
            else if (egg.Top >= this.ClientSize.Height)
            {
                GameOver();
            }
        }
        private void GameOver()
        {
            timer1.Enabled = false;
            MessageBox.Show("Game Over! Your score is " + score.ToString());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveEgg();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && 0 < basket.Location.X)
            {
                basket.Left -= 20;
            }
            else if (e.KeyCode == Keys.Right && basket.Location.X + basket.Width < this.Width)
            {
                basket.Left += 20;
            }
        }
    }
}