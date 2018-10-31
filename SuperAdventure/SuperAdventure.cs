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

            Location location = new Location();
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house";

            _player = new Player();

            _player.CurrentHitPoints = 10;
            _player.MaxHitPoints = 10;
            _player.Gold = 30;
            _player.ExpPoints = 0;
            _player.Level = 1;

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExpPoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }
    }
}
