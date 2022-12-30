

using System.Runtime.ExceptionServices;

namespace SnakeAndLader
{
    public static class SnakeLader
    {
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
        }
    }
}
