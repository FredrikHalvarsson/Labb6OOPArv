using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOPArv
{
    public class Chihuahua : Dog
    {
        public Chihuahua(
            string name = "No Name",
            string gender = "unknown",
            int age = 1,
            string color = "unknown",
            bool isFed = false,
            string sound = "Bark!") : base(name, gender, age, color, isFed, sound)
        {
            Type = "chihuahua";
            IsGoodBoy = false;
            IsThatARat = "Yes";
        }
        public string IsThatARat { get; set; }
        public void Shake()
        {
            Console.WriteLine($"{Name} starts shaking uncontrollably");
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nType: {Type}" +
                $"\nGender: {Gender}" +
                $"\nAge: {Age}" +
                $"\nColor: {Color}" +
                $"\nGood boy={IsGoodBoy}");
            Console.WriteLine($"\n{Name} can:" +
                "\n1. Make sound" +
                "\n2. Move" +
                "\n3. Fetch" +
                "\n4. Shake");
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
                    Shake();
                    break;
            }
        }
        public void GoodCheck(Chihuahua tempDog)
            //Can Chihuahua be good boy?
        {
            bool loop = true;
            do
            {
                switch (tempDog.Gender)
                {
                    case "male":
                        Console.WriteLine("Good boy?");
                        loop = false;
                        break;
                    case "female":
                        Console.WriteLine("Good girl?");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! \n\n Try again:");
                        break;
                }
            } while (loop);
            loop = true;
            do
            {
                //No
                Console.WriteLine("1. No\n2. No");
                string temp2 = Console.ReadLine();
                switch (temp2)
                {
                    case "1":
                        tempDog.IsGoodBoy = false;
                        loop = false;
                        break;
                    case "2":
                        tempDog.IsGoodBoy = false;
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! \n\n Try again:");
                        break;
                }
            } while (loop);
        }
    }
}
