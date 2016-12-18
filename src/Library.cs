using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        public string Print(int start, int? end = null)
        {
            end = end == null ? start : end;
            
            IEnumerable<int> range = Enumerable.Range(start, (int)end - start + 1);   

            return string.Join(" ", range.Select(x => Translate(x)).ToArray());
        }

        private string Translate(int x){

            string result = null;

            if(x % 3 == 0) 
                result += "Fizz";

            if(x % 5 == 0) 
                result += "Buzz";

            return result != null ? result : x.ToString();
        }
    }
}
