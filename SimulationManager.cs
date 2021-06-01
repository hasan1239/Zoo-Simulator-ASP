using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Zoo_Simulator_ASP.Models;

namespace Zoo_Simulator_ASP
{
    public class SimulationManager
    {
        private static SimulationManager instance;
        private static readonly object padLock = new object();
        public Simulator simulator;
        public Timer Timer;

        public static SimulationManager Instance
        {
            get
            {
                lock (padLock)
                {
                    return instance ?? (instance = new SimulationManager());
                }
            }
        }

        public Simulator Simulator
        {
            get
            {
                return simulator;
            }
        }

        public void Initialise()
        {
            simulator = new Simulator();
            //Timer = new Timer(Callback, null, 0, 20000);
        }

        /*private void Callback(object state)
        {
            Console.WriteLine("Hi");
        }*/
    }
}
