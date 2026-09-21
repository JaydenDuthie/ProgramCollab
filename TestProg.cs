using System;

namespace Test
{
    internal class TestProg
    {
        static void Main()
        {
            Random rand = new Random();
            char again = 'y';
            Console.WriteLine("Hello, Please enter your age (in digits): ");
            int UsrAge = Convert.ToInt32(Console.ReadLine());
            if (UsrAge <= 18)
            {
                Console.WriteLine("You are too young to play, you must be 18 or older. Goodbye!");
                again = 'n';
            }
            else
            {
                while (again == 'y')
                {
                    int Cash = 0;
                    int roll = 0;
                    Console.WriteLine("Starting the Game");
                    for (int run = 1; run <= 5; run++)
                    {
                        Console.WriteLine($"Round {run}");
                        roll = rand.Next(1, 14);
                        switch (roll)
                        {
                            case 1:
                                Cash += 20;
                                break;

                            case 11:
                            case 12:
                            case 13:
                                Cash += 10;
                                break;

                            default:
                                Cash -= roll;
                                break;
                        }
                        Console.WriteLine($"you rolled a {roll} and your total cash is {Cash}.\n");
                        Thread.Sleep(600);
                    }
                    Console.WriteLine("Would you like to try again? [y/n]");
                    again = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                }

                Alex();
                Seth();
                Console.ReadLine();
            }
        }

        public static void Alex()
        {
            {
                Random rand = new Random();
                char user, comp;
                int number;

                Console.WriteLine("Please pick either R, P or S: ");
                user = (Console.ReadLine()).ToUpper();
                user = user.ToUpper();
                Console.WriteLine($"{user}");
                user = Convert.ToChar(user);
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
                if (((user == 'R') && (comp == 'S')) || ((user == 'S') && (comp == 'P')) || ((user == 'P') && (comp == 'R')))
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
            Console.WriteLine("Press ENTER key to close");
            Console.ReadLine();
        }
    }
}
