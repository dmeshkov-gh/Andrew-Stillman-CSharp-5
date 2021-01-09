using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterfaceExample
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittlyChildren();

    }
}
