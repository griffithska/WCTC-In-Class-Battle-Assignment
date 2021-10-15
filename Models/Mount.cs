using System;

namespace Battle.Models
{
    public class Mount : ICombatant
    {
        public Mount()
        {
            Name = "Mount";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }

        public void Attack(ICombatant enemy)
        {
            if (Weapon.Power > enemy.Armor.Defense)
                Console.WriteLine($"{Name} attacks {enemy.Name} with its {Weapon.Name}");
            else
                Console.WriteLine($"{enemy.Name} blocks {Name} with his {enemy.Armor.Name}");
        }

        public void Defend(ICombatant enemy)
        {
        }
    }
}