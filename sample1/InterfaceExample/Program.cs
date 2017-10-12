using System;

namespace InterfaceExample
{
    public interface ITransactions
    {
        // interface members
        void showNameanColor();
        int getAge();
    }





    class Program : ITransactions
    {

        String name ;
        int age;
        string color;



        public Program()
        {
            name = "";
            age = 0;
            color = "";

        }

        public Program(String n,int a,String c)
        {
            name = n;
            age = a;
            color = c;

        }




        public void showNameanColor()
        {
            Console.Write("\nName is "+name);
            Console.WriteLine("\nColor is "+color);
            Console.Write("Age is "+getAge());
        }

        public int getAge()
        {
            return age;
        }

        static void Main(string[] args)
        {

            Program p1 = new Program("Ram", 60, "Blue");

            p1.showNameanColor();

            Program p = new Program();
            p.age = 10;
            p.color = "red";
            p.name = "Siddharth";


            p.showNameanColor();




        }
    }
}
