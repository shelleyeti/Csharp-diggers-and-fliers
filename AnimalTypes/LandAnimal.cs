using System;

namespace diggers_and_fliers
{
    public class LandAnimal : Animal, IWalker
    {
        public int Feet { get; set; }

        public void Run(int Feet)
        {
            Console.WriteLine($"The {AnimalName} is running with it's {Feet} little feet.");
        }

        public void Walk(int Feet)
        {
            Console.WriteLine($"The {AnimalName} is walking around on {Feet} feet.");
        }
    }
}