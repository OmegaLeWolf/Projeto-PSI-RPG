using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PSI
{
    public class Enemy:Villager
    {
        //Health
        public double health = 100;
        private int minHealth = 0;
        private int maxHealth = 100;

        //Damage Multiplier
        public int power = 1;

        //Location
        public string location = "Wonderland";


        //Checks enemy health
        public bool checkEnemyHealth(double damage=0)
        {
            //Decreases health by given damage
            this.health -= damage;

            //If health is less than minimum health, returns false (enemy dies)
            if (this.health <= minHealth)
            {
                return false;
            }
            //Else, returns true, (enemy does not die)
            else
            {
                return true;
            }
        }

        public double enemyDamageGiven()
        {
            return this.power * this.level;
        }
    }
}
