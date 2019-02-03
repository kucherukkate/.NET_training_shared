using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegates
{
    class NextClass : ITestingParams
    {
        public string className {get; set;}

        public NextClass()
        {
            className = "NextClass";
        }

        public double add(int ip1, int ip2)
        {
            throw new NotImplementedException();
        }

        public string concat(string ip1, string ip2)
        {
            return "result exceptable";
        }

        public string returnClassName()
        {
            return className;
        }


        public void DisplayClassName()
        {
            Console.WriteLine(className);
        }
    }
}
