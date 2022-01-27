using FDP.Factory;
using FDP.Library;

IAnimalFactory factory = new AnimalFactory();
//IAnimal dog = new Dog();
var dog = factory.CreateNew<Dog>();
Console.WriteLine(dog.Name);

//IAnimal cat = new Cat();
var cat = factory.CreateNew<Cat>();
Console.WriteLine(cat.Name);
