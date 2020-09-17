
using Zoo.Animals;
using Zoo.Interfaces;

namespace Zoo.Factory
{
    public class ConcreteCreatorMonkey : Creator
    {
        public override Animal FactoryMethod()
        {

            return new Monkey();
        }
    }
}
