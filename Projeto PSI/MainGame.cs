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
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_PSI
{
    public partial class MainGame : Form
    {
        private bool inventoryToggled = false;
        internal Player charObj;
        private System.Threading.Timer timer;


        public MainGame(Player character)
        {
            InitializeComponent();

            //Initializes timer thread to run UpdateTextBox() every 1000 seconds
            timer = new System.Threading.Timer(UpdateTextBox, null, 0, 1000);

            //Window title displays player name
            this.Text = character.name;

            //Setting values for textboxes
            cNameText.Text = character.name;
            cHealthText.Text = character.health.ToString();
            cLevelText.Text = character.level.ToString();
            cXPText.Text = character.experience.ToString();
            cMoneyText.Text = character.money.ToString();

            currentMapArea.Text = character.location + ",";

            //Creating a charObj instance to use in other methods
            charObj = character;

            //Connecting to database
            SqlConnection con = new SqlConnection
                (
                "server=localhost;" +
                "database=projeto_psi_rpg;" +
                "UID=root;" +
                "password=;"
                );


        }
        void UpdateTextBox(object state)
        {
            //Updates textbox and label text to charObj.Atribute
            currentMapArea.Invoke(new Action(() =>
            {
                currentMapArea.Text = charObj.location + ",";
            }));
            cNameText.Invoke(new Action(() =>
            {
                cNameText.Text = charObj.name;
            }));
            this.Invoke(new Action(() =>
            {
                this.Text = charObj.name;
            }));
            cHealthText.Invoke(new Action(() =>
            {
                cHealthText.Text = charObj.health.ToString();
            }));
            cLevelText.Invoke(new Action(() =>
            {
                cLevelText.Text = charObj.level.ToString();
            }));
            cXPText.Invoke(new Action(() =>
            {
                cXPText.Text = charObj.experience.ToString();
            }));
            cMoneyText.Invoke(new Action(() =>
            {
                cMoneyText.Text = charObj.money.ToString();
            }));
            dataGridView1.Invoke(new Action(() =>
            {
                DataSet ds = new DataSet();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "table name";
            }));
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
                MessageBox.Show("You have encountered an enemy!", "Enemy");

                if (charObj.location == "Dark Forest")
                {
                    Enemy enemy = new Enemy();
                    attackMenu genAttack = new attackMenu(charObj, enemy);
                    genAttack.Show();
                }
                else if (charObj.location == "Coward Island")
                {
                    Enemy enemy = new Enemy();
                    attackMenu genAttack = new attackMenu(charObj, enemy);
                    genAttack.Show();

                }

            }
            else if (chance == 2 || charObj.location == "Wonderland")
            {
                MessageBox.Show("You encountered a local trader, he offers to show you his stock.", "Trading");

                Trading tradeForm = new Trading(charObj);
                tradeForm.Show();
            }
        }

        private void travelBtn_Click(object sender, EventArgs e)
        {
            travelMap travel = new travelMap(charObj);
            travel.Show();
        }

    }
}
