using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzProcessor 
    {
        public IEnumerable<string> Run()
        {
            var result= Enumerable.Range(1, 100)
                              .Select(i =>
                              {
                                  if (DivisibleBy3(i) && DivisibleBy5(i))
                                      return "FizzBuzz";
                                  if (DivisibleBy3(i))
                                      return "Fizz";
                                  else if (DivisibleBy5(i))
                                      return "Buzz";
                                  else
                                      return i.ToString();

                              })

                             ;
            return result;
        }

        private static bool DivisibleBy5(int i)
        {
            return i % 5 == 0;
        }

        private static bool DivisibleBy3(int i)
        {
            return i % 3 == 0;
        }
    }
}
