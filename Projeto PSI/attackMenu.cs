using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Projeto_PSI
{
    public partial class attackMenu : Form
    {
        public Player player;
        public Enemy enemy;
        private System.Threading.Timer timer;


        public attackMenu(Player character, Enemy enemychar)
        {
            InitializeComponent();


            player = character;
            enemy = enemychar;

            cHealthText.Text = player.health.ToString();
            cLevelText.Text = player.level.ToString();

            eHealthText.Text = enemy.health.ToString();
            eLevelText.Text = enemy.level.ToString();
            pictureBox1.ImageLocation = "./CowardEnemy.jpg";
        }

        void UpdateTextBox(object state)
        {
            Player charObj = player;
        
            cHealthText.Invoke(new Action(() =>
            {
                cHealthText.Text = charObj.health.ToString();
            }));
            cLevelText.Invoke(new Action(() =>
            {
                cLevelText.Text = charObj.level.ToString();
            }));
            eHealthText.Invoke(new Action(() =>
            {
                eHealthText.Text = enemy.health.ToString();
            }));
            eLevelText.Invoke(new Action(() =>
            {
                eLevelText.Text = enemy.level.ToString();
            }));

        }

        //Attack enemy
        private void cAttack_Click(object sender, EventArgs e)
        {
            double damage = 0;
            //Check if player has a sword
            if (player.checkIfItemInInventory("Sword"))
            {
                damage = player.damageGiven() + 10;
            }
            else
            {
                damage = player.damageGiven();
            }
            //Calculate how much to attack

            MessageBox.Show($"Your hit did {damage} damage!", "You attack the enemy!");

            if (!enemy.checkEnemyHealth(damage))
            {
                //Player wins

                MessageBox.Show("You won this time..", "You won!");

                //Gives player experience for killing enemy
                player.giveExperience(enemy.level * 2);
                player.money += 100;
                //Checks if player is eligible for levelup
                int level = player.levelUp();
                //If is eligible
                if (level != -1)
                {
                    MessageBox.Show("You gained a level! You are now level " + level, "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                timer.Dispose();
                this.Close();
            }
            else
            {
                double recDamage = enemy.enemyDamageGiven();

                MessageBox.Show($"You lost {recDamage} HP!", "Enemy Attacks back!");
                
                if(!player.checkHealth(recDamage))
                {
                    //Player dies

                    MessageBox.Show("Your adventure ends here. Game Over.", "Game Over.");
                    //Resets player location back to start
                    player.location = "Wonderland";

                    timer.Dispose();
                    this.Close();
                }
            }
            //Else match continues
        }

        private void cHeal_Click(object sender, EventArgs e)
        {
            //Check if potion is in inventory
            if (player.checkIfItemInInventory("Healing Potion"))
            {
                //Use healing potion
                player.takeHealPotion(20);

                player.remItemFromInventory("Healing Potion");

                MessageBox.Show("You used a healing potion and gained 20HP!", "Healing Potion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //If not in inventory
            else
            {
                MessageBox.Show("You do not have a healing potion!", "Healing Potion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void cEscape_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You managed to get away!", "You got away!");
            timer.Dispose();
            this.Close();
        }

        private void attackMenu_Load(object sender, EventArgs e)
        {
            timer = new System.Threading.Timer(UpdateTextBox, null, 0, 1000);

        }
    }
}
