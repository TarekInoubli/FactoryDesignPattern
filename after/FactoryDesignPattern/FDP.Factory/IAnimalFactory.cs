using FDP.Library;

namespace FDP.Factory
{
    public interface IAnimalFactory
    {
        IAnimal CreateNew<T>();
    }
}