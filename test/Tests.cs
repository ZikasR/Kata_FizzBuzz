using System;
using Xunit;
using FizzBuzzLibrary; 

namespace Tests
{
    public class Tests
    {

        FizzBuzz fizzBuzz;


        public Tests()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void test_other_numbers() 
        {
            var result = fizzBuzz.Print(23);

            Assert.Equal("23", result);
        }

        [Fact]
        public void  Print_Fizz_instead_of_number_which_is_divisible_by_3()
        {
            var result = fizzBuzz.Print(3);

            Assert.Equal("Fizz", result);        
        }

        [Fact]
        public void  Print_Buzz_instead_of_number_which_is_divisible_by_5()
        {
            var result = fizzBuzz.Print(5);

            Assert.Equal("Buzz", result);        
        }

        [Fact]
        public void  Print_FizzBuzz_instead_of_number_which_is_divisible_by_5_and_3()
        {
            var result = fizzBuzz.Print(15);

            Assert.Equal("FizzBuzz", result);        
        }
    }
}
