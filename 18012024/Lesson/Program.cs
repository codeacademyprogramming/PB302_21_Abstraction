using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            

            Cat cat = new Cat();
            cat.Name = "Mestan";
            cat.MakeSound();
            cat.ShowInfo();

            Dog dog = new Dog();
            dog.Name = "Artur";
            dog.MakeSound();
            dog.ShowInfo();

        }
    }
}
