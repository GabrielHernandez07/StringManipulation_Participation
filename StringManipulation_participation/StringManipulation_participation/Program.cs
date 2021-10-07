using System;

namespace StringManipulation_participation
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(quote);
            Console.WriteLine("What word will you like to look for in the above sentence.");
            string word = Console.ReadLine();
            if (quote.Contains(word)==false)
            {
                Console.WriteLine($"Sorry, I could not find your word {word}.");
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = word[i];
                    string reversedword;
                    
                    // couldn't figure out how to reverse word sorry
                }
            }
            
            Console.WriteLine("What word would you like to change it to");
            string changedWord = Console.ReadLine();

            quote = quote.Replace(word, changedWord);

            Console.WriteLine(quote);
        }
    }
}
