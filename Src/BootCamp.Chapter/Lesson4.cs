using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson4
    {

        const float floatError = -1f;
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

            if (weight <= 0 || height <= 0)
            {
                string errorMessage = "Failed calculating BMI. Reason:";

                if (weight <= 0)
                {
                    errorMessage += $" Weight cannot be equal or less than zero, but was {weight}.";
                }

                if (height <= 0)
                {
                    errorMessage += $" Height cannot be equal or less than zero, but was {height}.";
                }

                Console.WriteLine(errorMessage);

                return floatError;
            }

            float bmi = (float)(weight / Math.Pow(height, 2));
            return bmi;
        }

        public static float promptFloat(string input)
        {
            bool isFloat;
            float inputResult;

            Console.WriteLine(input);
            string stringCheck = Console.ReadLine();

            isFloat = float.TryParse(stringCheck, out inputResult);

            if (isFloat)
            {
                return inputResult;
            }

                Console.WriteLine($"\"{stringCheck}\" is not a valid number.");
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
            string stringCheck = Console.ReadLine();

            isInt = int.TryParse(stringCheck, out inputResult);

            if (isInt)
            {
                return inputResult;
            }

            Console.WriteLine($"\"{stringCheck}\" is not a valid number.");
            return intError;
        }


    }
}
