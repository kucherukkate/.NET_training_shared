using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegates
{
    interface ITestingParams
    {
        double add(int ip1, int ip2);
        string concat(string ip1, string ip2);
        string returnClassName();
        void DisplayClassName(); 
    }
}
