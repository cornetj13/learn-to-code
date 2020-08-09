using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker 
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e) 
        {
            // Initialize abilities array to all false.
            bool[] abilities = { false, false, false, false, false, false, false, false, false, false, false, false };

            // Flag user inputted abilities as true.
            abilities[0] = chk_flight.Checked;
            abilities[1] = chk_strength.Checked;
            abilities[2] = chk_invisible.Checked;
            abilities[3] = chk_healing.Checked;
            abilities[4] = chk_agility.Checked;
            abilities[5] = chk_invulnerable.Checked;
            abilities[6] = chk_intelligence.Checked;
            abilities[7] = chk_animalcommunication.Checked;
            abilities[8] = chk_teleportation.Checked;
            abilities[9] = chk_claws.Checked;
            abilities[10] = chk_telepathy.Checked;
            abilities[11] = chk_weapons.Checked;

            // Store user input of active locations.
            List<String> activeLocations = new List<String>();

            // Add the selected items to the active locations list.
            foreach (String city in lst_activelocations.SelectedItems)
            {
                activeLocations.Add(city);
            }

            // Add the prefer transport (string).
            string preferredTransport = "";

            if (rdo_flight.Checked)
                preferredTransport = "Flight";
            if (rdo_teleport.Checked)
                preferredTransport = "Teleportation";
            if (rdo_jetpack.Checked)
                preferredTransport = "Jet Pack";
            if (rdo_mobile.Checked)
                preferredTransport = txt_name.Text + "mobile";

            // FOR TESTING PURPOSES --- Message box of what's happening.
            string status_message = "Your new hero is called " + txt_name.Text + " and has the following abilities: ";

            if (abilities[0])
                status_message += "Flight, ";
            if (abilities[1])
                status_message += "Super Strength, ";
            if (abilities[2])
                status_message += "Invisibility, ";
            if (abilities[3])
                status_message += "Fast Healing, ";
            if (abilities[4])
                status_message += "Agility, ";
            if (abilities[5])
                status_message += "Invulnerability, ";
            if (abilities[6])
                status_message += "Super Intelligence, ";
            if (abilities[7])
                status_message += "Communicatioin with Animals, ";
            if (abilities[8])
                status_message += "Teleportation, ";
            if (abilities[9])
                status_message += "Claws and/or Fangs, ";
            if (abilities[10])
                status_message += "Telepathy and/or Telekenesis, ";
            if (abilities[11])
                status_message += "Weapons Expert, ";

            status_message += ". Our hero works in these locations: ";

            foreach (String city in activeLocations) 
            {
                status_message += city + ", ";
            }

            status_message += ". Our hero's preferred mode of transportation is: " + preferredTransport;

            MessageBox.Show(status_message);
        }
    }
}
