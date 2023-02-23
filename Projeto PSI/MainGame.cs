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
    public partial class MainGame : Form
    {
        private bool inventoryToggled = false;

        public MainGame()
        {
            InitializeComponent();

            //Window title displays player name
            this.Text = "Player Name";
        }

        //Toggles Inventory visibility by adjusting the width of the form
        private void inventoryToggle_Click(object sender, EventArgs e)
        {
            if (!inventoryToggled)
            {
                this.Width = 1002;
                inventoryToggled = true;
            }
            else
            {
                this.Width = 560;
                inventoryToggled = false;
            }
        }
    }
}
