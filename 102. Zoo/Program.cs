using System;

namespace _102._Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Animal animal = new Animal(name);
            Reptile reptile = new Reptile(name);
            Mammal mammal = new Mammal(name);
            Lizard lizard = new Lizard(name);
            Snake snake = new Snake(name);
            Gorilla gorilla = new Gorilla(name);
            Bear bear = new Bear(name);
            Console.WriteLine(animal, reptile, mammal, lizard, snake, gorilla, bear);
        }
    }
}
