using System;

namespace HelloWorld.Exercises
{
    class Exercise1
    {
        public static void ProgramInitialize()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();
            Console.WriteLine("1. Valid or Invalid \n2. Maximum of two numbers \n3. Orientation Verification \n4. Speed Camera");
            var input = int.Parse(Console.ReadLine());

            if (input == 1)
                NumberValidity();
            else if (input == 2)
                Maximum();
            else if (input == 3)
                Orientation();
            else if (input == 4)
                SpeedCamera();
            else
                Console.WriteLine("Please put in a valid number.");
        }

        public static void NumberValidity()
        {
            Console.Clear();
            Console.WriteLine("You have chosen \"Valid or Invalid\"");
            Console.WriteLine("Please input a number from 1 - 10");
            var numberInput = Convert.ToSingle(Console.ReadLine());

            var validity = (numberInput >= 1f && numberInput <= 10) ? ValidityCode.Valid : ValidityCode.Invalid;
            Console.WriteLine(validity);
        }

        public enum ValidityCode
        {
            Valid,
            Invalid
        }
        public static void Maximum()
        {
            Console.Clear();
            Console.WriteLine("You have chosen \"Maximum of two numbers\"");
            Console.WriteLine("Please input your first number");
            var firstNumber = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please input your second number");
            var secondNumber = Convert.ToSingle(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("They're equal.");
            }
            else
            {
                var number = (firstNumber > secondNumber) ? firstNumber : secondNumber;
                Console.WriteLine(number);
            }

        }

        public static void Orientation()
        {
            Console.Clear();
            Console.WriteLine("You have chosen \"Orientation Verification\"");
            Console.WriteLine("Please input the height of your image.");
            var height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please input the width of the image.");
            var width = Convert.ToSingle(Console.ReadLine());

            if (height == width)
            {
                Console.WriteLine("The image can't be oriented as it is a square.");
            }
            else
            {
                var orientation = (height > width) ? ImageOrientation.portrait : ImageOrientation.landscape;
                Console.WriteLine("The image is a " + orientation);
            }
        }

        public enum ImageOrientation
        {
            portrait,
            landscape
        }

        public static void SpeedCamera()
        {
            Console.Clear();
            Console.WriteLine("You have chosen \"Speed Camera\"");
            Console.WriteLine("Please input the Speed Limit");
            var limitSpeed = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please input the Speed of the Car");
            var carSpeed = Convert.ToSingle(Console.ReadLine());

            if (carSpeed <= limitSpeed)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var demeritPoints = (int)(carSpeed - limitSpeed) / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("Your demerit points is currently " + demeritPoints + ".");
                    Console.WriteLine("It is over the demerit points cap of 12, thus your license has been suspended");
                }
                else
                {
                    Console.WriteLine("Your demerit points is currently " + demeritPoints + ".");
                }
            }
        }
    }
}
