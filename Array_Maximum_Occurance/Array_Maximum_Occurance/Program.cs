using System;

namespace Array_Maximum_Occurance
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 8, 0, 2, 7, 9, 3, 5, 7, 9 };

            int length = a.Length;

            int j = 0;


            while (j < length)
            {
                int max = a[j];
                int count = 0;


                for (int i = 0; i < length; i++)
                {
                    if (max == a[i])
                    {
                        count++;
                    }





                }

                if (count > length / 2)
                {
                    Console.Write(max + "has maximum occurance");
                    break;
                }

                j++;

            }



        }
    }
}
