using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegates
{
    class NextClass2 : ITestingParams
    {
        public string className {get; set;}

        public NextClass2()
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
