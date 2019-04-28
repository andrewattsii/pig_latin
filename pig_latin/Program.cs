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
            string pigLatin1 = "";


            
            

                foreach (string word in words)
                {
                    if (vowels.Contains(word[0]))
                    {
                        pigLatin += word + "way ";
                    }
                    else
                    {
                        pigLatin1 = word;
                        foreach (char c in pigLatin1)
                        {

                            if (!vowels.Contains(c))
                            {
                                pigLatin1 = word.Substring(1, word.Length -1) + word[1];
                            }
                            else
                            {
                                pigLatin1 = pigLatin1 + "ay";
                                break;
                            }

                        }
                        
                    }

                    Console.WriteLine($"{pigLatin} {pigLatin1}");
                    
                }
               

            
            
        }
    }
}