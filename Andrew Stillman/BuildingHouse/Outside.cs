using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingHouse
{
    class Outside : Location
    {
        private bool _hot;
        public bool Hot { get => _hot; }

        public Outside(string name, bool hot) : base(name)
        {
            _hot = hot;
        }

        public override string Description 
        {
            get
            {
                string newDescription = base.Description;
                if (Hot)
                    newDescription += "It's really hot here!";
                return newDescription;
            }
        } 
    }
}
