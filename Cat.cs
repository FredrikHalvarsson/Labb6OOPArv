using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOPArv
{
    public class Cat : Animal
    {
        public Cat
            (
            string name = "no name",
            string gender = "unknown",
            int age = 1,
            string color="unknown",
            bool isFed = false,
            string sound = "Mjao!"
            )
            : base(name, gender, age, color, isFed, sound)
        {
            Type = "Cat";
            WantsToPlay = true;
        }
        public bool WantsToPlay { get; set; }
        public override void Move()
        {
            Console.WriteLine($"{Name} has got the zoomies");
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nType: {Type}" +
                $"\nGender: {Gender}" +
                $"\nAge: {Age}" +
                $"\nColor: {Color}" +
                $"\nIs fed: {IsFed}" +
                $"\nWant's to play: {WantsToPlay}");
            Console.WriteLine($"\n{Name} can:" +
                "\n1. Make sound" +
                "\n2. Move" +
                "\n3. Play" +
                "\n4. Eat");

            string temp = Input.ReadInput();
            switch (temp)
            {
                case "1":
                    MakeSound();
                    break;
                case "2":
                    Move();
                    break;
                case "3":
                    Play();
                    break;
                case "4":
                    Eat();
                    break;
            }
        }
        public void Play()
        {
            if (WantsToPlay==true)
            {
                Console.WriteLine($"{Name} plays with a ball of yarn");
            }
            else
            {
                Console.WriteLine($"{Name} does not want to play");
            }
        }
    }
}
