using System;

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
            {
            Random rand = new Random();
            char user, comp;
            int number;

            Console.WriteLine("Please pick either R, P or S: ");
            user = Convert.ToChar(Console.ReadLine());
            number = rand.Next(3);
            switch (number)
            {
                case 0:
                    comp = 'R';
                    break;
                case 1:
                    comp = 'P';
                    break;
                default:
                    comp = 'S';
                    break;
            }
            Console.WriteLine($"The computer has chosen {comp}");
            if (((user == 'R') && (comp == 'S')) || ((user == 'S') && (comp == 'p')) || ((user == 'P') && (comp == 'R')))
            {
                Console.WriteLine("User wins");
            }
            else
            {
                if (user == comp)
                {
                    Console.WriteLine("Draw game");
                }
                else
                {
                    Console.WriteLine("Computer wins");
                }
            }
            Console.WriteLine("Press ENTER key to close");
            Console.ReadLine();
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
