using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
namespace FizzBuzz.Test
{
    //Write a program that returns the numbers from 1 to 100. 
    //But for multiples of three print "Fizz" instead of the number 
    //and for the multiples of five print "Buzz". 
    //For numbers which are multiples of both three and five print "FizzBuzz".
    [TestClass, Ignore]
    public class FizzBuzz_Tests2
    {
        [TestMethod]
        public void Return_1_to_100()
        {
            FizzBuzzProcessor processor = new FizzBuzzProcessor();
            var result = processor.Run();

            Assert.AreEqual(100, result.Count());

        }

        [TestMethod]
        public void returns_33_Fizz()
        {
            FizzBuzzProcessor processor = new FizzBuzzProcessor();
            var result = processor.Run().Count(i => i.Equals("Fizz", StringComparison.InvariantCultureIgnoreCase));

            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void returns_20_Buzz()
        {
            FizzBuzzProcessor processor = new FizzBuzzProcessor();
            var result = processor.Run().Count(i => i.Equals("Buzz", StringComparison.InvariantCultureIgnoreCase));

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void Rreturns_6_FizzBuzz()
        {
            FizzBuzzProcessor processor = new FizzBuzzProcessor();
            var result = processor.Run().Count(i => i.Equals("FizzBuzz", StringComparison.InvariantCultureIgnoreCase));

            Assert.AreEqual(6, result);
        }
    }
}
