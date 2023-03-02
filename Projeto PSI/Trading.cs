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

        public cheapTrader cheapTrader = new cheapTrader();
        public cheapTrader cheapTrader2 = new cheapTrader();

        public expensiveTrader expensiveTrader = new expensiveTrader();
        public expensiveTrader expensiveTrader2 = new expensiveTrader();


        public Trading(Player player)
        {
            InitializeComponent();

            playerObj = player;
        }

        private void healingBuy_Click(object sender, EventArgs e)
        {
            if (playerObj.money >= trader.healingPrice)
            {
                playerObj.money -= trader.healingPrice;
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
            if (playerObj.money >= trader.swordPrice)
            {
                playerObj.money -= trader.swordPrice;
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
            if (playerObj.money >= trader.amuletPrice)
            {
                playerObj.money -= trader.amuletPrice;
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

        private void Trading_Load(object sender, EventArgs e)
        {
            if (playerObj.location == "Dark Forest")
            {
                Trader trader = new Trader();
            }
            else if (playerObj.location == "Coward Island")
            {
                expensiveTrader trader = new expensiveTrader();

            }
            else
            {
                expensiveTrader trader = new expensiveTrader();

            }

            eHealthText.Text = trader.healingPrice.ToString();
            textBox1.Text = trader.swordPrice.ToString();
            textBox2.Text = trader.amuletPrice.ToString();
        }
    }
}
