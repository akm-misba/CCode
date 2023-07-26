using System;
using System.Linq;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] nubers = new int[5] ;
            nubers[0]= 34;
            nubers[1] = 56;
            for (int i = 0; i < nubers.Count(); i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
