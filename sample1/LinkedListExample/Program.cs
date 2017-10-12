using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {
        public class Node{

            private int data;
           public  Node next;

           public Node()
            {
                data = 0;
                next = null;
                
            }

            public Node(int d)
            {
                data = d;
                next = null;
            }


            public void printNode()
            {
                Console.Write("|"+data+"|->");
                if(next!=null)
                {
                    next.printNode();
                }
            }
            public void addElementToLast(int d)
            {

                if(next==null)
                {
                    next = new Node(d); 
                }

                else
                {
                    next.addElementToLast(d);
                }





            }
        }




        static void Main(String[] args)
        {

            Node n = new Node(10);

            n.addElementToLast(56);
            n.addElementToLast(34);


            n.printNode();


           
        }

     
    }




 
}
