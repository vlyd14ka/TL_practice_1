using Fighters;

class Program
{
    static void Main()
    {
        Console.WriteLine( "Создание первого бойца:" );
        var fighter1 = FighterFactory.CreateFighter();

        Console.WriteLine( "\nСоздание второго бойца:" );
        var fighter2 = FighterFactory.CreateFighter();


        Battle.StartBattle( fighter1, fighter2 );
    }
}
