using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Animals
{
    public class Elephant : Animal
    {
        private int healthReducesCount;

        public Elephant()
        {
            healthReducesCount = 0;
            HealthPoints = 100;
        }

        public override bool IsDead => GetReducesCount() > 1;


        private int GetReducesCount()
        {
            var counter = 0;

            if (HealthPoints < 70 && healthReducesCount == 0)
            {
                counter++;
                
            }
            else if(HealthPoints < 70 && healthReducesCount == 1)
            {
                counter++;           
            }

            healthReducesCount += counter;

            return healthReducesCount;
        
        }

    }
}
