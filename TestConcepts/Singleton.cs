using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConcepts
{
    public class Singleton
    {
        private static Singleton _instance = null;
        private static object padlock = new object();

        public static Singleton Instance
        {
            get
            {
                lock(padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        return _instance;
                    }

                    return _instance;
                }
               
            }
        }

    }
}
