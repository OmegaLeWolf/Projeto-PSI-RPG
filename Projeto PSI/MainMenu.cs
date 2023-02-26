using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projeto_PSI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //New Game
        private void button1_Click(object sender, EventArgs e)
        {
            //Hides current form
            this.Hide();

            //Creates new Character
            string charName = Interaction.InputBox("Insert character's name: ", "Character Creation");

            //If Character name invalid (Aka without characters), returns a message box, shows the main menu form again
            if (charName == "" || charName == " " || charName == null)
            {
                MessageBox.Show("Character name invalid!", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
            //Else create character
            else
            {
                //Creates new Player Object
                Player newChar = new Player(charName);

                //Creates new MainGame Object and Shows maingame form
                MainGame maingame = new MainGame(newChar);
                maingame.Show();
            }
        }

        //Load Game
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
