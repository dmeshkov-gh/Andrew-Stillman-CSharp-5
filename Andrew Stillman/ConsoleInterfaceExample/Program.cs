using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ScaryScary scaryScary = new ScaryScary("big shoes", 14);
            FunnyFunny funnyFunny = scaryScary;
            IScaryClown someOtherScaryClown = funnyFunny as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadKey();        }
    }
}
