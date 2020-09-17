using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public abstract class Animal
    {
        public virtual int HealthPoints { get; set; }

        public virtual bool IsDead { get; set; }


    }
}
