using Fighters.Models.Fighters;

namespace Fighters;

public static class Battle
{
    public static void StartBattle( Fighter fighter1, Fighter fighter2 )
    {

        Console.WriteLine( "BATTLE STARTED" );
        Console.WriteLine("fighter1: " + fighter1.Name ) ;
        Console.WriteLine("fighter2: " + fighter2.Name );

        int round = 1;

        while(fighter1.CurrentHealth>0 && fighter2.CurrentHealth > 0 )
        {

            Console.WriteLine($"Round{round}");

            int damage1 = fighter1.CalculateDamage();
            Console.WriteLine( $"{fighter1.Name} attacks {damage1}");
            fighter2.TakeDamage( damage1 );


            if ( fighter2.CurrentHealth <= 0 )
            {

                Console.WriteLine( $"{fighter2.Name}is dead" );
                break;
            }
            int damage2 = fighter2.CalculateDamage();
            Console.WriteLine( $"{fighter2.Name} attacks {damage2}" );
            fighter1.TakeDamage( damage2 );


            if ( fighter1.CurrentHealth <= 0 )
            {

                Console.WriteLine( $"{fighter1.Name}is dead" );
                break;
            }
            round++;
          
        }
        Console.WriteLine( "End of the battle" );

        if ( fighter1.CurrentHealth > 0 )
        {
            Console.WriteLine( $" The Winner {fighter1.Name} " );
        }

        else if ( fighter2.CurrentHealth > 0 )
        {
            Console.WriteLine( $" The Winner {fighter2.Name} " );
        }
        else
        {
            Console.WriteLine( $" DRAW " );
        }

    }
   
    
}
