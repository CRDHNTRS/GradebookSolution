using System;
using GradebookApp;

class Program
{
    static void Main()
    {
        var book = new Gradebook();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Gradebook Utility ===");
            Console.WriteLine("1. Add grade");
            Console.WriteLine("2. View summary");
            Console.WriteLine("3. Clear grades");
            Console.WriteLine("4. Exit");
            Console.Write("Select option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Enter grade (0–100): ");
                    if (double.TryParse(Console.ReadLine(), out double grade))
                    {
                        try
                        {
                            book.AddGrade(grade);
                            Console.WriteLine("Grade added successfully.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    break;

                case "2":
                    Console.WriteLine("\n--- Grade Summary ---");
                    Console.WriteLine($"Count   : {book.GetCount()}");
                    Console.WriteLine($"Average : {book.GetAverage():F2}");
                    Console.WriteLine($"Highest : {book.GetHighest():F2}");
                    Console.WriteLine($"Lowest  : {book.GetLowest():F2}");
                    break;

                case "3":
                    book.Clear();
                    Console.WriteLine("All grades cleared.");
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
