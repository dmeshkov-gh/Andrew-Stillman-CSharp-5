using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HideAndSeekGame
{
    public partial class Form1 : Form
    {
        int Moves;

        Opponent opponent;

        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room diningRoom;
        Room stairs;
        RoomWithHidingPlace hall;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        RoomWithHidingPlace bathroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("I've been found for " + Moves + " moves");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description_tb.Text = "Opponent has been found for " + Moves 
                    + " moves. He's been hiding in " + foundLocation.HidingPlaceName + ".";
            }
            Moves = 0;
            hide_btn.Visible = true;
            goHere_btn.Visible = false;
            check_btn.Visible = false;
            goThroughTheDoor_btn.Visible = false;
            exits_cb.Visible = false;
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living room", "old carpet", "closet", "oak door with aeneous doornob");
            kitchen = new RoomWithDoor("Kitchen", "hot plate made of stainless steel", "wardrobe", "net door");
            diningRoom = new Room("Dining room", "cut-glass chandalier");
            stairs = new Room("Stairs", "wooden banisters");
            hall = new RoomWithHidingPlace("Hallway", "dog picture", "in the hall wardrobe");
            masterBedroom = new RoomWithHidingPlace("Master bedroom", "big bed", "under the big bed");
            secondBedroom = new RoomWithHidingPlace("Second bedroom", "small bed", "under the small bed");
            bathroom = new RoomWithHidingPlace("Bathroom", "toilet and sink", "in the shower");

            frontYard = new OutsideWithDoor("Front yard", false, "oak door with aeneous doornob");
            backYard = new OutsideWithDoor("Back yard", true, "net door");
            garden = new OutsideWithHidingPlace("Garden", false, "in the barn");
            driveway = new OutsideWithHidingPlace("Driveway", false, "in the parklot");

            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            stairs.Exits = new Location[] { livingRoom, hall};
            hall.Exits = new Location[] { stairs, masterBedroom, secondBedroom, bathroom };
            masterBedroom.Exits = new Location[] { hall };
            secondBedroom. Exits = new Location[] { hall };
            bathroom.Exits = new Location[] { hall };

            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            driveway.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits_cb.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits_cb.Items.Add(currentLocation.Exits[i].Name);
            exits_cb.SelectedItem = 0;
            description_tb.Text = currentLocation.Description + "\r\n(Move #" + Moves + ")";

            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check_btn.Text = "Check " + hidingPlace.HidingPlaceName;
                check_btn.Visible = true;
            }
            else
                check_btn.Visible = false;
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

        private void hide_btn_Click(object sender, EventArgs e)
        {
            hide_btn.Visible = false;

            for (int i = 1; i <= 10; i++)
            {
                opponent.Move();
                description_tb.Text = i.ToString();
                Application.DoEvents();
                Thread.Sleep(200);

            }
            description_tb.Text = "I'm going to seek";
            Application.DoEvents();
            Thread.Sleep(500);

            goHere_btn.Visible = true;
            exits_cb.Visible = true;

            MoveToANewLocation(livingRoom);
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }
    }
}
