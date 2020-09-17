using System;
using Zoo.Exceptions;
using Zoo.Factory;
using Zoo.Interfaces;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var zoo = ZooDesk.Instance;
            var clientPlatform = new ClientPlatform();

            //client code for generating animals
            Console.WriteLine("Please choose animal:");
            clientPlatform.GenerateAnimals(zoo);

            //client code for choosing actions - getting hungry or feeding
            Console.WriteLine("Please choose action:");

            clientPlatform.ChooseActions(zoo);

            Console.WriteLine("Number of animals still alive:");
            Console.WriteLine(zoo.Count);


        }

       
    }
}
