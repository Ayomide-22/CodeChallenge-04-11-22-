using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number");
            double start =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number");
            double end =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter gap to check");
            double gap =double.Parse(Console.ReadLine());
            int count=0;
            if(start>end)
            {
                Console.WriteLine("Starting number can't be less than ending number");
                return;
            }
            for (var k = start; k <=end-gap; k++)
            {
                if(CheckPrime(k))
                {
                    if(CheckPrime(k+gap))
                    {
                        count++;
                    }
                }
                if(count==1)
                {
                    Console.WriteLine($"{k} {k+gap}");
                    break;
                }
            }
            if(count==0)
            {Console.WriteLine("There are are no pairs with this gap");}
        }


        static bool CheckPrime(double n)
        {
            double c=0;
            if(n==0||n==1){return false;}
            if(n%2==0){c=n/2;}
            else{c=(n+1)/2;}
            for(double j=2;j<=c;j++)
            {
                if(n%j==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
