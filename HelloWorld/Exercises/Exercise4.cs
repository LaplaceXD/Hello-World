using System;
using System.Collections.Generic;

namespace HelloWorld.Exercises
{
    class Exercise4
    {
        public static void TimeValidity()
        {
            Console.Write("Please input a time (HH:mm): ");
            var inputs = Console.ReadLine();
            try
            {
                var time = DateTime.Parse(inputs);
                Console.WriteLine("Ok");
            }
            catch (Exception)
            {
                Console.WriteLine("invalid");
            }
        }
        public static void Vowels()
        {
            Console.Write("Input a word: ");
            var inputs = Console.ReadLine().Trim().ToLower();
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

            if (!string.IsNullOrEmpty(inputs))
            {
                var count = 0;
                foreach (var character in inputs)
                {
                    if (vowels.Contains(character))
                        count++;
                }

                Console.WriteLine("The number of vowels in your word is: " + count);
            }
        }
        public static void Pascal()
        {
            Console.Write("Input a few words (separated by space): ");
            var inputs = Console.ReadLine().Trim();

            if (!String.IsNullOrEmpty(inputs))
            {
                var wordList = new List<string>();
                foreach (var word in inputs.Split(' '))
                {
                    var lowerWord = word.ToLower();
                    var upperWord = word.ToUpper();
                    var completeWord = lowerWord.Replace(lowerWord[0], upperWord[0]);
                    wordList.Add(completeWord);
                }

                foreach (var word in wordList)
                {
                    Console.Write(word);
                }

                Console.WriteLine();
            }

        }
        public static void Duplicates()
        {
            Console.Write("Please input a string of numbers (e.g. 5-6-7-8-9): ");
            var inputs = Console.ReadLine().Trim();

            if (!string.IsNullOrEmpty(inputs))
            {
                var numbers = inputs.Split('-');
                var storage = new List<string>();
                foreach (var number in numbers)
                {
                    if (storage.Contains(number))
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }

                    storage.Add(number);
                }
            }
        }
        public static void Consecutives()
        {
            Console.Write("Please input a string of numbers (e.g. 5-6-7-8-9): ");
            var inputs = Console.ReadLine().Trim().Split('-');

            var numberList = new List<int>();
            foreach (var number in inputs)
                numberList.Add(Convert.ToInt32(number));

            var stopper = true;
            for (var i = 0; i < numberList.Count - 1; i++)
            {
                if (numberList[i] + 1 != numberList[i + 1])
                {
                    stopper = false;
                    break;
                }
            }

            Console.WriteLine(stopper ? "Consecutive" : "Not Consecutive");
        }
    }
}
