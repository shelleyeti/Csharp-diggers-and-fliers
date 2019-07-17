using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create one (or more if you like) instances of each type of animal and each container. Then add the animals to their corresponding container.
            var horse = new LandAnimal() { AnimalName = "Horse" };
            var spider = new LandAnimal() { AnimalName = "Spider" };

            var robin = new SkyAnimal() { AnimalName = "Robin" };
            var blueJay = new SkyAnimal() { AnimalName = "Blue Jay" };

            var shark = new WaterAnimal() { AnimalName = "Hammer Head Shark" };
            var dolphin = new WaterAnimal() { AnimalName = "Bottle Nose Dolphin" };


            var WalkContainer = new WalkContainer();
            WalkContainer.Walkers = new List<IWalker> { horse, spider };

            var FlyContainer = new FlyContainer();
            FlyContainer.Fliers = new List<IFlier>() { robin, blueJay };

            var SwimContainer = new SwimContainer();
            SwimContainer.Swimmers = new List<ISwimmer> { shark, dolphin };

            spider.Run(8);
            horse.Walk(4);
            robin.Clean();
            blueJay.Fly("blue");
            shark.Live();
            dolphin.Swim(2);

        }
    }
}
