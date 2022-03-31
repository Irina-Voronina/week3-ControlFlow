using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести результат его экзамена
            //результат экзамена это одна буква от А до F
            //A - Outstanding
            //B - Superior
            //C - Good
            //D - Satisfactory
            //E - Low Pass
            //F - Failure
            //в работе приложения используется switch()

            Console.WriteLine("Enter your exam resutl");
            char userInput = Convert.ToChar(Console.ReadLine().ToUpper());

            switch(userInput)
            {
                case 'A':
                    Console.WriteLine("Outstanding!");
                    break;
                case 'B':
                    Console.WriteLine("Superior!");
                    break;
                case 'C':
                    Console.WriteLine("Good!");
                    break;
                case 'D':
                    Console.WriteLine("Satisfactory!");
                    break;
                case 'E':
                    Console.WriteLine("Low Pass!");
                    break;
                case 'F':
                    Console.WriteLine("Failure!");
                    break;
                default:
                    Console.WriteLine($"{userInput} Invalid result!");
                    break;

            }

            Console.WriteLine("Have a nice day.");
        }
    }
}
