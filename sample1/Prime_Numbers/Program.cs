using System;

namespace Prime_Numbers
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");


            int n1;

            n1 = Convert.ToInt32(Console.ReadLine());


            if(n1<2)
                Console.WriteLine("Not a Prime number!");
            if(n1==2)
                Console.WriteLine("Its a prime number!");
            if(n1>2)
            {
                int count = 0;
                for (int i = 1; i <= n1; i++)
                {
                    if (n1 % i == 0)
                    {

                        count++;
                    }
                }
                if(count==2)
                {
                    Console.WriteLine("Its a prime number!");
                }
                else Console.WriteLine("Not a Prime number!");
            }

                
        }
    }
}
