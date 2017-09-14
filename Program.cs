using System;

namespace string_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            Console.WriteLine("Give me a string and I will fuck it up, kthx:");
            var input = Console.ReadLine();

            Console.WriteLine(LetterChanges(input));
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();

        }

        public static string LetterChanges(string str)
        {
            var newString = "";
            var newLetter = ' ';

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    if (str[i] == 'z')
                    {
                        newLetter = 'a';
                    } else if (str[0] == 'Z')
                    {
                        newLetter = 'A';
                    } else {
                        newLetter = (char)(((int)str[i]) +1);
                    }
                    newString += newLetter;
                } else {
                    newString += str[i];
                }
            }

            var finalString = "";
            for (int i = 0; i < newString.Length; i++)
            {
                if (newString[i] == 'a' || newString[i] == 'e' || newString[i] == 'i' || newString[i] == 'o' || newString[i] == 'u')
                {
                    finalString += char.ToUpper(newString[i]);
                } else 
                {
                    finalString += newString[i];
                }
            }

            return finalString;
        }
    }
}
