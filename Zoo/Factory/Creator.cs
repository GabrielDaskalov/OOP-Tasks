using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Factory
{
    public abstract class Creator
    {
        public abstract Animal FactoryMethod();

        public Animal OnCreationSuccess()
        {
            var animal = FactoryMethod();
            Console.WriteLine($"The following animal was created: {animal.GetType().ToString()}");
            return animal;
        }

    }
}
