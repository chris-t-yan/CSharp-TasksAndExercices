using System;
using System.Collections.Generic;
using System.Text;

namespace _04Class_excercise01_StaticClasses
{
    public abstract class Store
    {
        public abstract void Buy();
        

        public decimal TellPrice() 
        {
            ///implementation
            var result = FinanceUtility.CalculateDdv(200);
            return result;
        }

    }


}
