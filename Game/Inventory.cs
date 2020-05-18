using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Inventory
    {
        public int Money = 0;
        public int Wood = 0;
        public int Water = 10;

        public Inventory()
        { }

        public void AddMoney(int Money)
        {
            this.Money += Money;
        }
        public int GetMoney()
        {
            return this.Money;
        }
        public int GetWood()
        {
            return this.Wood;
        }
        public int GetWater()
        {
            return this.Water;
        }
        public string GetInventory()
        {
            string inv = "Money: " + Money + "\n" + "Wood: " + Wood + "\n" + "Water: " + Water + "\n";
            return inv;
        }
    }
}

