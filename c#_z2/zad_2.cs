namespace C_tasks
{
    public static class zad_2
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var invalidChars = word.Where(word => !char.IsLower(word));
            bool isValid = true;
            foreach (char character in invalidChars)
            {
                if (character < 'a' || character > 'z')
                {
                    Console.Write(character);
                    isValid = false;
                }
            }
            if (isValid)
            {
                ReverbWord(word);
            }
        }
        private static void ReverbWord(string word)
        {
            if (word.Length % 2 == 0)
            {
                Console.WriteLine($"{perevorot(word[..(word.Length / 2)]) + perevorot(word.Substring(word.Length / 2))}");
            }
            else
            {
                Console.WriteLine($"{perevorot(word) + word}");
            }


            static string perevorot(string word)
            {
                string wordWithPerevorot = "";
                foreach (var character in word)
                {
                    wordWithPerevorot = character + wordWithPerevorot;
                }
                return wordWithPerevorot;
            }
        }
    }
}
