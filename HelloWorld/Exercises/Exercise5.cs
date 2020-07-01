using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HelloWorld.Exercises
{
    class Exercise5
    {
        public static void LongestWord()
        {
            Console.Write("Please input a file directory: ");
            var file = Console.ReadLine();

            var text = File.ReadAllLines(file);
            var firstList = new List<string>();
            var letters = new char[26];
            for (var i = 0; i < 26; i++)
                letters[i] = Convert.ToChar('a' + i);

            foreach (var line in text)
            {
                var words = line.Split(' ');
                foreach (var word in words)
                {
                    foreach (var character in word.ToLower())
                    {
                        string name = "";
                        firstList.Remove(name);
                        if (letters.Contains(character))
                            name += character;
                        firstList.Add(name);
                    }
                }
            }

            var maxWord = firstList[0];
            var max = firstList[0].Length;
            foreach (var word in firstList)
            {
                if (max < word.Length)
                {
                    firstList.Remove(maxWord);
                    max = word.Length;
                    maxWord = word;
                }
            }

            Console.WriteLine("The longetst word is: " + maxWord);

        }
        public static void WordCount()
        {
            Console.Write("Input the Directory of the FIle: ");
            var file = Console.ReadLine();

            var list = new List<string>();
            var letters = new char[26];
            for (var i = 0; i < 26; i++)
                letters[i] = Convert.ToChar('a' + i);

            var info = File.ReadAllLines(file);
            foreach (var line in info)
            {
                var words = line.Split(' ');
                foreach (var word in words)
                {
                    if (letters.Contains(word[0]) || letters.Contains(word[1]))
                        list.Add(word);
                }
            }

            Console.WriteLine(list.Count);
        }
    }
}
