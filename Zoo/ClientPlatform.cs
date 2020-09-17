using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Exceptions;
using Zoo.Factory;
using Zoo.Interfaces;

namespace Zoo
{
    public class ClientPlatform
    {
        public void ChooseActions(ZooDesk zoo)
        {
            var input = Console.ReadLine();

            while (true)
            {
                switch (input)
                {
                    case "feed": zoo.Feed(); break;
                    case "getting hungry": zoo.GettingHungry(); break;
                    case "end": return;
                    default: throw new InvalidActionException("Please enter a valid action (feed/ getting hungry/ end)");

                }

                Console.WriteLine("Please choose action:");
                input = Console.ReadLine();
            }




        }

        public void GenerateAnimals(ZooDesk zoo)
        {
            for (int i = 0; i < 15; i++)
            {

                var input = Console.ReadLine();
                Animal newAnimal;

                switch (input)
                {

                    case "monkey":
                        var monkeyCreator = new ConcreteCreatorMonkey();
                        newAnimal = CreateAnimal(monkeyCreator);
                        break;
                    case "giraffe":
                        var giraffeCreator = new ConcreteCreatorGiraffe();
                        newAnimal = CreateAnimal(giraffeCreator);
                        break;
                    case "elephant":
                        var elephantCreator = new ConcreteCreatorElephant();
                        newAnimal = CreateAnimal(elephantCreator);
                        break;
                    default: throw new InvalidAnimalException("Please enter a valid animal (monkey/ giraffe/ elephant)");

                }

                zoo.AddAnimal(newAnimal);
                Console.WriteLine($"New {newAnimal.GetType().ToString()} is added!");


            }
        }

        private static Animal CreateAnimal(Creator creator)
        {
            return creator.OnCreationSuccess();
        
        }

    }
}
