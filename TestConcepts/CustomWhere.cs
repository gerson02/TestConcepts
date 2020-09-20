using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestConcepts
{
    public static class CustomWhere
    {
        public static IEnumerable<T> RunCustomWhere<T>(this IEnumerable<T> collection, Func<T, bool> filter)
        {

            foreach (var item in collection)
            {
                if (filter(item))
                {
                    yield return item;
                }
            }
        }


    }
}
