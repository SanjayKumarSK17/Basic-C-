	using System;
	namespace TypeConversion
	{
	    class Program
	    {
	        public static void Main(string[] args)
	        {
	            Console.WriteLine("Enter a number 1: ");
                int num1=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number 2: ");
                int num2=int.Parse(Console.ReadLine());
                Console.WriteLine(num1 + num2);
                Console.WriteLine("Enter Decimal number: ");
                double num3=int.Parse(Console.ReadLine());
                Console.WriteLine(num1+num2+num3);
	        }
	    }
}
