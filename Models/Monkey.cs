using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zoo_Simulator_ASP.Models
{
    public class Monkey : Animal
    {
        public Monkey()
        {

        }

        public override void CheckAlive()
        {
            if (Health < 30)
            {
                IsAlive = false;
            }
        }
    }
}
