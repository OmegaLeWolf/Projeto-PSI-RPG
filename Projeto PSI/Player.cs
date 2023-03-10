using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Projeto_PSI
{
    public class Player:Villager
    {
        //----Atributes----

        //Identification
        public string name = "";
        public int id = 1;

        //Level
        public int level = 1;
        public double experience = 0;

        //Health
        public double health = 100;
        private int minHealth = 0;
        private int maxHealth = 100;
        
        //Damage Multiplier
        public int power = 1;

        //Currency
        public int money = 0;

        //Inventory
        public List<string> inventory = new List<string>(); 

        //Location
        public string location = "Wonderland";

        //----Constructor----

        public Player(string name)
        {
            this.name = name;
            id += 1;
        }

        //----Methods----

        //Checks if player is eligible for levelup
        public int levelUp()
        {
            //If is eligible, resets experience, promotes level by one
            if (this.experience >= this.level*5)
            {
                this.level += 1;
                this.experience = 0;

                return this.level;
            }
            //If not eligible, returns -1, does nothing.
            else
            {
                return -1;
            }
        }

        public void giveExperience(double experience)
        {
            this.experience += experience;
        }

        public double damageGiven()
        {
            return this.power * this.level * 20;
        }

        //Checks player health
        public bool checkHealth(double damage=0)
        {
            //Decreases health by given damage
            this.health -= damage;

            //If health is less than minimum health, returns false (player dies)
            if (this.health < minHealth)
            {
                return false;
            }
            //Else, returns true, (player does not die)
            else
            {
                return true;
            }
        }

        public double takeHealPotion(double heal)
        {
            //Adds onto current health the heal value
            this.health += heal;

            //If current health is more than max health, decreases to 100 to prevent to much health
            if (this.health > maxHealth)
            {
                this.health = 100;
                return this.health;
            }
            else
            {
                return this.health;
            }
        }

        //Checks if a certain item is purchaseable
        public bool checkIfPurchasable(int cost)
        {
            //If is purchaseable, remove items cost from current money, return true
            if (this.money > cost)
            {
                this.money -= cost;
                return true;
            }
            //Else return false
            else
            {
                return false;
            }
        }

        //Returns current health
        public double checkHealth()
        {
            return this.health;
        }

        //Returns current money
        public int checkMoney()
        {
            return this.money;
        }

        //Returns current level
        public int checkLevel()
        {
            return this.level;
        }

        //Returns current experience
        public double checkExperience()
        {
            return this.experience;
        }

        public bool checkIfItemInInventory(string item)
        {
            if (this.inventory.Contains(item))
            {
                return true;
            }
            return false;
        }

        public void addItemToInventory(string item)
        {
            inventory.Add(item);
        }

        public void remItemFromInventory(string item)
        {
            inventory.Remove(item);
        }
    }
}
