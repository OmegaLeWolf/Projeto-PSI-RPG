using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PSI
{
    public class DarkForestEnemy:Enemy
    {
        string imgAppearance = "./CowardEnemy.jpg";

        private string returnName()
        {
            return this.name;
        }
        private string returnLevel()
        {
            return this.level.ToString();
        }
    }
}
