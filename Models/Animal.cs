using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo_Simulator_ASP.Models
{
    public abstract class Animal
    {
        /*public float Health { get; set; }
        public bool IsAlive { get; set; }*/

        private float health = 100;
        private bool isAlive = true;

        public float Health
        {
            get { return health; }
            set { health = value; }
        }

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }

        public void ReduceHealth(int amount)
        {
            Health -= amount;
        }

        public void Feed(int amount)
        {
            Health += amount;

            if (Health > 100)
            {
                Health -= Health % 100;
            }
        }

        public abstract void CheckAlive();


    }
}
