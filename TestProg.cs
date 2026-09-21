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
            //
        }

        public static void Seth()
        {
            //
        }
    }
}
