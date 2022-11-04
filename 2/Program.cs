using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num 1");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num 2");
            int num2=int.Parse(Console.ReadLine());
            if(num1<0 || num2<0)
            {
                Console.WriteLine("Both numbers bust be non-negative");
                return;
            }
            int count=0;
            while (num1!=0 && num2!=0)
            {
                if (num1>=num2)
                {
                    num1=num1-num2;
                    count++;
                }
                else if(num2>num1)
                {
                    num2=num2-num1;
                    count++;
                }
            }
            Console.WriteLine($"It takes {count} operations");
        }
    }
}
