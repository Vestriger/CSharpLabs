using System;

namespace lab7
{
    internal class Program
    {
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("With fractions you can do the following:");
            Console.WriteLine("1. Get a sum.");
            Console.WriteLine("2. Get a division.");
            Console.WriteLine("3. Get a product.");
            Console.WriteLine("4. Get a difference.");
            Console.WriteLine("5. Get a fraction, which is bigger or less.");
            Console.WriteLine("6. Check if the fractions are equal.");
            Console.WriteLine("7. Exit.\n");
        }
		
        static void Main()
        {
            RationalNumber a, b;

            Console.WriteLine("Enter two numbers for each fraction: ");
            var forNum = int.Parse(Console.ReadLine() ?? string.Empty);
            var forDenum = int.Parse(Console.ReadLine() ?? string.Empty);
            a = new RationalNumber(forNum, forDenum);
            
            Console.WriteLine("Enter two numbers for the second fraction: ");
            forNum = int.Parse(Console.ReadLine() ?? string.Empty);
            forDenum = int.Parse(Console.ReadLine() ?? string.Empty);
            b = new RationalNumber(forNum, forDenum); 
            
            int menu;
            do
            {
                ShowMenu();
                menu = int.Parse(Console.ReadLine() ?? string.Empty);
                switch (menu)
                {
                    case 1:
                    {
                        Console.WriteLine($"The result is: {a + b}");
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine($"The result is: {a / b}");
                        break;
                    }

                    case 3:
                    {
                        Console.WriteLine($"The result is: {a * b}");
                        break;
                    }

                    case 4:
                    {
                        Console.WriteLine($"The result is: {a - b}");
                        break;
                    }

                    case 5:
                    {
                        if (a > b)
                            Console.WriteLine($"The first one ({a}) is bigger.");
                        else if (a < b)
                            Console.WriteLine($"The second one ({b}) is bigger.");
                        else
                            Console.WriteLine("Both fractions are equal.");
                        break;
                    }

                    case 6:
                    {
                        Console.WriteLine(a.Equals(b));
                        break;
                    }
                    
                    case 7:
                        break;

                    default:
                    {
                        Console.WriteLine("Enter correct number!");
                        break;
                    }
                }
                
                Console.ReadKey();
            } while (menu != 7);
        }
    }
}