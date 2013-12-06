using System;
using System.Collections.Generic;
using OurCoolThings;

namespace ClearMeasure_TechScreen
{
    class Program
    {
        static void Main(string[] args)
        {
            const int firstNumber = 1;
            const int lastNumber = 1000000000;
            var rules = new List<ReplacementRules>
            {
                new ReplacementRules {Divisors = new List<int> {3}, Label = "Fizz"},
                new ReplacementRules {Divisors = new List<int> {5}, Label = "Buzz"},
                new ReplacementRules {Divisors = new List<int> {3,5}, Label = "FizzBuzz"},
            };
            //var fizzBuzz = Utilities.FizzBuzzer(firstNumber, lastNumber);
            foreach (var item in Utilities.FizzBuzzer(firstNumber,  lastNumber, rules))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
