using System;

class Program
{
    static void Main(string[] args)
    {
        char continueChoice = 'Y';

        while (continueChoice == 'Y' || continueChoice == 'y')
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value 1: ");
            double value1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Value 2: ");
            double value2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            string symbol = "";

            switch (choice)
            {
                case 1:
                    result = Add(value1, value2);
                    symbol = "+";
                    break;

                case 2:
                    result = Subtract(value1, value2);
                    symbol = "-";
                    break;

                case 3:
                    result = Multiply(value1, value2);
                    symbol = "*";
                    break;

                case 4:
                    if (value2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        break;
                    }
                    result = Divide(value1, value2);
                    symbol = "/";
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (choice >= 1 && choice <= 4 && !(choice == 4 && value2 == 0))
            {
                Console.WriteLine($"{value1} {symbol} {value2} = {result}");
            }

            Console.Write("Do you want to continue again (Y/N)? ");
            continueChoice = Console.ReadLine()[0];
            Console.WriteLine();
        }
    }

    // Separate methods for each operation
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
}
