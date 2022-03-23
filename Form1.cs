using System.Text;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Setup();
            Running();
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

        public  void Display()
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
        public async void Running()
        {
            while (true)
            {
                var temp = 0;
                Display();
                foreach(char c in WordToGuess)
                    if(!Attempts.Contains(c))
                        temp++;
                WrongGuesses = temp;
                await Task.Delay(50);
            }

        }

    }
}