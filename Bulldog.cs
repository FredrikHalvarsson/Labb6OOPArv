using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOPArv
{
    public class Bulldog : Dog
    {
        public Bulldog(
            string name = "No Name",
            string gender = "unknown",
            int age = 1,
            string color = "unknown",
            bool isFed = false,
            string sound = "Bark!") : base(name, gender, age, color, isFed, sound)
        {
            Type = "bulldog";
            IsGoodBoy = true;
            Sleepy = "Yes";
        }
        public string Sleepy { get; set; }
        public void Drool()
        {
            Console.WriteLine($"{Name} starts drooling");
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nType: {Type}" +
                $"\nGender: {Gender}" +
                $"\nAge: {Age}" +
                $"\nColor: {Color}" +
                $"\nGood boy: {IsGoodBoy}" +
                $"\nIs fed: {IsFed}" +
                $"\nSleepy {Type}? {Sleepy}");
            Console.WriteLine($"\n{Name} can:" +
                "\n1. Make sound" +
                "\n2. Move" +
                "\n3. Fetch" +
                "\n4. Drool" +
                "\n5. Eat");
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
                    Fetch();
                    break;
                case "4":
                    Drool();
                    break;
                case "5":
                    Eat();
                    break;
            }
        }
    }
}
