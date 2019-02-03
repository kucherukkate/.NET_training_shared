using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegates
{
    class InterfaceTester: ITestingParams
    {
        public string className = "InterfaceTester";

        public double add(int ip1, int ip2)
        {
            return ip1 + ip2;
        }

        public string concat(string ip1, string ip2)
        {
            return (ip1 + ip2);
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
