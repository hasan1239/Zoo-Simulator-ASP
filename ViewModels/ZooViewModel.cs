using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo_Simulator_ASP.Models;

namespace Zoo_Simulator_ASP.ViewModels
{
    public class ZooViewModel
    {
        public IEnumerable<Monkey> Monkeys { get; set; }
        public IEnumerable<Elephant> Elephants { get; set; }
        public IEnumerable<Giraffe> Giraffes { get; set; }
        public Simulator Simulator { get; set; }
    }
}
