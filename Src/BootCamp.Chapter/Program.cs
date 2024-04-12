using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            int weight;
            double height;
            int loopTwice = 0;

            while (loopTwice < 2)
            {
                Console.Write("Please enter your name:");
                firstName = Console.ReadLine();

                Console.Write("Please enter your last name:");
                lastName = Console.ReadLine();

                Console.Write("Please enter your age:");
                age = int.Parse(Console.ReadLine());

                Console.Write("Please enter your weight in kg:");
                weight = int.Parse(Console.ReadLine());

                Console.Write("Please enter your height:");
                height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight}kg and his height is {height}cm");
                loopTwice++;
            }

        }
    }
}
