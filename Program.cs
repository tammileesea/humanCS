using System;

namespace human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health; 
        public int Health
        {
            get { return health; }
        }
        public Human(string NameInput)
        {
            Name = NameInput;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string NameInput, int StrenthInput, int IntelligenceInput, int DexterityInput, int HealthInput)
        {
            Name = NameInput;
            Strength = StrenthInput;
            Intelligence = IntelligenceInput;
            Dexterity = DexterityInput;
            health = HealthInput;
        }

        public int Attack (Human target)
        {
            int BooBoo = target.health;
            BooBoo -= 5 * attacker.Strength;
            return BooBoo;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
