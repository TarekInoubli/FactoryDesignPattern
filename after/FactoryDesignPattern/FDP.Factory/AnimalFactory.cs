using FDP.Library;

namespace FDP.Factory
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateNew<T>()
        {
            if (typeof(T) == typeof(Dog))
            {
                return new Dog();
            }
            else if (typeof(T) == typeof(Cat))
            {
                return new Cat();
            }

            return null;
        }
    }
}
