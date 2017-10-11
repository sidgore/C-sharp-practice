using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\nEnter first number ");

            int n1;

            n1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=5; i++)
            {


                for (int j = 1; j <=3; j++)
                {

                    Console.Write(n1);
                }
                Console.Write("\n");

                //float n3 = (float)(n1/n2);
                // Console.WriteLine("Output is" + n3);
            }
        }
    }
}
