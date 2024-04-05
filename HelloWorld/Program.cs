using System;
namespace HelloWorld;// file scoped namespace

    class Program
    {
        public static void Main(string[] args)
        {
            int width=int.Parse(Console.ReadLine());
                int height=int.Parse(Console.ReadLine());
                for(int i=1;i<=height;i++)
                {
                    for(int j=1;j<=width;j++)
                    {
                        if(i==1 || j==1||i==height||j==width)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                Console.WriteLine();
                }

            /*string input=Console.ReadLine();
                char[] array1=input.ToCharArray();
                sort(array1);*/
                
               /* for(int i=0;i<array1.Length;i++)
                {
                    int  count=0;
                    for(int j=0;j<array1.Length;j++)
                    {
                        if(array1[i]==array1[j])
                        {
                            count++;
                        }
                    }
                if(count==1)
                    {
                        Console.Write(array1[i] +"");
                    }
                }*/
                
            /*int size=int.Parse(Console.ReadLine());
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
                        arr3[i,j]+=arr1[i++,j++] * arr2[i++,j++] ;
                        Console.Write(arr3[i,j] +" ");
                    }
                    Console.WriteLine();
                }*/

                    
        }
        static void sort(char[] arr1)
        {
            
            for(int i=0;i>arr1.Length;i++)
            {
                char temp=' ';
                for(int j=i+1;j<arr1.Length;j++)
                {
                    if(arr1[i].CompareTo(arr1[j])>0)
                    {
                        temp=arr1[i];
                        arr1[i]=arr1[j];
                        arr1[j]=temp;
                    }
                Console.WriteLine(temp+"");
                }
            }
        }
    }


