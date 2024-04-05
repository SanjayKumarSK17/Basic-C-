using System;
using System.Security.Cryptography;
namespace DateTimeAssign;
class Program
{
    public static void Main(string[] args)
    {
       

            DateTime date=new DateTime(2021,8,10,10,40,32);
            Console.WriteLine("DATE: "+date);
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Minute);
            Console.WriteLine(date.Second);
            Console.WriteLine();
            string date1=date.ToString("tt ss mm hh dd MM yyyy");
            Console.WriteLine("Output: " +date1);
            Console.WriteLine();
            DateTime newdate;
            Console.WriteLine("Enter a Date in this format: (yyyy/MM/dd hh:mm:ss tt)");
            bool temp=DateTime.TryParseExact(Console.ReadLine(), "yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out newdate);
            if(!temp)
            {
                Console.WriteLine("Invalid Format.");
            }
            else
            {
                Console.WriteLine(newdate.ToString("yyyy"));
                Console.WriteLine(newdate.ToString("MM"));
                Console.WriteLine(newdate.ToString("dd"));
            }
           
           int size=int.Parse(Console.ReadLine());
                int[,] arr1=new int[size,size];
                int[,] arr2=new int[size,size];
                int[,] arr3=new int[size,size];
                for(int i=0;i<size;i++)
                {
                    for(int j=0;j<size;j++)
                    {
                        arr1[i,j]=int.Parse(Console.ReadLine());
                    }
                }
                for(int i=0;i<size;i++)
                {
                    for(int j=0;j<size;j++)
                    {
                        arr2[i,j]=int.Parse(Console.ReadLine());
                    }
                }
                for(int i=0;i<size;i++)
                {
                    
                    for(int j=0;j<size;j++)
                    {
                        arr3[i,j]=arr1[i,j] + arr2[i,j] ;
                        Console.WriteLine(arr3[i,j] +" ");
                    }
                }
            string name="njnjc n jd";
            name.Trim(' ');
            DateTime datee;
            bool temp1=DateTime.TryParseExact(Console.ReadLine(),"MM/dd/yyyy",null,System.Globalization.DateTimeStyles.None,out datee);
            if(!temp)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    DateTime var=datee.DayOfWeek();
                    Console.WriteLine("The day of the week for " +"date" + " is " +thatday);
                }
                string input=Console.ReadLine();
                char[] array=input.ToCharArray();
                string reverse="";
                for(int i=array.Length-1;i>=0;i--)
                {
                    reverse=reverse+ i;
                }
                Console.WriteLine(reverse);

                int number=int.Parse(Console.ReadLine());
                int power=int.Parse(Console.ReadLine());
                int sum=0;
                for(int i=1;i<=power;i++)
                {
                    sum+=number*i;
                }
                Console.WriteLine(sum);
            
                
    }
}