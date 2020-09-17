
using Zoo.Animals;
using Zoo.Interfaces;

namespace Zoo.Factory
{
    public class ConcreteCreatorGiraffe : Creator
    {
        public override Animal FactoryMethod()
        {
            return new Giraffe();

        }
    }

}
