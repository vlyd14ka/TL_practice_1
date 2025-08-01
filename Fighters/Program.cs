using Fighters;

class Program
{
    static void Main()
    {
        Console.WriteLine( "Create 1 fighter:" );
        var fighter1 = FighterFactory.CreateFighter();

        Console.WriteLine( "\nCreate 2 fighter:" );
        var fighter2 = FighterFactory.CreateFighter();


        Battle.StartBattle( fighter1, fighter2 );
    }
}
