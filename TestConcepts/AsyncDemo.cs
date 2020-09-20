using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConcepts
{
    public static class AsyncDemo
    {

        public static Task<int> SomeMethod(int value)
        {

            return Task.FromResult(value);
        }

    }
}
