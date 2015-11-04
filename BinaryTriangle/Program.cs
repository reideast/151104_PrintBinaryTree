using System;

namespace BinaryTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size:");
            size=int.Parse(Console.ReadLine());
       
            Console.WriteLine("Triangle Size "+size+" is:"); 
            //write your logic here
            string triangle = "";
            for (int i = 0; i < size; i++)
            {
                //Console.WriteLine("{0} {1} {2}", i, i % 2, ((i + 3) / 2) % 2);
                if (i % 2 == 0)
                    triangle = triangle + (((i + 3) / 2) % 2);
                else
                    triangle = (((i + 3) / 2) % 2) + triangle;
                Console.WriteLine(triangle);
            }
            //end 
        }
    }
}