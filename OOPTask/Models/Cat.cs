using System;

namespace Models
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит: Мяу-мяу!");
        }

        public override void Describe()
        {
            Console.WriteLine($"{Name} — это кошка. Она любит спать и ловить мышей.");
        }
    }
}