namespace PersonApi.Models
{

    // An interface for animals
    public interface IAnimal
    {
        void Speak();
    }

    // A class for dogs
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof");
        }
    }

    // A class for cats
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

    // A class for cows
    public class Cow : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Moo");
        }
    }

    // A factory class for animals
    public class AnimalFactory
    {
        // A method to create animals based on a given name
        public IAnimal GetAnimal(string animalName)
        {
            // If the name is dog, return a new dog object
            if (animalName.Equals("dog", StringComparison.OrdinalIgnoreCase))
            {
                return new Dog();
            }
            // If the name is cat, return a new cat object
            else if (animalName.Equals("cat", StringComparison.OrdinalIgnoreCase))
            {
                return new Cat();
            }
            // If the name is cow, return a new cow object
            else if (animalName.Equals("cow", StringComparison.OrdinalIgnoreCase))
            {
                return new Cow();
            }
            // Otherwise, return null
            else
            {
                return null;
            }
        }
    }

}


//To use the factory, we can call the GetAnimal() method:
// Create a factory object
/*
AnimalFactory factory = new AnimalFactory();

    // Get a dog object and call its speak method
    IAnimal dog = factory.GetAnimal("dog");
    dog.Speak();

// Get a cat object and call its speak method
IAnimal cat = factory.GetAnimal("cat");
    cat.Speak();

// Get a cow object and call its speak method
IAnimal cow = factory.GetAnimal("cow");
    cow.Speak();


}*/
