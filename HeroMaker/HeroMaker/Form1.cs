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

            // FOR TESTING PURPOSES
            string statis_message = "Your new hero is called " + txt_name.Text + " and has the following abilities: ";

            if (abilities[0])
                statis_message += "Flight, ";
            if (abilities[1])
                statis_message += "Super Strength, ";
            if (abilities[2])
                statis_message += "Invisibility, ";
            if (abilities[3])
                statis_message += "Fast Healing, ";
            if (abilities[4])
                statis_message += "Agility, ";
            if (abilities[5])
                statis_message += "Invulnerability, ";
            if (abilities[6])
                statis_message += "Super Intelligence, ";
            if (abilities[7])
                statis_message += "Communicatioin with Animals, ";
            if (abilities[8])
                statis_message += "Teleportation, ";
            if (abilities[9])
                statis_message += "Claws and/or Fangs, ";
            if (abilities[10])
                statis_message += "Telepathy and/or Telekenesis, ";
            if (abilities[11])
                statis_message += "Weapons Expert, ";

            MessageBox.Show(statis_message);
        }
    }
}
