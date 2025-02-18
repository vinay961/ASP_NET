using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            this.Name = name;
        }
    }
    class Lion : Animal
    {
        public Lion(string name) : base(name) { }
    }

    class Elephant : Animal
    {
        public Elephant(string name) : base(name) { }
    }

    //Covariance: Accept more derived type
    interface IZoo<out T>
    {
        T GetAnimal();
    }
    class LionZoo : IZoo<Lion>
    {
        public Lion GetAnimal()
        {
            return new Lion("Simba the Lion");
        }
    }
    class ElephantZoo : IZoo<Elephant>
    {
        public Elephant GetAnimal()
        {
            return new Elephant("Dumbo the Elephant");
        }
    }

    // Contravariant Interface: Can accept more general type.
    interface IAnimalComparer<in T>
    {
        void Compare(T x, T y);
    }
    class AnimalNameComparer : IAnimalComparer<Animal>
    {
        public void Compare(Animal x, Animal y)
        {
            Console.WriteLine($"Comparing {x.Name} with {y.Name}");
        }
    }
    class ZooSystem
    {
        //static void Main(string[] args)
        //{
        //    IZoo<Lion> lionZoo = new LionZoo();
        //    IZoo<Animal> animalZoo1 = lionZoo;

        //    Animal animal = animalZoo1.GetAnimal();
        //    Console.WriteLine($"Covariance: Got {animal.Name}");

        //    IZoo<Elephant> elephantZoo = new ElephantZoo();
        //    IZoo<Animal> animalZoo2 = elephantZoo;
        //}
    }
}
