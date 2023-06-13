using System;
using System.Diagnostics;

namespace SV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            char openingBracket = '(';
            char closeBracket = ')';

            bool stringCorrect = true;

            int maximumDepth = 0;

            while (stringCorrect == true)
            {
                int templateDepth = 0;

                Console.WriteLine("Введите выражение :");
                userInput = Console.ReadLine();

                for (int i = 0; i < userInput.Length; i++)
                {
                    if (userInput[i] != closeBracket && userInput[i] != openingBracket)
                    {
                        Console.WriteLine("Некоректная строка, попробуйте еще раз...");
                        Console.ReadKey();
                        return;
                    }
                }

                for (int i = 0; i < userInput.Length; i++)
                {
                    Console.WriteLine(userInput[i]);

                    if (userInput[i] == openingBracket)
                    {
                        ++templateDepth;

                        if (templateDepth > maximumDepth)
                        {
                            maximumDepth = templateDepth;
                        }
                    }
                    else if (userInput[i] == closeBracket && templateDepth > 0)
                    {
                        --templateDepth;
                    }
                    else
                    {
                        stringCorrect = false;
                    }
                }

                if (stringCorrect == true && templateDepth == 0)
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

                maximumDepth = 0;
            }
        }
    }
}
