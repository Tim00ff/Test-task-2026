using System;

namespace Models
{
    public abstract class Animal
    {
        protected string _name;
        public string Name => _name;
		
        protected Animal(string name)
        {
            _name = name;
        }

        public abstract void MakeSound();
        public virtual void Describe()
        {
            Console.WriteLine($"Это животное по имени {Name}");
        }
    }
}