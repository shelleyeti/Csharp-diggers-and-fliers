using System;

namespace diggers_and_fliers
{
    public class WaterAnimal : Animal, ISwimmer
    {
        public int Fins { get; set; }

        public void Live()
        {
            Console.WriteLine($"The {AnimalName} lives under the water like a mermaid.");
        }

        public void Swim(int Fins)
        {
            Console.WriteLine($"The {AnimalName} is swimming with it's {Fins} fins.");
        }
    }
}