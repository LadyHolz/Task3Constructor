using System;

namespace Task3Prog3IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the college temperature: ");
            int heat = Convert.ToInt32(Console.ReadLine());
            if (heat < 15)
            {
                Console.WriteLine("Switch on the college heating");
            }
            else
            {
                Console.WriteLine("The temperature is above 15c!");
            }
        }
    }
}
