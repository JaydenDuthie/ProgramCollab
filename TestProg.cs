namespace Test
{
    internal class TestProg
    {

        
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Alex();
            Seth();
        }

        public static void Alex()
        {
            //
        }

        public static void Seth()
        {
            Console.WriteLine("Seth's Lab 6! Press enter to run.");
            Console.ReadLine();
            Random rand = new Random();
            int team1 = rand.Next(10);
            int team2 = rand.Next(10);
            Console.WriteLine($"team 1 scored {team1} and your team scored {team2}");

            if (team1 > team2)
            {
                Console.WriteLine("Your team lost");
            }
            if (team1 < team2)
            {
                Console.WriteLine("Your team won");
            }
            else
            {
                Console.WriteLine("You tied");
            }
            Console.ReadLine();
        }
    }
}
