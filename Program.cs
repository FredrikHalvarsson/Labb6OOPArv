using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace Labb6OOPArv
{
    internal class Program
    {
        //Initierar statiska variablar som kommer användas för att tilldela användarens input när ett nytt djur skapas
        static string tempGender="";
        static int tempAge;
        static string tempColor="";

        static bool run = true;

        static void Main()
        {
            //startar en instans av Program och kör metoden med menyn
            Program program = new Program();
            program.Run();
        }
        public void Run()
        {
            //Skapar en instans av klassen med alla djurlistor
            AnimalList animalList = new AnimalList();
            do
            {
                //Skriver ut en meny som använder en switch på användarens input för att navigera
                //Menyerna består av en serie nestlade switchar som vardera står i en egen do(while) loop,
                //varje ny meny börjar med att rensa konsollfönstret för att hålla det snyggt, och inte förvirra användaren.
                Console.Clear();
                Console.WriteLine("ANIMAL PARK \n" +
                    "\n 1. Show list of animals" +
                    "\n 2. Add new animal" +
                    "\n 3. Do something" +
                    "\n 0. Exit" +
                    "\n");
                string temp = Input.ReadInput();
                switch (temp)
                {
                    case "0":
                        //avslutar loopen och därmed avslutar programmet.
                        run = false;
                        break;
                    case "1":
                        //Visar lista på alla djur
                        if (AnimalList.ListLength == 0)
                        {
                            Console.WriteLine("List is empty");
                            Console.WriteLine("\n Press any key to return...");
                            Console.ReadKey();
                        }
                        else
                        {
                            animalList.Print();
                            int x = Input.NumInput();
                            Console.Clear();
                            if (x-1 >= AnimalList.ListLength || x-1<0)
                            {
                                Console.WriteLine($"No animal at nr.{x}");
                                Console.WriteLine("\n Press any key to return...");
                                Console.ReadKey();
                            }
                            else
                            {
                                animalList.Animals[x-1].Display();
                                Console.WriteLine("\n");
                                Console.WriteLine("\n Press any key to continue...");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case "2":
                        bool runNewAnimal = true;
                        do
                        {
                            //yttligare en meny i menyn
                            Console.Clear();
                            Console.WriteLine("Add new animal:\n" +
                            "\n 1. New Dog" +
                            "\n 2. New Cat" +
                            "\n 3. " +
                            "\n 0. Return");
                            string temp3 = Input.ReadInput();
                            switch (temp3)
                            {
                                case "0":
                                    runNewAnimal = false;
                                    break;
                                case "1":
                                    //Skapar en temporär Dog med default värden
                                    Dog tempDog = new Dog();
                                    //Skickar in i en överlagrad metod som tilldelar värden till djuret
                                    AssignAnimalValue(tempDog);
                                    //Lägger till i hundlistan i classen för listor
                                    animalList.Animals.Add(tempDog);
                                    AnimalList.ListLength++;
                                    break;
                                case "2":
                                    Cat tempCat = new Cat();
                                    AssignAnimalValue(tempCat);
                                    animalList.Animals.Add(tempCat);
                                    AnimalList.ListLength++;
                                    break;
                                case "3":
                                    
                                    
                                    break;
                                default:
                                    break;
                            }
                        } while (runNewAnimal);
                        break;
                    case "3":

                        break;
                    default:
                        break;
                }
            } while (run);
        }
        //överlagrad metod som tilldelar rätt värden till ett djur beroende på vilket djur som skickas in
        //denna är för hundar
        public Dog AssignAnimalValue(Dog tempDog)
        {
            Console.WriteLine("Input name:");
            tempDog.Name = Console.ReadLine();
            bool loop = true;
            do
            {
                Console.WriteLine("Select gender: \n 1. male\t2. female");
                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        tempDog.Gender = "male";
                        loop = false;
                        break;
                    case "2":
                        tempDog.Gender = "female";
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input! \n\n Try again:");
                        break;
                }
            } while (loop);
            Console.WriteLine("Input age: ");
            tempDog.Age = Input.NumInput();

            Console.WriteLine("Input color: ");
            tempDog.Color = Console.ReadLine();

            tempDog.GoodCheck(tempDog);
            return tempDog;
        }

        //Överlagring för Katter
        public Cat AssignAnimalValue(Cat tempCat)
        {
            Console.WriteLine("Input name:");
            tempCat.Name = Console.ReadLine();
            Console.WriteLine("Select gender: \n 1. male\t2. female");
            string temp = Console.ReadLine();
            switch (temp)
            {
                case "1":
                    tempCat.Gender = "male";
                    break;
                case "2":
                    tempCat.Gender = "female";
                    break;
                default:
                    break;
            }
            Console.WriteLine("Input age: ");
            tempCat.Age = Input.NumInput();

            Console.WriteLine("Input color: ");
            tempCat.Color = Console.ReadLine();
            return tempCat;
        }
    }
}