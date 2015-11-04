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
                if (i % 2 == 0) //alternate adding a 0 or 1 to the front and then back of the string
                    triangle = triangle + (((i + 3) / 2) % 2); //add two 0s in a row, and then two 1s (+3 starts the sequence at 0)
                else
                    triangle = (((i + 3) / 2) % 2) + triangle;
                Console.WriteLine(triangle);
            }
            //end 
        }
    }
}