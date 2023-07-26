using System;

namespace CsharfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string result= Add("misba ", "islam");
            //foreach( var res in result )
            
            Console.WriteLine (result);
            Console.ReadKey();
            
        }
        static string Add (string FirstName, string LastName)
        {
            string sum = FirstName + LastName;
            return sum;
        }
    }
}
