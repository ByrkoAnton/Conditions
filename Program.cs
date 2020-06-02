using System;
using System.Dynamic;
using System.Transactions;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Conditions01();
        }
        static void Conditions01()
        {
            Console.WriteLine("The dictionary includes these words \"" +
                "sunny, rain, thunderstorm, snow, hail, cold, windy, fog, ice, storm\"" +
                "enter word wich you want to translate");

            string word = Console.ReadLine();
            word = word.ToLower();

            switch (word)
            {
                case "sunny":
                    Console.WriteLine("солнечно");
                    break;
                case "rain":
                    Console.WriteLine("дождь");
                    break;
                case "thunderstorm":
                    Console.WriteLine("гроза");
                    break;
                case "snow":
                    Console.WriteLine("снег");
                    break;
                case "hail":
                    Console.WriteLine("град");
                    break;
                case "cold":
                    Console.WriteLine("холодно");
                    break;
                case "windy":
                    Console.WriteLine("ветренно");
                    break;
                case "fog":
                    Console.WriteLine("туман");
                    break;
                case "ice":
                    Console.WriteLine("лед");
                    break;
                case "storm":
                    Console.WriteLine("шторм");
                    break;

                default:
                    Console.WriteLine("этого слова нет в словаре");
                    break;
            }
        }
        static void Conditions02()
        {
            double operand1, operand2, result;
            string sign;
            Console.Write("enter operand 1 ");
            operand1 = double.Parse(Console.ReadLine());

            Console.Write("enter sign ");
            sign = Console.ReadLine();

            Console.WriteLine("enter operand 2 ");
            operand2 = double.Parse(Console.ReadLine());

            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine($"{operand1} + {operand2} = {result}");
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine($"{operand1} - {operand2} = {result}");
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine($"{operand1} * {operand2} = {result}");
                    break;

                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                        Console.WriteLine($"{operand1} / {operand2} = {result}");
                    }
                    else
                        Console.WriteLine("ERROR division by zero");
                    break;
                default:
                    Console.WriteLine("wrong sign");
                    break;
            }
        }
        static void Conditions03()
        {
            Console.WriteLine("enter number from 0 to 100");
            double num = double.Parse(Console.ReadLine());

            if (num>=0 && num<=14)
                Console.WriteLine("from 0 to 14");

            else if (num >= 15 && num <= 35)
                Console.WriteLine("from 14 to 35");

            else if (num >= 36 && num <= 50)
                Console.WriteLine("from 36 to 50");

            else if (num >= 50 && num <= 100)
                Console.WriteLine("from 50 to 100");

            else
                Console.WriteLine("number is not from 0 to 100");
        }
    }
}
