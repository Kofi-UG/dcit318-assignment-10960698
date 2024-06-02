using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first side of the triangle: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second side of the triangle: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third side of the triangle: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("The triangle is Equilateral");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("The triangle is Isosceles");
        else
            Console.WriteLine("The triangle is Scalene");
    }
}
