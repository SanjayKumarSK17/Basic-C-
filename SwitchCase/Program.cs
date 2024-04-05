using System;
namespace SwitchCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the First Number:");
            double firstnumber=double.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            double secnumber=double.Parse(Console.ReadLine());
            Console.Write("Enter the Action to Perform:");
            char action=char.Parse(Console.ReadLine());
            switch(action)
            {
                case '+':
                {
                    Console.WriteLine("Addition:" + (firstnumber+secnumber));
                    break;
                }
                case '-':
                {
                    Console.WriteLine("Subtraction:" + (firstnumber-secnumber));
                    break;
                }
                case '*':
                {
                    Console.WriteLine("Multiplication:" + (firstnumber+secnumber));
                    break;
                }
                case '/':
                {
                    Console.WriteLine("Division:" + (firstnumber/secnumber));
                    break;
                }
                case '%':
                {
                    Console.WriteLine("Modulo Division:" + (firstnumber+secnumber));
                    break;
                }
                
            }
        }
    }
}