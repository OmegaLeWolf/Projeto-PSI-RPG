using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PSI
{
    public partial class attackMenu : Form
    {
        public Player player;
        public Enemy enemy;

        public attackMenu(Player character, Enemy enemychar)
        {
            InitializeComponent();

            player = character;
            enemy = enemychar;
        }

        //Attack enemy
        private void cAttack_Click(object sender, EventArgs e)
        {
            //Calculate how much to attack
            double damage = player.damageGiven();

            if (!enemy.checkEnemyHealth(damage))
            {
                //Player wins

                //Gives player experience for killing enemy
                player.giveExperience(enemy.level * 0.2);
                //Checks if player is eligible for levelup
                int level = player.levelUp();
                //If is eligible
                if (level != -1)
                {
                    MessageBox.Show("You gained a level! You are now level " + level, "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                double recDamage = enemy.enemyDamageGiven();
                
                if(!player.checkHealth(recDamage))
                {
                    //Player dies

                    MessageBox.Show("Your adventure ends here. Game Over.", "Game Over.");
                    //Resets player location back to start
                    player.location = "Wonderland";
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
                MessageBox.Show("You used a healing potion and gained 20HP!", "Healing Potion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //If not in inventory
            else
            {
                MessageBox.Show("You do not have a healing potion!", "Healing Potion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
