using System;

namespace _3._2.Arv
{
    class Program
    {
        static Animal animal = new Animal();
        static void Main(string[] args)
        {
            do //Loop
            {
                PrintMeny();

            } while (true);
            //List<Animal> animals = new List<Animal>
            //{
            //    new Dog("Husky"),
            //    new Wolf("Yes"),
            //    new Bird(13),
            //    new Worm("No")
            //};
            //animal.add
        }

        private static void PrintMeny()
        {
            Console.WriteLine("1. Add new Animal");
            Console.WriteLine("Q. Quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        private static void Add()
        {
            do
            {
                string name =Console.ReadLine();
                if (name == "Q") break; 
                //properties.AddAniaml();

            } while (true);
        }
    }
}
