using System;

namespace pig_latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  the pig latin translator !\n \nEnter a line to be translated:");
            string sentence = Console.ReadLine();
            sentence.ToLower();
            string lowerCase = sentence.ToLower();


            string[] words = lowerCase.Split();
            string vowels = "a" + "e" + "i" + "u";

            string pigLatin = "";
            foreach (string word in words)
            {
                if (vowels.Contains(word[0]))
                {
                    pigLatin += word + "way ";
                    Console.WriteLine(pigLatin);
                }
                int counter = 0;
                string pigLatin1 = word;
                foreach (char c in pigLatin1)
                {
                    if (!vowels.Contains(c))
                    {
                        counter++;
                    }
                    else
                        break;

                    pigLatin1 = word.Substring(counter) + word.Substring(0, counter) + "ay";

                    Console.Write($" {pigLatin1}");
                }
            }
        }    
        
    }
}