using System;
namespace ReadAndWrite;
class Program
{
    public static void Main(string[] args)
    {
        //Getting inputs
        Console.Write("Enter Your Name:");
        string name=Console.ReadLine();
        Console.Write("Enter Father Name:");
        string fatherName=Console.ReadLine();
        //print results in 3types
        //1- concatenation
        Console.WriteLine(name + " "+fatherName);
        //2-Placeholder
        Console.WriteLine("{0} {1}", name , fatherName);
        Console.WriteLine("{0} {1}", fatherName , name);
        Console.WriteLine("{1} {0}", name , fatherName);
        //3-Interpolation
        Console.WriteLine($"{name} {fatherName}");
        Console.ReadKey();
    }
}

