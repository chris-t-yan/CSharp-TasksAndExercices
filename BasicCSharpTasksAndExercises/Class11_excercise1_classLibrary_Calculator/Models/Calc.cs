using System;
using System.Collections.Generic;
using System.Text;
using Class11_excercise1_Calculator.Helpers;

namespace Class11_excercise1_Calculator.Models
{
    public static class Calc
    {
        public static decimal Avg(List<int> numbers) 
        {
             return HelpersMethods.CalculateAverage(numbers);
        }

        public static int Max(List<int> numbers) 
        {
            return HelpersMethods.FindMaxNumber(numbers);
        }
    }
}
