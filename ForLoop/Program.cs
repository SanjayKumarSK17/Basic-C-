using System;
namespace ForLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first Number:");
            int num1=int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number:");
            int num2=int.Parse(Console.ReadLine());
            int sum=0;
            for(int i=num1;i<=num2;i++)
            {
                sum=sum + i*i;
            }
            Console.Write("Sum Of Square Numbers:"+ sum);
        }
    }
}
