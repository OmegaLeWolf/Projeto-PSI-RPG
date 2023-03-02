using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PSI
{
    public class expensiveTrader:Trader 
    {
        public int swordPrice = 5999;
        public int healingPrice = 199;
        public int amuletPrice = 149000;

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
