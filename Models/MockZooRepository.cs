using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Zoo_Simulator_ASP.Models
{
    public class MockZooRepository : IZooRepository
    {
        public IEnumerable<Monkey> Monkeys =>
            new List<Monkey>
            {
                new Monkey { Health = 100, IsAlive = true },
                new Monkey { Health = 100, IsAlive = true },
                new Monkey { Health = 100, IsAlive = true },
                new Monkey { Health = 100, IsAlive = true },
                new Monkey { Health = 100, IsAlive = true }
            };

        public IEnumerable<Elephant> Elephants =>
            new List<Elephant>
            {
                new Elephant { Health = 100, IsAlive = true },
                new Elephant { Health = 100, IsAlive = true },
                new Elephant { Health = 100, IsAlive = true },
                new Elephant { Health = 100, IsAlive = true },
                new Elephant { Health = 100, IsAlive = true }
            };

        public IEnumerable<Giraffe> Giraffes =>
            new List<Giraffe>
            {
                new Giraffe { Health = 100, IsAlive = true },
                new Giraffe { Health = 100, IsAlive = true },
                new Giraffe { Health = 100, IsAlive = true },
                new Giraffe { Health = 100, IsAlive = true },
                new Giraffe { Health = 100, IsAlive = true }
            };

        public Simulator Simulator => new Simulator();

        public bool AreAllAnimalsDead()
        {
            bool allGiraffesDead = Giraffes.Where(g => g.IsAlive == true).ToList().Count == 0;
            bool allElephantsDead = Elephants.Where(e => e.IsAlive == true).ToList().Count == 0;
            bool allMonkeysDead = Monkeys.Where(m => m.IsAlive == true).ToList().Count == 0;

            return allGiraffesDead && allElephantsDead && allMonkeysDead;
        }
    }
}
