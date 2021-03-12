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

            //passing values to set play object properties
            _player = new Player(10, 10, 20, 0, 1);


            //giving values to the form fields: hitpoint, gold, xp, and level. My "invisible" fields start with "lbl"

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

    }
}
