using System;

namespace Work1
{
    public class PrimeNum
    {
        static void Main(string[] args)
        {
            int n;
            string a;
            Console.WriteLine("Please input a number");
            a = Console.ReadLine();
            n = int.Parse(a);

            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i + "is the prime number");
                }
            }
            Console.ReadLine();
        }
    }
}
