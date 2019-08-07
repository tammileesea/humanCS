using System;

namespace human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health; 
        public int Health
        {
            get { return health; }
        }
        public Human(string NameInput)
        {
            Name = NameInput;
            Console.WriteLine($"My name is {NameInput}");
            // Strength = 3;
            // Intelligence = 3;
            // Dexterity = 3;
            // health = 100;
            // Console.WriteLine($"My name is {NameInput}, strength: {Strength}, intelligence: {Intelligence}, dexterity: {Dexterity}, health: {health}");
        }

        public Human(string NameInput, int StrengthInput, int IntelligenceInput, int DexterityInput, int HealthInput)
        {
            Name = NameInput;
            Strength = StrengthInput;
            Intelligence = IntelligenceInput;
            Dexterity = DexterityInput;
            health = HealthInput;
            Console.WriteLine($"My name is {NameInput}, strength: {StrengthInput}, intelligence: {IntelligenceInput}, dexterity: {DexterityInput}, health: {HealthInput}");
        }

        public virtual int Attack (Human target)
        {
            int BooBoo = target.health;
            BooBoo -= 5 * Strength;
            Console.WriteLine($"{target.Name} was attacked by {Name} and their health is now {BooBoo}");
            return BooBoo;
        }
    }

    class Wizard : Human
    {
        public new int Strength;
        public new int Intelligence;
        public new int Dexterity;
        protected new int health; 
        public new int Health
        {
            get { return health; }
        }
        public Wizard(string name) : base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 25;
            Dexterity = 3;
            health = 50;
            Console.WriteLine($"My name is {Name}, I am a wizard! strength: {Strength}, intelligence: {Intelligence}, dexterity: {Dexterity}, health: {health}");
        }
        public override int Attack (Human target)
        {
            int healthDamage = 5 * Intelligence;
            target.health -= healthDamage;
            health += healthDamage;
            Console.WriteLine($"{target.Name} was attacked by {Name} and their health is now {target.health}, but {Name}'s health is now {health}");
            return target.health;
        }
        private void Heal (Human target)
        {
            target.health += 10 * Intelligence;
            Console.WriteLine($"{target.Name}'s health is now {target.health}");
        }
    }

    class Ninja : Human
    {
        public new int Strength;
        public new int Intelligence;
        public new int Dexterity;
        protected new int health; 
        public new int Health
        {
            get { return health; }
        }
        public Ninja(string name) : base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 175;
            health = 100;
            Console.WriteLine($"My name is {Name}, I am a ninja! strength: {Strength}, intelligence: {Intelligence}, dexterity: {Dexterity}, health: {health}");
        }
        public override int Attack (Human target)
        {
            int healthDamage = 5 * Dexterity;
            target.health -= healthDamage;
            health += healthDamage;
            Random extraDamage = new Random();
            int i = extraDamage.Next(1, 5);
            if (i == 1)
            {
                target.health -= 10; 
            }

            Console.WriteLine($"{target.Name} was attacked by {Name} and their health is now {target.health}, but {Name}'s health is now {health}");
            return target.health;
        }
        private void Steal (Human target)
        {
            target.health -= 5;
            health += 5;
            Console.WriteLine($"{target.Name}'s health is now {target.health}, and my health is now {health}");
        }
    }

    class Samurai : Human
    {
        public new int Strength;
        public new int Intelligence;
        public new int Dexterity;
        protected new int health; 
        public new int Health
        {
            get { return health; }
        }
        public Samurai(string name) : base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 200;
            Console.WriteLine($"My name is {Name}, I am a samurai! strength: {Strength}, intelligence: {Intelligence}, dexterity: {Dexterity}, health: {health}");
        }
        public override int Attack (Human target)
        {
            int BooBoo = target.health;
            BooBoo -= 5 * Strength;
            if (BooBoo < 50)
            {
                BooBoo = 0;
            }
            Console.WriteLine($"{target.Name} was attacked by {Name} and their health is now {BooBoo}");
            return BooBoo;
        }
        private void Meditate()
        {
            health = 200;
            Console.WriteLine("Health is now back to 200!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Human("Bobby");
            Wizard tam = new Wizard("Tammi");
            Ninja kevin = new Ninja("Kevin");
            Samurai jesus = new Samurai("Jesus");
        }
    }
}
