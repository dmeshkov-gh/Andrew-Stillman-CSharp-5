using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceExample
{
    class FunnyFunny : IClown
    {
        protected string _funnyThingIHave;
        public FunnyFunny(string funnyThingsIhave)
        {
            _funnyThingIHave = funnyThingsIhave;
        }

        public string FunnyThingIHave => "Hi, I have " + _funnyThingIHave;

        public void Honk()
        {
            Console.WriteLine(FunnyThingIHave);
        }
    }
}
