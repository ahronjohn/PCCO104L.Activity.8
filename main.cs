using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cod Ghost = new Cod(105000, "Ghost", "Remington R5", "Hazmat");
            Ghost.Intro();

            Cod AlexMason = new Cod(90000, "Alex Mason", "M4 CQB Rifle", "CIA Agent");
            AlexMason.Intro();

            Cod LevKrachenko = new Cod(89000, "Lev Krachenko", "LK24 Rifle", "Soviet Dragon");
            LevKrachenko.Intro();
        }
    }

    public abstract class Person
    {
        public string Name { get; set; }
        protected string Occupation { get; set; }
        public abstract void Intro();
    }

    public class Cod : Person
    {
        public string Weapon { get; set; }
        public int Bounty { get; set; }
        private string Territory { get; set; }

        public Cod(int bounty, string name, string weapon, string territory)
        {
            Bounty = bounty;
            Name = name;
            Weapon = weapon;
            Territory = territory;
            Occupation = "Cod";
        }

        public override void Intro()
        {
            Console.WriteLine($"Cod {Name} - {Weapon} - Bounty: ${Bounty}, Territory: {Territory}");
        }
    }
}
