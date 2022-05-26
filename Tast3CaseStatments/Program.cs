using System;

namespace Tast3CaseStatments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter students score: ");
            int score = Convert.ToInt32(Console.ReadLine());


            switch (score)
            {
                case < 50:
                    Console.WriteLine("fail");
                    break;
                case < 70:            
                    Console.WriteLine("Grade B");
                    break;
                case < 100:
                    Console.WriteLine("Grade A");
                    break;
                default:
                    Console.WriteLine("Incorrect value");
                    break ;
            }
        }
    }
}
