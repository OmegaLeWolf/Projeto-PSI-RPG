using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_PSI
{
    public partial class MainGame : Form
    {
        private bool inventoryToggled = false;
        internal Player charObj;

        public MainGame(Player character)
        {
            InitializeComponent();

            //Window title displays player name
            this.Text = character.name;

            //Setting values for textboxes
            cNameText.Text = character.name;
            cHealthText.Text = character.health.ToString();
            cLevelText.Text = character.level.ToString();

            currentMapArea.Text = character.location;

            //Creating a charObj instance to use in other methods
            charObj = character;

            Thread updatePlayerValues = new Thread(updatePlayer);

            updatePlayerValues.Start();
        }

        public void updatePlayer()
        {
            Thread.Sleep(1000);

            //Window title displays player name
            this.Text = charObj.name;

            //Setting values for textboxes
            cNameText.Text = charObj.name;
            cHealthText.Text = charObj.health.ToString();
            cLevelText.Text = charObj.level.ToString();


        }

    //Toggles Inventory visibility by adjusting the width of the form
    private void inventoryToggle_Click(object sender, EventArgs e)
        {
            //If isn't toggled, aka not open, sets width to 1002px hence making the inventory box visible
            if (!inventoryToggled)
            {
                this.Width = 1002;
                inventoryToggled = true;
            }
            //Otherwise does the opposite, hiding the inventory box.
            else
            {
                this.Width = 560;
                inventoryToggled = false;
            }
        }

        //Saves and quits the game
        private void saveExit_Click(object sender, EventArgs e)
        {
            //Saving progress in database


            //Quitting game
            Environment.Exit(0);
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            //Opens form to display map in a larger screen
            showMap displayMap = new showMap(charObj.location);
            displayMap.Show();
        }

        private void inspectArea_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int chance = random.Next(1, 3);

            //If random number generates a 1
            if (chance == 1 && charObj.location != "Wonderland")
            {
                //Creates enemy based on player's current location

                if (charObj.location == "Dark Forest")
                {
                    Enemy enemy = new Enemy();
                    attackMenu genAttack = new attackMenu(charObj, enemy);
                }
                else if (charObj.location == "Coward Island")
                {
                    Enemy enemy = new Enemy();
                    attackMenu genAttack = new attackMenu(charObj, enemy);
                }

            }
            else if (chance == 2 || charObj.location == "Wonderland")
            {
                MessageBox.Show("You encountered a local trader, he offers to show you his stock.", "Trading");
            }
        }
    }
}
