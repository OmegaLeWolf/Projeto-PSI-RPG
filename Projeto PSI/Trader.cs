using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PSI
{
    public class Trader: Villager
    {
        public int swordPrice = 5000;
        public int healingPrice = 100;
        public int amuletPrice = 100000;

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
