using System;

namespace task3Prog4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like a Monthly(enter M) or Yearly(enter Y) subscription: ");
            string sub = Console.ReadLine();

            if (sub == "M")
            {
                Console.WriteLine("£2 per Month");
            }
            else if (sub == "Y")
            {
                Console.WriteLine( "£20 a year");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
                    
        }
    }
}
