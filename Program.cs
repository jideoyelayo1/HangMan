using System.Text;

namespace HangMan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
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
            string[] words = { "Magic", "Banana","Breach" };
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