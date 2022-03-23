using System.Text;

namespace HangMan
{
    public partial class HangMan : Form
    {
        public HangMan()
        {
            
            StartGame();


        }
        public static string ReplaceAtIndex(string text, int index, char c)
        {
            var stringBuilder = new StringBuilder(text);
            stringBuilder[index] = c;
            return stringBuilder.ToString();
        }

        public static List<char> Attempts = new List<char>();
        public static string WordToGuess = "";

        public static void Setup()
        {
            string[] words = Enumerable.ToArray(File.ReadLines("PossibleWords.txt"));//{ "Magic", "Banana", "Breach" };
            words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Random idx = new Random();
            WordToGuess = words[idx.Next(words.Length)].ToLower();
        }
        public void Display()
        {
            string output = "";
            var idx = 0;
            foreach (char c in WordToGuess)
            {
                if (Attempts.Contains(c) && WordToGuess[idx] == c)
                    output += c;
                else
                    output += "-";
                idx++;
            }
            DisplayText.Text = output;

        }
        public static int WrongGuesses = 0;
        public static int TotalAttemptsGiven = 10;
        public async void Running()
        {
            while (DisplayText.Text.Contains('-') && TotalAttemptsGiven > WrongGuesses)
            {
                var temp = 0;
                Display();
                foreach(char c in Attempts)
                    if(!WordToGuess.Contains(c))
                        temp++;
                WrongGuesses = temp;
                FailedAttButton.Text = "Wrong Guesses: " + Convert.ToString(WrongGuesses);
                await Task.Delay(50);
            }
            await Task.Delay(1000);
            if (TotalAttemptsGiven > WrongGuesses)
                DisplayText.Text = "Well Done\n";
            else
                DisplayText.Text = "Better Luck Next Time\n";
            DisplayText.Text += "The word was: " + WordToGuess;
            await Task.Delay(7000);
            StartGame();

        }
        public void UpdateHangManImage()
        {
            var temp = WrongGuesses + 1;
            var ImgName = "guess" + Convert.ToString(temp) + ".png";

            Image b = Image.FromFile(ImgName);
            HangManImages.Image = b;

        }
        public void StartGame()
        {
            InitializeComponent();
            Setup();
            Running();
            UpdateHangManImage();
        }

        #region Buttons
        private void aButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('a');
            if(WordToGuess.Contains('a'))
                aButton.BackColor = Color.Green;
            else
                aButton.BackColor = Color.Red;

        }

        private void qButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('q');
            if (WordToGuess.Contains('q'))
                qButton.BackColor = Color.Green;
            else
                qButton.BackColor = Color.Red;
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('s');
            if (WordToGuess.Contains('s'))
                sButton.BackColor = Color.Green;
            else
                sButton.BackColor = Color.Red;
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('d');
            if (WordToGuess.Contains('d'))
                dButton.BackColor = Color.Green;
            else
                dButton.BackColor = Color.Red;
        }

        private void fButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('f');
            if (WordToGuess.Contains('f'))
                fButton.BackColor = Color.Green;
            else
                fButton.BackColor = Color.Red;
        }

        private void gButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('g');
            if (WordToGuess.Contains('g'))
                gButton.BackColor = Color.Green;
            else
                gButton.BackColor = Color.Red;
        }

        private void hButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('h');
            if (WordToGuess.Contains('h'))
                hButton.BackColor = Color.Green;
            else
                hButton.BackColor = Color.Red;
        }

        private void jButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('j');
            if (WordToGuess.Contains('j'))
                jButton.BackColor = Color.Green;
            else
                jButton.BackColor = Color.Red;
        }

        private void kButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('k');
            if (WordToGuess.Contains('k'))
                kButton.BackColor = Color.Green;
            else
                kButton.BackColor = Color.Red;
        }

        private void lButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('l');
            if (WordToGuess.Contains('l'))
                lButton.BackColor = Color.Green;
            else
                lButton.BackColor = Color.Red;
        }

        private void wButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('w');
            if (WordToGuess.Contains('w'))
                wButton.BackColor = Color.Green;
            else
                wButton.BackColor = Color.Red;
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('e');
            if (WordToGuess.Contains('e'))
                eButton.BackColor = Color.Green;
            else
                eButton.BackColor = Color.Red;
        }

        private void rButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('r');
            if (WordToGuess.Contains('r'))
                rButton.BackColor = Color.Green;
            else
                rButton.BackColor = Color.Red;
        }

        private void tButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('t');
            if (WordToGuess.Contains('t'))
                tButton.BackColor = Color.Green;
            else
                tButton.BackColor = Color.Red;
        }

        private void yButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('y');
            if (WordToGuess.Contains('y'))
                yButton.BackColor = Color.Green;
            else
                yButton.BackColor = Color.Red;
        }

        private void uButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('u');
            if (WordToGuess.Contains('u'))
                uButton.BackColor = Color.Green;
            else
                uButton.BackColor = Color.Red;
        }

        private void iButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('i');
            if (WordToGuess.Contains('i'))
                iButton.BackColor = Color.Green;
            else
                iButton.BackColor = Color.Red;
        }

        private void oButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('o');
            if (WordToGuess.Contains('o'))
                oButton.BackColor = Color.Green;
            else
                oButton.BackColor = Color.Red;
        }

        private void pButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('p');
            if (WordToGuess.Contains('p'))
                pButton.BackColor = Color.Green;
            else
                pButton.BackColor = Color.Red;
        }

        private void zButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('z');
            if (WordToGuess.Contains('z'))
                zButton.BackColor = Color.Green;
            else
                zButton.BackColor = Color.Red;
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('x');
            if (WordToGuess.Contains('x'))
                xButton.BackColor = Color.Green;
            else
                xButton.BackColor = Color.Red;
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('c');
            if (WordToGuess.Contains('c'))
                cButton.BackColor = Color.Green;
            else
                cButton.BackColor = Color.Red;
        }

        private void vButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('v');
            if (WordToGuess.Contains('v'))
                vButton.BackColor = Color.Green;
            else
                vButton.BackColor = Color.Red;
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('b');
            if (WordToGuess.Contains('b'))
                bButton.BackColor = Color.Green;
            else
                bButton.BackColor = Color.Red;
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('n');
            if (WordToGuess.Contains('n'))
                nButton.BackColor = Color.Green;
            else
                nButton.BackColor = Color.Red;
        }

        private void mButton_Click(object sender, EventArgs e)
        {
            Attempts.Add('m');
            if (WordToGuess.Contains('m'))
                mButton.BackColor = Color.Green;
            else
                mButton.BackColor = Color.Red;
        }

        #endregion

    }

}