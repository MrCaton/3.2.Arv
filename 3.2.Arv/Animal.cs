using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _3._2.Arv
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; }
        public double Weight { get; }

        //public Animal(string name) => Name = name;
        //public Animal(int age) => Age = age;
        //public Animal(double weight) => Weight = weight;
        //public Animal(string name, int age, double weight)
        //{
        //    Name = name;
        //    Age = age;
        //    Weight = weight;
        //}
        public override string Stats()
        {
            return "Sfe";
        }

    }

    class Horse:Animal
    {
        public string TypeOfHorse { get; }
        public Horse(string typeOfHorse)
        {
            TypeOfHorse = typeOfHorse;
        }
        public string DoSound() => "Iiiiiibrbrbr";
        public override string Stats()
        {
            return "Sfe";
        }
    }
    class Dog : Animal
    {
        public string Race { get; }
        public Dog(string race)
        {
            Race = race;
        }
        public string DoSound() => "Guau guau";
    }
    class Hedgehog : Animal
    {
        public string NrOfSpikes { get; }
        public Hedgehog(string nrOfSpikes)
        {
            NrOfSpikes = nrOfSpikes;
        }
        public string DoSound() => "dfsghgsdfgr";
    }
    class Worm : Animal
    {
        public string IsPoisonous { get; }
        public Worm(string isPoisonous)
        {
            IsPoisonous = isPoisonous;
        }
        public string DoSound() => "...";
    }
    class Wolf : Animal
    {
        public string IsAlpha { get; }
        public Wolf(string isAlpha)
        {
            IsAlpha = isAlpha;
        }
        public string DoSound() => "Auuuuuuu";
    }
    class Bird : Animal
    {
        public int WingSpan { get; }
        public Bird(int wingSpan)
        {
            WingSpan = wingSpan;
        }
        public string DoSound() => "Pio Pio";
    }

    class Pelican : Bird
    {
        public int FishesInMouth { get; }
        public Pelican(int wingSpan,int fishesInMouth):base(wingSpan)
        {
            FishesInMouth = fishesInMouth;
        }   
    }
    class Flamingo : Bird
    {
        public string Color { get; }
        public Flamingo (int wingSpan, string color) : base(wingSpan)
        {
            Color = color;
        }
    }
    class Swan : Bird
    {
        public int LenghtNeck { get; }
        public Swan(int wingSpan, int lenghtNeck) : base(wingSpan)
        {
            LenghtNeck = lenghtNeck;

        }
        public override string Stats(int lenghtNeck)
        {
            return $"The properties are { }";

        }

    }
    interface IPerson<T>
    {
        bool Talk(Wolfman sentence)
        {
            return $"{Sentence}";
        }
    }
    class Wolfman:Wolf
    {
        public string Sentence { get; set; }
        public Wolfman(string isAlpha,string sentence):base(isAlpha)
        {
           Sentence=sentence;
        }
    }
    
}
