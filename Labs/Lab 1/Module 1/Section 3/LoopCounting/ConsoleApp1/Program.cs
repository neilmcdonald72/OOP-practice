using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int z = 1; z <= 5; z++)
            {

                for (int i = 0, x = 0, y = 0; y <= 20; i += x)
                {

                    Console.WriteLine(i);

                    if (i == 0) { x = 1; }

                    if (i == 10) { x = -1; }

                    y++;

                }
            }

        }
    }
}
