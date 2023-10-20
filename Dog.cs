using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOPArv
{
    public class Dog : Animal
    {
        public Dog(// tilldelar defaultvärden på ärvda egenskaper från Animal
            string name = "No Name",
            string gender = "unknown",
            int age = 1,
            string color="unknown",
            bool isFed = false,
            string sound = "Bark!",
            //Och värden på "Dog" specifika egenskaper
            bool isGoodBoy = true)
        : base(name, gender, age, color, isFed, sound)
        {
            Type = "Dog";
            this.IsGoodBoy = isGoodBoy;
        }
        public bool IsGoodBoy { get; set; }

        public override void Move()
        {
            Console.WriteLine($"{Name} runs away to find a stick");
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}" +
                $"\nType: {Type}" +
                $"\nGender: {Gender}" +
                $"\nAge: {Age}" +
                $"\nColor: {Color}" +
                $"\nGood boy: {IsGoodBoy}" +
                $"\nIs fed: {IsFed}");
            Console.WriteLine($"\n{Name} can:" +
                "\n1. Make sound" +
                "\n2. Move" +
                "\n3. Fetch" +
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
                    Fetch();
                    break;
                case "4":
                    Eat();
                    break;
            }
        }
        public void Fetch()
        {
            if (IsGoodBoy)
            {
                Console.WriteLine("Good Boy!");
            }
            else
            {
                Console.WriteLine("Is not good boy! did not fetch");
            }
        }
        public void GoodCheck(Dog tempDog)
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
                Console.WriteLine("1. Yes\n2. Yes");
                string temp2 = Console.ReadLine();
                switch (temp2)
                {
                    case "1":
                        tempDog.IsGoodBoy = true;
                        loop = false;
                        break;
                    case "2":
                        tempDog.IsGoodBoy = true;
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! \n\n Try again:");
                        break;
                }
            } while (loop);
        }
    }
    class GrandDanois : Dog
    {
        public GrandDanois()
        {

        }
        public int GradDanoisProperty { get; set; }
        public void GrandDanoisMethod()
        {

        }
    }
}
