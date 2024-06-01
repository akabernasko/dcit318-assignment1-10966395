using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int ticketPrice = (age >= 65 || age <= 12) ? 7 : 10;

        Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
    }
}
