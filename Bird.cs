using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOPArv
{
    public class Bird : Animal
    {
        public Bird
            (
            string name = "no name",
            string gender = "unknown",
            int age = 1,
            string color = "unknown",
            bool isFed = false,
            string sound = "Chirp!",
            bool canTalk = true
            )
            : base(name, gender, age, color, isFed, sound)
        {
            Type = "Bird";
            CanTalk = canTalk;
        }
        public bool CanTalk { get; set; }
        public override void Move()
        {
            Console.WriteLine($"{Name} flies around the room");
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nType: {Type}" +
                $"\nGender: {Gender}" +
                $"\nAge: {Age}" +
                $"\nColor: {Color}" +
                $"\nCan talk: {CanTalk}");
            Console.WriteLine("\n{Name} can:" +
                "\n1. Make sound" +
                "\n2. Move" +
                "\n3. Talk");

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
                    Talk();
                    break;
            }
        }
        public void Talk()
        {
            if (CanTalk = true)
            {
                Console.WriteLine($"{Name} says hello");
            }
            else
            {
                MakeSound();
                Console.WriteLine($"{Name} can't talk");
            }
        }
    }
}
