using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekGame
{
    class Room : Location
    {
        private string _decoration;
        public Room(string name, string decoration) : base(name)
        {
            _decoration = decoration;
        }

        public override string Description => base.Description + " You see " + _decoration + ".";
    }
}
