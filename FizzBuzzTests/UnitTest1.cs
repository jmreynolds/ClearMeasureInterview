using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OurCoolThings;

namespace FizzBuzzTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnCorrectNumberOfItems()
        {
            //Arrange
            const int firstNumber = 1;
            const int lastNumber = 10;
            var rules = new List<ReplacementRules>()
            {
                new ReplacementRules(){Divisors = new List<int>(){3}, Label = "Fizz"},
                new ReplacementRules(){Divisors = new List<int>(){5}, Label = "Buzz"},
                new ReplacementRules(){Divisors = new List<int>(){3,5}, Label = "FizzBuzz"},
            };
            var result = Utilities.FizzBuzzer(firstNumber, lastNumber, rules).ToList();
            
            //Act

            //Assert
            Assert.IsTrue(result.Count==10);
        }

        [TestMethod]
        public void ShouldReturnCorrectSubstitutions()
        {
            //Arrange
            const int firstNumber = 1;
            const int lastNumber = 20;
            var rules = new List<ReplacementRules>()
            {
                new ReplacementRules(){Divisors = new List<int>(){3}, Label = "Fizz"},
                new ReplacementRules(){Divisors = new List<int>(){5}, Label = "Buzz"},
                new ReplacementRules(){Divisors = new List<int>(){3,5}, Label = "FizzBuzz"},
            };
            var result = Utilities.FizzBuzzer(firstNumber, lastNumber, rules).ToList();
            

            //Act

            //Assert
            Assert.IsTrue(result.Count(s => s == "Fizz") == 5);
            Assert.IsTrue(result.Count(s => s == "Buzz") == 3);
            Assert.IsTrue(result.Count(s => s == "FizzBuzz") == 1);
        }

        [TestMethod]
        public void ShouldAllowArbitraryRule()
        {
            //Arrange
            const int firstNumber = 1;
            const int lastNumber = 20;
            var rules = new List<ReplacementRules>()
            {
                new ReplacementRules(){Divisors = new List<int>(){4}, Label = "Foo"},
                new ReplacementRules(){Divisors = new List<int>(){4,5}, Label = "FooBar"},
            };
            var result = Utilities.FizzBuzzer(firstNumber, lastNumber, rules).ToList();


            //Act

            //Assert
            Assert.IsTrue(result.Count(s => s == "Foo") == 4);
            Assert.IsTrue(result.Count(s => s == "FooBar") == 1);
        }
        [TestMethod]
        public void ShouldReturnCorrectRange()
        {
            //Arrange
            const int firstNumber = 1;
            const int lastNumber = 100;
            var rules = new List<ReplacementRules>();
            var result = Utilities.FizzBuzzer(firstNumber, lastNumber, rules).ToList();


            //Act

            //Assert
            Assert.IsTrue(result.First()=="1");
            Assert.IsTrue(result.Last() == "100");
        }
    }
}
