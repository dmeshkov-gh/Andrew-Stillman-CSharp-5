using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceExample
{
    class TallGuy : IClown
    {
        public string Name { get; set; }
        public int Height { get; set; }

        public string FunnyThingIHave => "Big Shoes";

        public void Honk()
        {
            Console.WriteLine("Honk Honk");
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall");
        }
    }
}
