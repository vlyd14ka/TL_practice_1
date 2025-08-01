using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighters.Models.Weapons;
using Fighters.Models.Armors;
using Fighters.Models.Races;

namespace Fighters.Models.Fighters;
public class Fighter: IFighter
{
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }
    public string Name { get; private set; }
    public IWeapon Weapon { get; private set; }= new NoWeapon();

    public IArmor Armor { get; private set; }=new NoArmor();

    public IRace Race { get; private set; }

    public Fighter (string name, IRace race,IWeapon weapon,IArmor armor)
    {

        Name = name;
        Race = race;
        MaxHealth = race.Health;
        CurrentHealth = MaxHealth;
        Weapon = weapon;
        Armor = armor;

    }
    public int CalculateDamage()
    {
        const double critChance = 0.05;
        double factor = Random.Shared.NextDouble() * 0.3 - 0.2;
        int defaultdamage= Race.Damage + Weapon.Damage;

        double absolutelyDamage=  (int)(defaultdamage * (1 + +factor ));

        bool isCrit = Random.Shared.NextDouble() < critChance;

        if ( isCrit )
        {
            absolutelyDamage *= 3;
            Console.WriteLine( $"{Name} нанес критический удар!" );
        }
        else
        {
            Console.WriteLine( $"{Name} нанес обычный удар." );
        }

        return (int)absolutelyDamage;
    }

    public void TakeDamage( int damage )
    {
        int defense = Armor?.DefenseDamage ?? 0;
        int actualDamage = Math.Max( damage - defense, 0 );

        CurrentHealth -= actualDamage;
        if ( CurrentHealth < 0 )
        {
            CurrentHealth = 0;
        }

        Console.WriteLine( $"{Name} получил {actualDamage} урона . Осталось HP: {CurrentHealth}" );
    }

}
