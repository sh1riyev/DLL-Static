using System;
namespace Static_Test_Class.Services
{
    public static class CalculatorService
    {
        public static void Calculation()
        {
            int number;
            int number2;
            Console.WriteLine("Enter first digit:");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second digit:");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose method:\n1.+\n2.-\n3./\n4.*");

            int CaseSwtich = int.Parse(Console.ReadLine());

            switch (CaseSwtich)
            {
                case 1: Console.WriteLine($"Result:\n{number+number2}");
                    break;

                case 2:
                    Console.WriteLine($"Result:\n{number - number2}");
                    break;
                case 3:
                    if(number2 ==0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        break;
                    }
                    Console.WriteLine($"Result:\n{number / number2}");
                    break;

                case 4:
                    Console.WriteLine($"Result:\n{number * number2}");
                    break;

            }
        }
    }
}

