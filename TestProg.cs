using System;

namespace Test
{
    internal class TestProg
    {
        private void Alex()
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
    }
}
