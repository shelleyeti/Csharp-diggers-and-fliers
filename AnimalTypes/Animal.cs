using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    public class Animal
    {
        public string AnimalName { get; set; }

        public void Clean()
        {
            Console.WriteLine($"It's time to clean the {AnimalName} container.");
        }
    }
}