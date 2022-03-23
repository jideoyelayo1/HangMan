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
        public static int TotalAttemptsGiven = 1;
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
        public void StartGame()
        {
            InitializeComponent();
            Setup();
            Running();
        }

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
    }
}