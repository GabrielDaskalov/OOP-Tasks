using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Animals
{
    public class Monkey: Animal
    {
        public Monkey()
        {
            HealthPoints = 100;
        }

        public override bool IsDead => HealthPoints < 30;

    }
}
