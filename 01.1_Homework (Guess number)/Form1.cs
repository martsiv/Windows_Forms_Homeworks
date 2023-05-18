namespace _01_Lesson__Intro_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void ClickButtonStart(object sender, EventArgs e)
        {
            PlayGame();
            this.Close();
        }
        private void PlayGame()
        {
            int leftRange = 0;
            int rightRange = 100;
            int guessNum = 0;
            int countRounds = 0;
            do
            {
                guessNum = GetNumber(leftRange, rightRange);    //Початок раунду, запитуємо чи число яке є середнім в діапазоні підходить
                var result = MessageBox.Show($"Your number is {guessNum}?",
                    "Correct?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                ++countRounds;                                  //Плюсуємо раунд
                if (result == DialogResult.No)          //Якщо не підходить, запитуємо чи воно більше
                {
                    var moreOrLess = MessageBox.Show("Is your number more than specified?",
                        "Is more?", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                    if (moreOrLess == DialogResult.Yes) //Відповідно до відповіді змінюємо діапазон пошуку
                        leftRange = guessNum + 1;
                    else
                        rightRange = guessNum - 1;
                }
                else if (result == DialogResult.Yes)    //Якщо число вгадали, виводимо інформацію про число і кількість раундів
                {
                    var repeatOrNo = MessageBox.Show($"Congratulations, the number {guessNum} has been guessed, the game is over in {countRounds} moves. Do you want to repeat?",
                        "Repeat?", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);   //Запитуємо чи бажає гравець спробувати ще
                    countRounds = 0;                //раунди обнуляємо
                    if (repeatOrNo == DialogResult.Yes)     //Якщо гравець обрав грати ще, відновлюємо діапазон чисел на початковий
                    {
                        leftRange = 0;
                        rightRange = 100;
                    }
                    else     //Якщо гравець бажає вийти, ставимо границі як не допустимі
                    {
                        leftRange = 100;
                        rightRange = 0;
                    }
                }
            } while (leftRange <= rightRange);  //продовжуємо доти, доки границі коректні (ліва не більше правої)
        }
        private int GetNumber(int leftRange, int rightRange) => (leftRange + rightRange) / 2;
    }
}