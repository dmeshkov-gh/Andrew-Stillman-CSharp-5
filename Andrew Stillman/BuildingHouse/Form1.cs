using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingHouse
{
    public partial class Form1 : Form
    {
        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room diningRoom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living room", "old carpet", "oak door with aeneous doornob");
            kitchen = new RoomWithDoor("Kitchen", "hot plate made of stainless steel", "net door");
            diningRoom = new Room("Dining room", "cut-glass chandalier");

            frontYard = new OutsideWithDoor("Front yard", false, "oak door with aeneous doornob");
            backYard = new OutsideWithDoor("Back yard", true, "net door");
            garden = new Outside("Garden", false);

            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            diningRoom.Exits = new Location[] { kitchen, livingRoom };

            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            exits_cb.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits_cb.Items.Add(currentLocation.Exits[i].Name);
            exits_cb.SelectedIndex = 0;

            description_tb.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor_btn.Visible = true;
            else
                goThroughTheDoor_btn.Visible = false;
        }

        private void btn_GoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits_cb.SelectedIndex]);
        }

        private void goThroughTheDoor_btn_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
