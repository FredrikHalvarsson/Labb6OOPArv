using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOPArv
{
    public abstract class Animal
    {
        //konstruktor (ctor) för att tilldela värden på egenskaper i Animal
        public Animal(string name, string gender, int age, string color, bool isFed, string sound)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Color = color;
            this.IsFed = isFed;
            this.Sound = sound;
        }

        //Skapar egenskaper (prop) för klassen
        public string Name { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public bool IsFed { get; set; }
        public string Sound { get; set; }


        public void MakeSound()
        {
            Console.WriteLine(Sound);
        }
        public abstract void Display();
        public void ShortDisplay()
        {
            Console.WriteLine($"Type: {Type}\t\tName: {Name}\t\tAge: {Age}");
        }
        public bool Eat()
        {
            IsFed = true;

            return IsFed;
        }

        public abstract void Move();
    }
}
