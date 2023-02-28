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
    public partial class travelMap : Form
    {
        public Player charObj;
        public travelMap(Player character)
        {
            InitializeComponent();

            charObj = character;
        }

        private void wonderlandTravel_Click(object sender, EventArgs e)
        {
            //Wonderland

            charObj.location = "Wonderland";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dark Forest

            charObj.location = "Dark Forest";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Coward Island

            charObj.location = "Coward Island";
            this.Close();
        }

        private void travelMap_Load(object sender, EventArgs e)
        {
            string location = charObj.location;

            if (location == "Wonderland")
            {
                wonderlandTravel.Enabled = false;
            }
            else if (location == "Dark Forest")
            {
                button1.Enabled = false;
            }
            else if (location == "Coward Island")
            {
                button2.Enabled = false;
            }
        }
    }
}
