namespace C_tasks
{
    public static class zad_1
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                string word = Console.ReadLine();

                if(word != null && word != "") 
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
