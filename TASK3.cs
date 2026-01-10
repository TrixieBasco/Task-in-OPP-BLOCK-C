using System;

class Task3
{
    static void Main()
    {
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };

        Console.Write("Enter a number to search: ");
        int searchNumber = int.Parse(Console.ReadLine());

        bool isFound = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNumber)
            {
                Console.WriteLine("Number found at position " + i + "!");
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Number not found in the list.");
        }
    }
}
