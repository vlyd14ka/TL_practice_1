public class OrderManager
{
    public static void Main( string[] args )
    {
        OrderProcess();
    }

    public static void OrderProcess()
    {
        string product;
        int count;
        string name;
        string address;
        string answer;
        DateTime todays_date = DateTime.Now;

        do
        {
            Console.Write( "Введите название товара:" );
            product = Console.ReadLine();

            Console.WriteLine( "Введите количество товара:" );
            count = int.Parse( Console.ReadLine() );

            Console.WriteLine( "Введите ваше имя:" );
            name = Console.ReadLine();

            Console.WriteLine( "Введите ваш адрес:" );
            address = Console.ReadLine();


            Console.WriteLine( $"Здравствуйте {name}, Вы заказали {count} {product} на адрес {address},всё верно?" );
            answer = Console.ReadLine();

            if ( answer != "да" )
            {
                Console.WriteLine( "Оформим заказ заново" );
            }

        }

        while ( answer != "да" );

        Console.WriteLine( $"{name}! Ваш заказ {product} в количестве {count} оформлен ! Ожидайте доставку по адресу {address} к {todays_date.AddDays( 3 ):dd.MM.yyyy}" );

    }


}