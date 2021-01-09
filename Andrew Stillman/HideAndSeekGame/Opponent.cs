using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeekGame
{
    class Opponent
    {
        Location myLocation;
        Random random;
        public Opponent(Location initialLocation)
        {
            myLocation = initialLocation;
            random = new Random();
        }
        public void Move()
        {
            bool hidden = false;
            while (!hidden)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;
                    if (random.Next(2) == 1)
                        myLocation = locationWithDoor.DoorLocation;
                }
                int randomNextDoor = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[randomNextDoor];
                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }
        public bool Check(Location locationToCheck)
        {
            if (locationToCheck != myLocation)
                return false;
            else
                return true;
        }
    }
}
