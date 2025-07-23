using System.Net;

using Casino;

internal class Program
{
    private static void Main( string[] args )
    {
        const string GameName = @"
  ####   #####   #####   #   #   ###   #####
 #      #     #  #       #   #  #   #  #
 #  ##  #     #  #####   #####  #####  #####
 #   #  #     #      #   #   #  #   #      #
  ###    #####   #####   #   #  #   #  #####
";

        PrintGameName( GameName );

        Console.Write( "Please enter amount of money youd like too:" );
        string balanceStr = Console.ReadLine();

        bool isBalanceParsed = int.TryParse( balanceStr, out int balance );

        if ( !isBalanceParsed )
        {
            Console.WriteLine( $"Invalid balance valie entered : {balanceStr}" );
            return;
        }

        if ( balance <= 0 )
        {
            Console.WriteLine( "You are too poor for this game" );
            return;
        }



        Operation? operation = Operation.Initial;

        while ( operation != Operation.Exit )
        {
            Console.WriteLine( "Menu" );
            Console.WriteLine( "1.Play" );
            Console.WriteLine( "2.CheckBalance" );
            Console.WriteLine( "3.Exit" );
            operation = ReadOperation();
            HandleOperation( operation ?? Operation.Initial, ref balance );
        }

        static void PrintGameName( string gameName )
        {
            Console.WriteLine( gameName );
            Console.WriteLine();
        }


        static Operation? ReadOperation()
        {
            string operationStr = Console.ReadLine();
            bool isParsed = Enum.TryParse( operationStr, out Operation operation );
            return isParsed ? operation : null;

        }

        static void HandleOperation( Operation operation, ref int balance )
        {

            switch ( operation )
            {
                case Operation.Initial:
                    return;
                case Operation.Play:
                    Play( ref balance );
                    break;
                case Operation.CheckBalance:
                    Console.WriteLine( $"Your current balance is: {balance}." );
                    break;
                case Operation.Exit:
                    break;
                default:
                    throw new Exception( $"Unsupported operation passed:{operation}" );
            }

        }

        static void Play( ref int balance )
        {
            Console.WriteLine( "Enter bet:" );
            string betstr = Console.ReadLine();

            bool isBetParsed = int.TryParse( betstr, out int bet );

            if ( !isBetParsed || bet <= 0 || bet > balance )
            {

                Console.WriteLine( "Invalid bet.Game is over" );
                return;

            }

            Random random = new Random();
            int randomNum = random.Next( 1, 21 );
            Console.WriteLine( $"Random number is {randomNum}" );

            if ( randomNum >= 18 )
            {

                double multiplicator = 2.5;

                double winbet = bet * ( 1 + multiplicator * randomNum % 17 );

                balance += ( int )winbet;

                Console.WriteLine( $"Congrats. You win {winbet}. Your balance new balance is {balance}" );


            }
            else
            {
                balance -= bet;
                Console.WriteLine( $"You lose , your balance is {balance}" );
            }

        }
    }
}