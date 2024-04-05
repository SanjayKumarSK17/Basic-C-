using System;
namespace DoWhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        String option = string.Empty;
        do
        {
            Console.Write("Enter the Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("Repeat the process with another number say Yes or No: ");
            option = Console.ReadLine();
            if (option=="yes" || option=="no")
            {
                continue;
            }
            if(option!="yes" || option!="no")
            {
                Console.WriteLine("Invalid Input , Enter yes or no");
                option = Console.ReadLine();
            }
        } while (option == "yes");
    }
}
