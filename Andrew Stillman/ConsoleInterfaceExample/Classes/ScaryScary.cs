using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceExample
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int _numberOfScaryThings;
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            _numberOfScaryThings = numberOfScaryThings;
        }
        public string ScaryThingIHave => "I've got " + _numberOfScaryThings + " spiders";

        public void ScareLittlyChildren()
        {
            Console.WriteLine("I can't take" + _funnyThingIHave);
        }
    }
}
