using System.Collections.Generic;

namespace C_tasks
{
    public static class zad_3
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var invalidChars = word.Where(word => !char.IsLower(word));
            bool isValid = true;
            foreach (char character in word)
            {
                if (character < 'a' || character > 'z')
                {
                    Console.Write(character);
                    isValid = false;
                }
            }
            if (isValid)
            {
                Dictionary<char, int> freq = new Dictionary<char, int>();
                
                if (word.Length % 2 == 0)
                {
                    word = perevorot(word[..(word.Length / 2)]) + perevorot(word.Substring(word.Length / 2));
                }
                else
                {
                    word = perevorot(word) + word;
                }
                Console.WriteLine(word);

                foreach (char character in word)
                {
                    if (freq.ContainsKey(character))
                        freq[character]++;
                    else
                        freq[character] = 1;
                }
                foreach (KeyValuePair<char, int> kvp in freq)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
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
