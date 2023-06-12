using System;

namespace SV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "((((()))))";

            char openingBracket = '(';
            char closeBracket = ')';

            int closeBracketCount = 0;
            int openingBracketCount = 0;

            bool stringCorrect = true;

            int maximumDepth = 0;

            while (stringCorrect == true)
            {
                int templateDepth = 0;

                if (userInput[0] == closeBracket)
                    stringCorrect = false;

                if (userInput[userInput.Length - 1] == openingBracket)
                    stringCorrect = false;

                for (int i = 0; i < userInput.Length; i++)
                {
                    Console.WriteLine(userInput[i]);

                    if (userInput[i] == openingBracket)
                    {
                        templateDepth++;
                        openingBracketCount++;

                        if (templateDepth > maximumDepth)
                        {
                            maximumDepth = templateDepth;
                        }
                    }
                    else if (userInput[i] == closeBracket && closeBracketCount < openingBracketCount && templateDepth > 0)
                    {
                        templateDepth--;
                        closeBracketCount++;
                    }
                    else
                    {
                        stringCorrect = false;
                    }
                }

                if (stringCorrect == true && closeBracketCount == openingBracketCount && templateDepth == 0)
                {
                    Console.WriteLine($"{userInput} - строка корректна \n" +
                                      $"{maximumDepth} - максимальная глубина");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Строка не корректна, попробуйте в следующий раз");
                    Console.ReadKey();
                }
            }
        }
    }
}
