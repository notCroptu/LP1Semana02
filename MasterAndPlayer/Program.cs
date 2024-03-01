using System;

namespace MasterAndPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number Master insert number: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 100)
            {
                Console.Write("Invalid number!");
            }
            else
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine();
                }

                while (true)
                {

                    int i = -1;

                    while (true)
                    {
                    Console.Write("Player insert number: ");
                    i = int.Parse(Console.ReadLine());

                    if (i < 0 || i > 100)
                    {
                        Console.WriteLine("Invalid number! Try again!");
                    }
                    else
                    {
                        break;
                    }
                    }

                    if (i < n)
                    {
                        Console.WriteLine($"The correct number is higher than {i}");
                    }
                    else if (i > n)
                    {
                        Console.WriteLine($"The correct number is lower than {i}");
                    }
                    else
                    {
                        Console.WriteLine("Player wins!");
                        break;
                    }
                }
            }
        }
    }
}
