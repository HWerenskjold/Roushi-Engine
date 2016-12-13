using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roushi
{
    class StatsPart : Part
    {
        private float health;
        private float maxHealth;
        private float stamina;

        public StatsPart(float health, float stamina)
        {
            this.health = health;
            this.maxHealth = health;
            this.stamina = stamina;
        }

        public float getHealth()
        { return health; }

        public float getMaxHealth()
        { return maxHealth; }

        public void setHealth(float hp)
        {
            if (hp > maxHealth)
                this.health = maxHealth;
            else
                this.health = hp;
        }

        public float getStamina()
        { return stamina; }
    }
}
