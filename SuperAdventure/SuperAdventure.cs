using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;

        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");
            // initializing a new player object - and assigning it to the _player private class
            _player = new Player(10, 10, 20, 0, 1);
            // these are the values being assigned to our new player object
            // _player.CurrentHitPoints = 10;
            // _player.MaximumHitPoints = 10;
            // _player.Gold = 20;
            //  _player.ExperiencePoints = 0;
            //  _player.Level = 1;
            // these lines told the labels what to display - so later as we change these the display should update! ToString is called because the 'Text' property is a string not an int
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}