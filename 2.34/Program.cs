using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        int num1 = ((A % 10) + B) % 10;
        int num2 = (A / 10) + ((A % 10) + B) / 10;
        Console.WriteLine("Десятки: {0}, Единицы: {1}, ", num2, num1);
    }
}
