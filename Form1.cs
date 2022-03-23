using System.Text;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Setup();
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
            string[] words = { "Magic", "Banana", "Breach" };
            Random idx = new Random();
            WordToGuess = words[idx.Next(words.Length)].ToLower();
        }

        public static void Display()
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

        }


    }
}