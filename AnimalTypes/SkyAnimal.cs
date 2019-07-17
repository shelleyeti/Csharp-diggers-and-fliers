using System;

namespace diggers_and_fliers
{
    public class SkyAnimal : Animal, IFlier
    {
        public string Wing { get; set; }

        public void Eat()
        {
            Console.WriteLine($"The {AnimalName} eating bird foods.");
        }

        public void Fly(string Wing)
        {
            Console.WriteLine($"The {AnimalName} is flying around with it's {Wing} wings.");
        }
    }
}