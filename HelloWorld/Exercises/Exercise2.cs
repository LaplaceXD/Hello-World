using System;

namespace HelloWorld.Exercises
{
    class Exercise2
    {
        public static void Maximum()
        {
            Console.WriteLine("Enter a series, separated by a comma. (E.g. \"5, 3, 2, 1, 4\")");
            var series = Console.ReadLine();

            const int stringAccount = 3;
            const int charAdjust = 48;

            var numberList = new int[(series.Length / stringAccount) + 1];

            for (var i = 0; i <= series.Length; i++)
            {
                if (i % stringAccount == 0)
                {
                    numberList[i / stringAccount] = (int)series[i];
                }
            }

            var b = 0;
            var a = 0;
            while (a != series.Length / stringAccount)
            {
                if (numberList[b] >= numberList[a])
                    a++;

                b = a;
            }

            Console.WriteLine(numberList[b] - charAdjust);
        }
        public static void GuessGame()
        {
            Console.WriteLine("Generating a number.");
            var random = new Random();
            var number = random.Next(1, 10);

            var i = 0;

            while (i < 4)
            {
                Console.Write("Try to guess the number ");
                var guess = int.Parse(Console.ReadLine());

                if (number != guess)
                {

                    Console.WriteLine("Try again");
                    i++;
                    if (i == 4)
                    {
                        Console.WriteLine("You Lost!");
                        break;
                    }
                    continue;
                }

                Console.WriteLine("You Won!");
                break;
            }
        }
        public static void Factorial()
        {
            Console.WriteLine("Please input a number.");
            var numberInput = int.Parse(Console.ReadLine());
            var listSize = numberInput;
            var list = new int[listSize];
            var b = new int[listSize];

            for (var i = 0; i < listSize; i++)
            {
                list[i] = numberInput--;
            }

            b[0] = list[listSize - 1];

            for (var a = 1; a < listSize; a++)
            {
                b[a] = list[listSize - a - 1] * b[a - 1];
            }

            Console.WriteLine(b[listSize - 1]);
        }
        public static void Count()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
