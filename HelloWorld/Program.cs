using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    public class Generics
    {
        public TOutput Math<TInput, TOutput> (TInput value, TOutput output) 
            where TInput : IElements
        {
            IElements convert = value;
            Object obj = convert.Add();
            output = (TOutput) obj;
            return output;
        }
    }

    public interface IElements
    {
        int Add();
    }

    public class SomeElement : IElements
    {
        public int Add()
        {
            return 1;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var math = new Generics();
            string output;
            math.Math<int, string>(1, output);

            Console.WriteLine(output);
        }
    }
}

