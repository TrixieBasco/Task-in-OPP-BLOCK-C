using System;

class Program
{
    static void Main(string[] args)
    {
        char choice = 'Y';

        while (choice == 'Y' || choice == 'y')
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            int operation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Value 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;

                case 2:
                    result = Subtract(num1, num2);
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;

                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        result = Divide(num1, num2);
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.Write("Do you want to continue again (Y/N)? ");
            choice = Console.ReadLine()[0];
            Console.WriteLine();
        }
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }
}
