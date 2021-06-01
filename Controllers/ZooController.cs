using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Zoo_Simulator_ASP.Models;
using Zoo_Simulator_ASP.ViewModels;

namespace Zoo_Simulator_ASP.Controllers
{
    public class ZooController : Controller
    {
        /*Simulator simulator;
        private readonly IZooRepository _zooRepository;

        public ZooController(IZooRepository zooRepository)
        {
            _zooRepository = zooRepository;
        }*/

        public ZooController()
        {

        }

        public RedirectToActionResult FeedAnimals()
        {
            SimulationManager.Instance.Simulator.Zoo.FeedAnimals();

            return RedirectToAction("Simulation");
        }

        public ViewResult Simulation()
        {
            /*if (simThread == null && simulator == null)
            {
                simulator = new Simulator();
                simThread = new Thread(delegate () { simulator.StartSimulation(); });
                simThread.Start();
            }*/

            /*ZooViewModel zooViewModel = new ZooViewModel();
            zooViewModel.Elephants = _zooRepository.Elephants;
            zooViewModel.Monkeys = _zooRepository.Monkeys;
            zooViewModel.Giraffes = _zooRepository.Giraffes;
            zooViewModel.Simulator = _zooRepository.Simulator;*/

            //zooViewModel.Simulator.StartSimulation();

            if (SimulationManager.Instance.Simulator.SimulationStarted == false)
            {
                SimulationManager.Instance.Simulator.SimulationStarted = true;
                SimulationManager.Instance.Simulator.StartSimulation();
            }

            return View(SimulationManager.Instance.Simulator);
        }
    }
}
