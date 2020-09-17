
using Zoo.Animals;
using Zoo.Interfaces;

namespace Zoo.Factory
{
    public class ConcreteCreatorElephant : Creator
    {
        public override Animal FactoryMethod()
        {
            return new Elephant();
        }
    }
}
