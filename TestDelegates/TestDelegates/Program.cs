using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegates
{
    class Program
    {
        public static void compareUrlStrings(string Url1, string Url2)
        {
            if (Url1 == Url2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("Unmatch");
            }
        }
        static void Main(string[] args)
        {
            InterfaceTester it1 = new InterfaceTester(), it2 = new InterfaceTester(), it3 = new InterfaceTester(), it4 = new InterfaceTester();
            NextClass nc1 = new NextClass();

            Console.WriteLine(it1.add(2, 4));

            List<ITestingParams> list1 = new List<ITestingParams>();

            list1.Add(it1);
            list1.Add(nc1);
            list1.Add(it2);
            list1.Add(it3);
            list1.Add(it4);

            foreach (var elem in list1)
            {
                Console.WriteLine(DateTime.Today.DayOfWeek);
                elem.returnClassName();
                if (elem.returnClassName() == "NextClass")
                {
                    Console.WriteLine("Nothing to do");
                }
                else
                {
                    Console.WriteLine(elem.concat("a", "b"));
                    Console.WriteLine();
                }
            }



            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Sunday" :
                    {
                        Console.WriteLine(7);
                        Console.WriteLine("Weekend");
                    }
                    break;
                case "Monday":
                    Console.WriteLine(1);
                    break;
                case "Tuesday":
                    Console.WriteLine(2);
                    break;
                case "Wednesday":
                    Console.WriteLine(3);
                    break;
                case "Thursday":
                    Console.WriteLine(4);
                    break;
                case "Friday":
                    Console.WriteLine(5);
                    break;
                case "Satturday":
                    Console.WriteLine(6);
                    break;
                default:
                    break;
            }

        }
    }
}
