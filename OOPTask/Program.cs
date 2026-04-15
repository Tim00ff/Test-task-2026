using System;
using System.Collections.Generic;
using Models;

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog("Шарик"),
            new Cat("Мурка"),
            new Cow("Зорька"),
            new Dog("Бобик"),
            new Cat("Васька")
        };

        Console.WriteLine("=== Описание и звуки животных ===\n");
        foreach (var animal in animals)
        {
            animal.Describe();  
            animal.MakeSound(); 
            Console.WriteLine(); //Для красоты
        }
    }
}