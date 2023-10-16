using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb6OOPArv
{
    public class AnimalList
    {
        public List<Animal> Animals = new List<Animal>();
        public static int ListLength=0;
        public Animal CheckType(int x)
        {
            if (Animals[x].Type == "Cat")
            {
                var cat = (Cat)Animals[x];
                return cat;
            }
            else if (Animals[x].Type == "Chihuahua")
            {
                var chihuahua = (Chihuahua)Animals[x];
                return chihuahua;
            }
            else if (Animals[x].Type == "Bulldog")
            {
                var bulldog = (Bulldog)Animals[x];
                return bulldog;
            }
            else if (Animals[x].Type == "Bird")
            {
                var bird = (Bird)Animals[x];
                return bird;
            }
            else
            {
                var dog = (Dog)Animals[x];
                return dog;
            }
        }
        public void Print()
        {
            int tempNr = 1;
            Console.WriteLine("\nAnimals:\n");
            foreach (var i in Animals)
            {
                Console.Write($"{tempNr}. ");
                i.ShortDisplay();
                tempNr++;
            }
        }

    }
}
