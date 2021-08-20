using System;

namespace ConsoleApp
{
    
    class Animel
    {
        public string name;
        public int age;
        public int height;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animel dog = new Animel();
            Animel cat = new Animel();


            dog.name = "Dog";
            dog.age = 2;
            dog.height = 50;


            cat.name = "Cat";
            cat.age = 3;
            cat.height = 30;

            Console.WriteLine($"Name: {dog.name}; Age: {dog.age}; Height: {dog.height}");
            Console.WriteLine($"Name: {cat.name}; Age: {cat.age}; Height: {cat.height}");

        }
    }
}
