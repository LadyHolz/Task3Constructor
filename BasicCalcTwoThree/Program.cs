const int floors = 4;
int iteraliveValue = 0;
int averageTemp = 0;

for (int i = 0; i < floors; i++)
{
    if(i != 0)
    {
        Console.WriteLine("Enter floor Temp: " + i);
    }
    else
    {
        Console.WriteLine("Temp of ground floor");
    }
    iteraliveValue += int.Parse(Console.ReadLine());
}
averageTemp = iteraliveValue / floors;
Console.WriteLine("Average temp:" + " " + averageTemp);

Console.WriteLine();

if (averageTemp < 5)
{
    Console.WriteLine("Too Cold, Alert ");
}
else
{
    Console.WriteLine("The temperture of the rooms is fine");
}
