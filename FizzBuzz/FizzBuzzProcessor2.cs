using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzProcessor2 
    {
        public IEnumerable<string> Run()
        {
            var result= Enumerable.Range(1, 100)
                              .Select(i =>  {
                                  if (i % 3 == 0 && i % 5 == 0)
                                      return "FizzBuzz";
                                  if (i % 3 == 0)
                                      return "Fizz";
                                  else if (i % 5 == 0)
                                      return "Buzz";
                                  else
                                      return i.ToString();

                              })

                             ;
            return result;
        }
    }
}
