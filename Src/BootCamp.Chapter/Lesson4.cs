using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson4
    {

        const float floatError = -1.0f;
        const int intError = -1;
        const string stringError = "-";
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
            if (weight <= 0) 
            {
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}");
            }

            if (height <= 0) 
            { 
            Console.WriteLine($"Height cannot be equal or less than zero, but was {weight}");
            }

            return weight / (height * height);
        }

        public static float promptFloat(string input)
        {
            bool isFloat;
            float inputResult;

            Console.WriteLine(input);

            isFloat = float.TryParse(Console.ReadLine(), out inputResult);

            if (isFloat)
            {
                return inputResult;
            }

                Console.WriteLine($"{input} is not a valid number.");
                return floatError;

        }

        public static string promptString(string input)
        {
       
            Console.WriteLine(input);
            string stringCheck = Console.ReadLine();

            if (!string.IsNullOrEmpty(stringCheck))
            {
                return stringCheck;
            }

            Console.WriteLine("Name cannot be empty.");
            return stringError;

        }

        public static int promptInt(string input)
        {
            bool isInt;
            int inputResult;

            Console.WriteLine(input);

            isInt = int.TryParse(Console.ReadLine(), out inputResult);

            if (isInt)
            {
                return inputResult;
            }

            Console.WriteLine($"{input} is not a valid number.");
            return intError;
        }


    }
}
