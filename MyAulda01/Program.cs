using System;

namespace MyAulda01
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pl1 = new Player( "bastard");
            Player pl2 = new Player("Jhon_Wick");

            bool loop = true;

            while (loop)
            {
                string input = Console.ReadLine();

                if (input == "1")
                    pl1.Shoot(pl2);
                else if (input == "2")
                    pl2.Shoot(pl1);
                else if (input == "3")
                    loop = !loop;

                Console.WriteLine("Pl1 Hp =" + pl1.Hp);
                Console.WriteLine("Pl2 Hp =" + pl2.Hp);

            }
        }
    }
}
