using System;

namespace Models
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} говорит: Му-у-у!");
        }

        public override void Describe()
        {
            Console.WriteLine($"{Name} — корова. Она даёт молоко.");
        }
    }
}