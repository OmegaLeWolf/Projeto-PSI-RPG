using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PSI
{
    public class Villager
    {
        //----Atributes----

        //Identification
        public string name = "";
        public int id = 1;

        //Level
        public int level = 1;
        public double experience = 0;

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
