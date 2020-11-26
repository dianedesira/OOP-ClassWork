using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Dog animal2 = new Dog();
            Cat animal3 = new Cat();
            Duck animal4 = new Duck();

            List<Animal> animals = new List<Animal>();
            //animals.Add(animal1); animals.Add(animal2); animals.Add(animal3); animals.Add(animal4);
            animals.AddRange(new List<Animal> { animal1, animal2, animal3, animal4, new Bird(), new Cow(), new Duck(), new Fish(), new Frog(), new Lion(), new Snake() });
            Console.WriteLine("All Animals");
            foreach (Animal animal in animals)
            {
                // string noiseReturn = animal.Speak();
                // Console.WriteLine(noiseReturn);
                Console.WriteLine("\nType of Animal: " + animal.GetType().Name);
                Console.WriteLine("Noise: " + animal.Speak());
                Console.WriteLine("Movement: "+animal.Move());
                Console.WriteLine("Eat: "+animal.Eat());
            }

            Console.ReadKey();

        }
    }
}
