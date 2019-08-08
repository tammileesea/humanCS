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
            get 
            { 
                return health; 
            }
            set
            {
                health = value;
            }
        }
        public Human(string NameInput)
        {
            Name = NameInput;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
            Console.WriteLine($"My name is {NameInput}, strength: {Strength}, intelligence: {Intelligence}, dexterity: {Dexterity}, health: {health}");
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
            Console.WriteLine($"Health is {target.health}");
            Console.WriteLine($"Strength is {Strength}");
            // BooBoo = BooBoo - (5 * Strength);
            // Console.WriteLine($"{target.Name} was attacked by {Name} and their health is now {BooBoo}");
            return BooBoo;
        }
    }

    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            health = 50;
            Console.WriteLine($"My name is {Name}, I am a wizard! strength: {Strength}, intelligence: {Intelligence}, dexterity: {Dexterity}, health: {health}");
        }
        public override int Attack (Human target)
        {
            int healthDamage = 5 * Intelligence;
            int targetHealth = target.Health;
            // Console.WriteLine($"target health: {targetHealth}");
            targetHealth -= healthDamage;
            // Console.WriteLine($"Health after damage: {targetHealth}");
            health += healthDamage;
            Console.WriteLine($"{target.Name} was attacked by {Name} and their health is now {targetHealth}, but {Name}'s health is now {health}");
            return targetHealth;
        }

        public void Heal (Human target)
        {
            target.Health += 10 * Intelligence;
            Console.WriteLine($"{target.Name}'s health is now {target.Health}");
        }
    }

    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
            Console.WriteLine($"My name is {Name}, I am a ninja! strength: {Strength}, intelligence: {Intelligence}, dexterity: {Dexterity}, health: {health}");
        }
        public override int Attack (Human target)
        {
            int healthDamage = 5 * Dexterity;
            target.Health -= healthDamage;
            health += healthDamage;
            Random extraDamage = new Random();
            int i = extraDamage.Next(1, 5);
            if (i == 1)
            {
                target.Health -= 10; 
            }

            Console.WriteLine($"{target.Name} was attacked by {Name} and their health is now {target.Health}, but {Name}'s health is now {Health}");
            return target.Health;
        }
        public void Steal (Human target)
        {
            target.Health -= 5;
            health += 5;
            Console.WriteLine($"{target.Name}'s health is now {target.Health}, and my health is now {health}");
        }
    }

    class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            health = 200;
            Console.WriteLine($"My name is {Name}, I am a samurai! strength: {Strength}, intelligence: {Intelligence}, dexterity: {Dexterity}, health: {health}");
        }
        public override int Attack (Human target)
        {
            base.Attack(target);
            if (target.Health < 50)
            {
                target.Health = 0;
            }
            Console.WriteLine($"{target.Name} was attacked by {Name} and their health is now {target.Health}");
            return target.Health;
        }
        public void Meditate()
        {
            health = 200;
            Console.WriteLine($"{Name}'s health is now back to 200!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Human("Bobby", 3, 3, 3, 100);
            Wizard tam = new Wizard("Tammi");
            Ninja henry = new Ninja("Henry");
            Samurai kim = new Samurai("Kim");
            tam.Attack(bob);
            tam.Heal(bob);
            henry.Attack(bob);
            henry.Steal(bob);
            kim.Attack(bob);
            kim.Meditate();
            // Ninja kevin = new Ninja("Kevin");
            // Samurai jesus = new Samurai("Jesus");
        }
    }
}
