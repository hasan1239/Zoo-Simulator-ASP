using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Zoo_Simulator_ASP.Models
{
    public class Simulator
    {
        private Zoo zoo;
        private bool simulationStarted = false, isSimRunning = true;
        private int hoursElapsed = 0;

        int cycleTime = 5;
        DateTime lastTime, simTime;
        double elapsedTime;
        Thread simThread;

        public Zoo Zoo
        {
            get { return zoo; }
            set { zoo = value; }
        }

        public bool SimulationStarted
        {
            get { return simulationStarted; }
            set
            {
                simulationStarted = value;
            }
        }

        public bool IsSimRunning
        {
            get { return isSimRunning; }
            set
            {
                isSimRunning = value;
            }
        }

        public string HoursElapsedString
        {
            get { return simTime.ToString(); }
        }

        public int HoursElapsed
        {
            get { return hoursElapsed; }
            set
            {
                hoursElapsed = value;
            }
        }

        public Simulator()
        {
            Zoo = new Zoo();
        }

        public void StartSimulation()
        {
            if (simThread == null)
            {
                simThread = new Thread(delegate () { StartSimulation(DateTime.Now); });
                simThread.Start();
            }
        }

        public void StartSimulation(DateTime startTime)
        {
            lastTime = startTime;
            simTime = DateTime.Now;
            simTime = simTime.AddMinutes(-simTime.Minute);
            simTime = simTime.AddSeconds(-simTime.Second);

            while (IsSimRunning)
            {
                elapsedTime = DateTime.Now.Subtract(lastTime).TotalSeconds;

                if (elapsedTime > cycleTime)
                {
                    HoursElapsed++;
                    simTime = simTime.AddHours(1);

                    UpdateZoo();
                    CheckSimFinished();

                    lastTime = DateTime.Now;
                }
            }
        }

        public void UpdateZoo()
        {
            Zoo.UpdateAnimals();
        }

        public void CheckSimFinished()
        {
            if (Zoo.AllAnimalsDead)
            {
                IsSimRunning = false;
            }
        }
    }
}
