using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    //Write a program that prints the numbers from 1 to 100. 
    //But for multiples of three print "Fizz" instead of the number 
    //and for the multiples of five print "Buzz". 
    //For numbers which are multiples of both three and five print "FizzBuzz".
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void has_3_fizz_when_9_is_passed_in()
        {
            var process = new FizzBuzzProcessor();
            var results = process.Run(9);

            var count = results.Count(i => i.Equals("fizz", StringComparison.InvariantCultureIgnoreCase));


            Assert.AreEqual(3, count);
        }
        [TestMethod]
        public void has_1_buzz_when_9_is_passed_in()
        {
            var process = new FizzBuzzProcessor();
            var results = process.Run(9);

            var count = results.Count(i => i.Equals("buzz", StringComparison.InvariantCultureIgnoreCase));


            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void has_0_fizz_when_2_is_passed_in()
        {
            var process = new FizzBuzzProcessor();
            var results = process.Run(2);

            var count = results.Count(i => i.Equals("fizz", StringComparison.InvariantCultureIgnoreCase));


            Assert.AreEqual(0, count);
        }
        [TestMethod]
        public void has_0_buzz_when_4_is_passed_in()
        {
            var process = new FizzBuzzProcessor();
            var results = process.Run(4);

            var count = results.Count(i => i.Equals("buzz", StringComparison.InvariantCultureIgnoreCase));


            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void has_1_fizzbuzz_when_10_is_passed_in()
        {
            var process = new FizzBuzzProcessor();
            var results = process.Run(10);

            var count = results.Count(i => i.Equals("fizzbuzz", StringComparison.InvariantCultureIgnoreCase));


            Assert.AreEqual(1, count);
        }

    }

    internal class FizzBuzzProcessor
    {
        public FizzBuzzProcessor()
        {
        }

        internal IEnumerable<string> Run(int arg)
        {
            List<string> results = new List<string>();
            for (int i = 1; i <= arg; i++)
            {
                string result = string.Empty;
                if (i % 3 == 0)
                {
                    result = "fizz";
                }
                if (i % 5 == 0)
                {
                    if (string.IsNullOrEmpty(result))
                        result = "buzz";
                    //else
                    //    result = result + "buzz";
                }
                if (string.IsNullOrEmpty(result))
                        results.Add(i.ToString());
                else
                    results.Add(result);
            }
            return results;
            //   return Enumerable.Range(1,3).Select(i=>"fizz");
        }
    }
}
 