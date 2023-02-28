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
    public partial class Trading : Form
    {
        public Player playerObj;
        public Trader trader = new Trader();
        public Trading(Player player)
        {
            InitializeComponent();

            playerObj = player;
        }

        private void healingBuy_Click(object sender, EventArgs e)
        {
            if (playerObj.money >= 100)
            {
                playerObj.money -= 100;
                playerObj.inventory.Add("Healing Potion");
                MessageBox.Show("You just purchased a healing potion!", "Purchase");
            }
            else
            {
                MessageBox.Show("You don't have enough money to buy this!", "No money");
            }
        }

        private void swordBuy_Click(object sender, EventArgs e)
        {
            if (playerObj.money >= 5000)
            {
                playerObj.money -= 5000;
                playerObj.inventory.Add("Sword");
                MessageBox.Show("You just purchased a Sword!", "Purchase");
            }
            else
            {
                MessageBox.Show("You don't have enough money to buy this!", "No money");
            }
        }

        private void amuletBuy_Click(object sender, EventArgs e)
        {
            if (playerObj.money >= 100000)
            {
                playerObj.money -= 100000;
                playerObj.inventory.Add("Amulet");
                MessageBox.Show("You just purchased an amulet!", "Purchase");
            }
            else
            {
                MessageBox.Show("You don't have enough money to buy this!", "No money");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
