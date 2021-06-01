using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo_Simulator_ASP.Models
{
    public class Giraffe : Animal
    {
        public Giraffe()
        {

        }

        public override void CheckAlive()
        {
            if (Health < 50)
            {
                IsAlive = false;
            }
        }
    }
}
