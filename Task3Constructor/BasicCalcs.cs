using System;

namespace Task3Constructor
{
    internal class BasicCalcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many student are taking exams: ");
            int studentNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number of A4 paper needed is =" + " " + studentNum * 4);
        }
    }
}
