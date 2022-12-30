
namespace SnakeAndLader
{
    public static class SnakeLader
    {
        public const int Ladder = 1;
        public const int Snake = 2;
        public static void displayData()
        {
            int Position = 0;
            int player1;
            int die_Roll = 0;
            Console.WriteLine("Initila Position Of Player1 is: " + Position);
            Random random = new Random();
            die_Roll = random.Next(1, 7);

            Console.WriteLine("Die_Roll: " + die_Roll);

            Position = die_Roll;

            Console.WriteLine("After The Die_Roll Player1 Position is: " + Position);

            int options = random.Next(0, 3);
            Console.WriteLine("After getting Random Option is :" + options);

            //using switch case to check options
            switch (options)
            {
                case Ladder:
                    Console.WriteLine("In option we getting Ladder");
                    Position += die_Roll;
                    Console.WriteLine("New position1 after getting Ladder :" + Position);
                    break;

                case Snake:
                    Console.WriteLine("In option player getting by snake");
                    Position -= die_Roll;
                    Console.WriteLine("\"New position1 after snake bit :" + Position);

                    //check if position is zero after snake bit then given position zero
                    if (Position < 0)
                        Position = 0;
                    Console.WriteLine("Player position1 after snake bit need to start from initial position : " + Position);
                    break;

                default:
                    Console.WriteLine("In option we got No play :" + Position);
                    break;


            }
        }
    }
}
