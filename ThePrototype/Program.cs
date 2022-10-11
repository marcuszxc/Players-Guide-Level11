namespace ThePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The pilot, enters a number between 0 and 100: ");
            int Pilot = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Hunter, guess the number.");

            int hunter = 0;

            while (true)
            {
                Console.Write("What is your next guess? ");
                hunter = int.Parse(Console.ReadLine());

                if (hunter < Pilot)
                {
                    Console.WriteLine($"{hunter} is too low.");
                }
                else if (hunter > Pilot) 
                {
                    Console.WriteLine($"{hunter} is too high.");
                }
                else
                {
                    Console.WriteLine("You guessed the number!");
                    break;
                }
            }
        }
    }
}