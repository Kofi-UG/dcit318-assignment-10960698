using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string input = Console.ReadLine();
        int grade;

        if (int.TryParse(input, out grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. The grade must be between 0 and 100.");
            }
            else if (grade >= 80)
                Console.WriteLine("Letter grade: A");
            else if (grade >= 70)
                Console.WriteLine("Letter grade: B");
            else if (grade >= 60)
                Console.WriteLine("Letter grade: C");
            else if (grade >= 50)
                Console.WriteLine("Letter grade: D");
            else if (grade >= 40)
                Console.WriteLine("Letter grade: E");
            else
                Console.WriteLine("Letter grade: F");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
        }
    }
}
