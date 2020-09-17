using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Animals
{
    public class Giraffe: Animal
    {
        public Giraffe()
        {
            HealthPoints = 100;
        }

        public override bool IsDead => HealthPoints < 50;

    }
}
