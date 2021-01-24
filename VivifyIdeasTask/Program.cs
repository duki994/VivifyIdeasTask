using System;
using VivifyIdeasTask.Game;

namespace VivifyIdeasTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var sim = new GameSimulation();
            sim.SimulateGame();

            sim.SimulateWeaponDropAndPickup();

            sim.SimulateDropAndPickupByOtherHero();
        }
    }
}
