using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Zoo_Simulator_ASP.Models
{
    public interface IZooRepository
    {
        IEnumerable<Monkey> Monkeys { get; }
        IEnumerable<Elephant> Elephants { get; }
        IEnumerable<Giraffe> Giraffes { get; }
        Simulator Simulator { get; }
        bool AreAllAnimalsDead();
    }
}
