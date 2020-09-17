using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zoo.Animals;
using Zoo.Interfaces;

namespace Zoo
{
    public class ZooDesk
    {

        private Dictionary<Animal, string> animals;
        private Random rnd;

        private ZooDesk()
        {
            animals = new Dictionary<Animal, string>();
            rnd = new Random();
        }

        public static ZooDesk Instance { get; } = new ZooDesk();

        public void AddAnimal(Animal animal)
        {
            this.animals.Add(animal, "L");
        }

        public void GettingHungry()
        {
            foreach (var animal in animals.ToList())
            {
                var value = rnd.Next(0, 20);
                animal.Key.HealthPoints -= value;

                if (animal.Key.IsDead)
                {
                    animals[animal.Key] = "D";

                }
            }

        }

        public void Feed()
        {
            var valueMonkey = rnd.Next(0, 25);
            var valueElephant = rnd.Next(0, 25);
            var valueGiraffe = rnd.Next(0, 25);

            foreach (var animal in animals.ToList())
            {
                var animalType = animal.GetType().ToString().ToLower();

                if (animalType == "monkey")
                {
                    animals[animal.Key] += valueMonkey;

                }
                else if(animalType == "giraffe")
                {
                    animals[animal.Key] += valueGiraffe;
                }
                else if(animalType=="elephant")
                {
                    animals[animal.Key] += valueElephant;
                    
                }
                    

            }

        }

        public int Count => this.animals.Where(t => t.Value == "L").Count();
    }
}
