using System;
using System.Collections.Generic;
using System.Text;

namespace _04Class_excercise01_StaticClasses
{
    public static class FinanceUtility
    {
        public static float ddvValue = 18.00f;

        
        public static decimal CalculateDdv(int price)
        {
            return (decimal)price + 20m;
        }
    }
}
