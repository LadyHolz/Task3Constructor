using System;

namespace task3Prog6caseSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you mode of of transport. Lorry, Car, MotorBike, Bike or Foot: ");
            string transport = Console.ReadLine();

            switch (transport)
            {
                case "Lorry":
                    Console.WriteLine("Price £1");
                    break;
                case "Car":
                    Console.WriteLine("Price 50p");
                    break;
                case "MotorBike":
                    Console.WriteLine("Price 40p");
                    break;
                default:
                    Console.WriteLine("Free");
                    break;
             
                
            }
        }
    }
}
