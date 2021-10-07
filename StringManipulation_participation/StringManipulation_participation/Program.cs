using System;

namespace StringManipulation_participation
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(quote);
            Console.WriteLine("What word will you like to look for in the above sentence. >>");
            string word = Console.ReadLine();
            if (quote.Contains(word)==false)
            {
                Console.WriteLine($"Sorry, I could not find your word {word}.");
                string reversedword = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {

                    reversedword += word[i];
                    
                }
                Console.WriteLine(reversedword);
            }
            else
            {
                Console.WriteLine("What word would you like to change it to. >>");
                string changedWord = Console.ReadLine();

                string newquote = quote.Replace(word, changedWord);
                Console.WriteLine(newquote);
            }

        }
    }
}
