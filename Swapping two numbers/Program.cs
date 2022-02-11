using System;
class Swapping
{
    static void Main(string[] args)
    {
        int first, second;
        Console.Write("Enter the First Number: ");
        first = int.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number: ");
        second = int.Parse(Console.ReadLine());
        if (first != second)
        {
            first = first + second;
            second = first - second;
            first = first - second;
            Console.WriteLine("The First Number after Swapping: " + first);
            Console.Write("The Second Number after swapping: " + second);
        }
        else
            Console.WriteLine("The First and Second Number should be different");
    }
}

