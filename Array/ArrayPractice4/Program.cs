using System;
namespace Arrayprac4;
class Program
{
    public static void Main(string[] args)
    {
                int size=int.Parse(Console.ReadLine());
                int[] array=new int[size];
                for(int i=0;i<array.Length;i++)
                {
                    array[i]=int.Parse(Console.ReadLine());
                }

                int[] array1=new int[size];
                int[] array2=new int[size];
                int c;
                int d=0;
                for(int i=0;i<array.Length;i++)
                {
                    c=0;
                    if(array[i]%2==0)
                    {
                        array1[c]=array[i];
                        c++;
                    }
                    else
                    {
                        array2[d]=array[i];
                        d++;
                    }
                }
                Console.Write("Odd Numbers : ");
                for(int i=0;i<array2.Length;i++)
                {
                Console.Write("{0} ", array2[i] );
                }
                Console.WriteLine();
                Console.Write("Even Numbers : ");
                for(int i=0;i<array1.Length;i++)
                {
                Console.Write( array1[i] + " ");
                }
    }
}