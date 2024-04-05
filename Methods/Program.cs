using System;
using System.Text;
namespace Methods;
class Program
{
    public static void Main(string[] args)
    {
    
        string str;
        do
        {
        Console.WriteLine("Enter  number:");
        int input1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter  2 number:");
        int input2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Select Mathematical Operation: + - * /");
        char action=char.Parse(Console.ReadLine());
        switch(action)
        {
            case '+':
            {
                add(input1,input2);
                break;
            }
            case '-':
            {
                sub(input1,input2);
                break;
            }
            case '*':
            {
                mul(input1,input2);
                break;
            }
            case '/':
            {
                div(input1,input2);
                break;
            }
        }
        
            Console.WriteLine("Repeat yes or no");
            string str1=Console.ReadLine();
            str=str1;
            if(str=="no" || str=="yes")
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("give correct");
            }
        }while(str=="yes");



    }
    static void add(int a,int b)
    {
        int c=a+b;
        Console.WriteLine(c);
    }
     static void sub(int a,int b)
    {
        int c=a-b;
        Console.WriteLine(c);
    }
     static void mul(int a,int b)
    {
        int c=a*b;
        Console.WriteLine(c);
    }
     static void div(int a,int b)
    {
        int c=a/b;
        Console.WriteLine(c);
    }
}
