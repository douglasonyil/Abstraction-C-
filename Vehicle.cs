using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraction
{
    //Abstract Base Class (Abstraction)
    public abstract class Vehicle
    {
        // These are abstract methods; the derived classes will provide the implementation
        public abstract void Start();
        public abstract void Stop();
    }
    //Concrete Implementation
    public class Car : Vehicle
    {
        public override void Start()
        {
            System.Console.WriteLine("Car is starting with a key turn");
        }

        public override void Stop()
        {
            System.Console.WriteLine("Car is stopping using its brakes.");
        }
    }
    public class ElectricTrain : Vehicle
    {
        public override void Start()
        {
            System.Console.WriteLine("Electric train is starting by powering up.");
        }
        public override void Stop()
        {
            System.Console.WriteLine("Electric train is stopping by cutting off the power.");
        }
    }
    
    
}