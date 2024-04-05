using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        string[] array1=new string[5]{"sanjay","mani","suresh","venakat","sanjay"};
        for(int i=0;i<=array1.Length-1;i++)
        {
            Console.Write(array1[i] +" ");
        }
        Console.WriteLine();
        Console.WriteLine("Enter a name to search");
        string name=Console.ReadLine();
        bool flag1=true;
        for(int i=0;i<array1.Length;i++)
        {
            if(array1[i]==name)
            {
                Console.WriteLine("The name is present in array: " + name +" and index value is:  "+ i);
                flag1=false;
            }
        }
        if(flag1)
            {
                Console.WriteLine("The name is not present in array: " +name);
            }
        bool flag=true;
        foreach(string s in array1)
        {
            if(s==name)
            {
                flag=false;
                Console.WriteLine("The name is present in array using foreach loop"+ name);
            }
        }
        if(flag)
        {
                Console.WriteLine("the name is not presnet in foreach loop");
        }
       
    }
}
