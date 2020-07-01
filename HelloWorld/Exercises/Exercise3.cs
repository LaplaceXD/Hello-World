using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Exercises
{
    class Exercise3
    {
        public static void List()
        {
            while (true)
            {
                Console.Write("Please input a list of at least 5 numbers (separated by comma): ");
                var input = Console.ReadLine();
                var listOfNumbers = input.Split(',');
                if (!string.IsNullOrWhiteSpace(input) && listOfNumbers.Length >= 5)
                {
                    var convertList = new List<int>();

                    foreach (var number in listOfNumbers)
                        convertList.Add(int.Parse(number));

                    convertList.Sort();
                    Console.WriteLine("{0}, {1}, and {2} are the smallest numbers in your list.", convertList[0], convertList[1], convertList[2]);

                    break;
                }
                Console.WriteLine("Please try again!");
                Console.WriteLine();
            }
        }
        public static void UniqueNumber()
        {
            var numberList = new List<int>();

            while (true)
            {
                Console.Write("Input a number (or type 'quit' to exit): ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                var numberInput = int.Parse(input);

                if (!numberList.Contains(numberInput))
                    numberList.Add(numberInput);

                foreach (var number in numberList)
                    Console.Write(number + ", ");

                Console.WriteLine();
            }
        }
        public static void NumberSort()
        {
            Console.Write("Input 5 numbers please (separate by comma): ");

            //lists
            var numberList = new List<int>();
            var removeList = new List<int>();

            while (true)
            {
                //restarter of the algorithm
                removeList.Clear();

                var input = Console.ReadLine();
                var numbers = input.Split(',');


                //convert strings to int
                foreach (var unconverted in numbers)
                {
                    var converted = int.Parse(unconverted);
                    numberList.Add(converted);
                }

                if (string.IsNullOrWhiteSpace(input) || numberList.Count != 5)
                {
                    Console.WriteLine("Please try again.");
                    numberList.Clear();
                    Console.WriteLine();
                    Console.Write("Input 5 numbers please (separate by comma): ");
                    continue;
                }

                numberList.Sort();
                //checking algorithm for repetitions
                var count = 0;
                for (var a = 0; a < numberList.Count - 1; a++)
                {
                    var limiter = 4 - a;
                    while (count < limiter && numberList[a] == numberList[a + 1])
                    {
                        removeList.Add(numberList[a + 1]);
                        numberList.Remove(numberList[a + 1]);
                        count++;
                    }
                }

                //system completer
                if (removeList.Count == 0)
                {
                    Console.WriteLine("Your numbers are valid, sorting...");
                    foreach (var inputs in numberList)
                        Console.Write(inputs + ", ");
                    Console.WriteLine();
                    break;
                }

                //loop restarts
                var listLength = 5 - numberList.Count;
                Console.Write("Your string of numbers have repeated values please input another " + listLength + " numbers (separate by comma): ");
            }
        }
        public static void NameReverse()
        {
            Console.Write("Write a name: ");
            var name = Console.ReadLine();
            var character = new char[name.Length];

            for (var i = 0; i < name.Length; i++)
            {
                character[i] = name[name.Length - 1 - i];
            }

            var reversed = new string(character);
            Console.WriteLine("Reversed name: " + reversed);
        }
        public static void FbLike()
        {
            Console.WriteLine("Tell me about your day: ");
            var post = Console.ReadLine();
            Console.WriteLine("You just posted: \n" + post);

            var listOfPeople = new List<string>();

            Console.Write("Input people that likes your post (press 'Enter' when done): ");
            var peopleThatLiked = Console.ReadLine();
            var peopleSet = peopleThatLiked.Split(',');
            listOfPeople.AddRange(peopleSet);

            if (string.IsNullOrWhiteSpace(peopleThatLiked))
                Console.WriteLine();
            else
            {
                if (listOfPeople.Count == 1)
                    Console.WriteLine(listOfPeople[0] + " likes your post");
                else if (listOfPeople.Count == 2)
                    Console.WriteLine("{0} and {1} likes your post", listOfPeople[0], listOfPeople[1]);
                else
                    Console.WriteLine("{0},{1} and {2} others likes your post", listOfPeople[0], listOfPeople[1], listOfPeople.Count - 2);
            }
        }
    }
}
