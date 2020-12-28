using System;
using System.Collections.Generic;
using System.Text;

namespace _06Class_excercise02_AnonymousFunctions
{
    public static class ListExtension
    {
        public static string FindOrDefoult(this List<string> list, Func<string, bool> predicate)
        {
            string result = null;
            foreach (var item in list)
            {
                var isItemFound = predicate(item);
                if (isItemFound)
                {
                    result = item;
                    break;
                }
            }
            return result;
        }
    }
}
