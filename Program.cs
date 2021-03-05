using System;

namespace RouletteGame
{
    class Program
    {
        enum colors: short { red, black, green };

        class RouletteGame
        {
            public short[][] RouletteNumbers = new short[3][];
            Random bucket = new Random();
            public static int bucketValue = 0;
            public static int numberofBuckets = 38;
            
            public RouletteGame()
            {
                RouletteNumbers[0] = new short[] { 0, 100 };
                RouletteNumbers[1] = new short[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
                RouletteNumbers[2] = new short[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            }
            public static int Spin(RouletteGame r)
            {
                int column = r.bucket.Next(0, 10000) % 3;
                int value = r.bucket.Next(0, 10000) % r.RouletteNumbers[column].Length;
                return bucketValue= r.RouletteNumbers[column][value];
            }

        }
        static void Main(string[] args)
        {
            RouletteGame r = new RouletteGame();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(RouletteGame.Spin(r));
            }
        }
    }
}
