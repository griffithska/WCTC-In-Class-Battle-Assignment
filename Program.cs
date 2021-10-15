using Battle.Models;

namespace Battle
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Create Fighter (instantiate object)
            // Equip Armor (assign values)
            // Equip Weapon (assign values)
            ICombatant fighter = new Fighter();
            fighter.Armor.Defense = 10;
            fighter.Weapon.Power = 10;

            ICombatant horse = new Mount();
            horse.Armor.Defense = 5;
            horse.Weapon.Power = 0;

            // Create Enemy (instantiate object)
            // Equip Armor (assign values)
            // Equip Weapon (assign values)
            ICombatant enemy = new Enemy();
            enemy.Armor.Defense = 8;
            enemy.Weapon.Power = 10;

            // Attack Enemy (execute method)
            fighter.Attack(enemy);
            horse.Attack(enemy);
            
        }
    }
}