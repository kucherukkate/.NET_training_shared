using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegates
{
    class Class2 : ITestingParams, ITestingParams2
    {
        public double add(int ip1, int ip2)
        {
            return ip1 + ip2;
        }

        public string concat(string ip1, string ip2)
        {
            return ip1 + ip2;
        }

        public void DisplayClassName()
        {
            Console.WriteLine(this.returnClassName());
        }

        public void GetParentName()
        {
            Console.WriteLine("ITestingParams2");
        }

        public string returnClassName()
        {
            return this.GetType().Name;
        }
    }
}
