using System;

namespace BasicCalcsTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f1, f2, f3, f4;
            Console.WriteLine("Enter the temputure of floor 1: ");
            f1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the temputure of floor 2: ");
            f2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the temputure of floor 3: ");
            f3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the temputure of floor 4: ");
            f4 = Convert.ToInt32(Console.ReadLine());
            double result = (f1 + f2 + f3 + f4) / 4;
            Console.WriteLine("The Average building temperature is: " + result);

            if (result < 5)
            {
                Console.WriteLine("Temperature Alert!");
            }
            else
            {
                Console.WriteLine("No Alert");
            }

        }
    }
}
