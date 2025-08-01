using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fighters.Models.Fighters;
using Fighters.Models.Armors;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters;
public static class FighterFactory
{

    public static Fighter CreateFighter()
    {
        Console.WriteLine( "Enter the name of the fighter:" );
        string name = Console.ReadLine();

        var race = ChooseRace();
        var weapon = ChooseWeapon();
        var armor = ChooseArmor();
        var fighter = new Fighter( name, race, weapon, armor );


        PrintFighterStats( fighter );

        return fighter;

    }
    private static void PrintFighterStats( Fighter f )
    {
        Console.WriteLine( $"Name: {f.Name}" );
        Console.WriteLine( $"Race: {f.Race.Name}" );
        Console.WriteLine( $"Weapon: {f.Weapon.Name} (damege: {f.Weapon.Damage})" );
        Console.WriteLine( $"Armor: {f.Armor.Name} (defense: {f.Armor.DefenseDamage})" );
        Console.WriteLine( $"DAMAGE: {f.CalculateDamage()}" );
        Console.WriteLine( $"Health: {f.MaxHealth}" );
    }

    public static IRace ChooseRace()
    {
        var races = new List<IRace>
        {
           new Human(),
           new Witcher()
        };
        Console.WriteLine( "Choose a race:" );
        for ( int i = 0; i < races.Count; i++ )
        {
            Console.WriteLine( $"{i + 1}. {races[ i ].Name}" );
            
        }
        int choice = GetChoice( races.Count );
        return races[choice - 1 ];
    }

    public static IWeapon ChooseWeapon()
    {
        var weapons = new List<IWeapon>
        {
            new Fork(),
            new Pistol(),
            new Woodstick(),
            new NoWeapon()
        };
        Console.WriteLine( "Choose a weapon:" );
        for ( int i = 0; i < weapons.Count; i++ )
        {
            Console.WriteLine( $"{i + 1}. {weapons[ i ].Name}" );
        }
        int choice = GetChoice( weapons.Count );
        return weapons[ choice - 1 ];
    }

    public static IArmor ChooseArmor()
    {
        var armors = new List<IArmor>
        {
            new NoArmor(),
            new LeatherArmor(),
            new DiamondArmor(),
        };
        Console.WriteLine( "Choose an armor:" );
        for ( int i = 0; i < armors.Count; i++ )
        {
            Console.WriteLine( $"{i + 1}. {armors[ i ].Name}" );
        }
        int choice = GetChoice( armors.Count );
        return armors[ choice - 1 ];
    }




    private static int GetChoice( int count )
    {
       while( true )
        {
            Console.Write( "Enter your choice: " );
            if ( int.TryParse( Console.ReadLine(), out int choice ) && choice > 0 && choice <= count )
            {
                return choice;
            }
            Console.WriteLine( $"Please enter a number between 1 and {count}." );
        }
    }

}
    