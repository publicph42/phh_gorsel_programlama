using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPG
{
    class Character
    {
        public string name = "Default Name";
        public int health = 100;
        public int evadeChance = 20;

        public void TakeDamage(int damageAmount)
        {
            Random rnd = new Random();
            if (evadeChance >= rnd.Next(100))
            {
                this.health -= damageAmount;
            }
        }

    }
}
