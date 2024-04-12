using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        public static void Demo()
        {

            int numPeopleToCheck = promptInt("How many people would you like to find their BMI?");

            for (int i = 0; i < numPeopleToCheck; i++)
            {
                string firstName = promptString("Please enter your name:");
                string lastName = promptString("Please enter your last name:");
                int age = promptInt("Please enter your age:");
                float weight = promptFloat("Please enter your weight in kg:");
                float height = promptFloat("Please enter your height in cm:");
                float bmi = BodyMassIndex(weight, height);

                Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight}kg and his height is {height}cm and BMI is {bmi}");
            }

        }
        
        public static float BodyMassIndex(float weight, float height)
        {
            return weight / (height * height);
        }

        public static float promptFloat(string input)
        {
            Console.WriteLine(input);
            return float.Parse(Console.ReadLine());
        }

        public static string promptString(string input)
        {
            Console.WriteLine(input);
            return Console.ReadLine();

        }

        public static int promptInt(string input)
        {
            Console.WriteLine(input);
            return int.Parse(Console.ReadLine());
        }
        
    }
}

