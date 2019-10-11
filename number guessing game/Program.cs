using System;

namespace number_guessing_game
{
    class Program
    {
        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success = false;
            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);
            return integerFromUser;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game! The higher your score, the worse you did!");
            int max = GetIntegerFromUser("The lowest number is 1, please input your max number!");
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, max + 1);
            int guess = GetIntegerFromUser($"Please select a number between 1-{max}.");
            int count = 0;
            while (guess != secretNumber)
            {
                while (guess < secretNumber)
                {
                    guess = GetIntegerFromUser($"{guess} is to low, score is {count}");
                    count++;
                }
                while (guess > secretNumber)
                {
                    guess = GetIntegerFromUser($"{guess} is to high, score is {count}");
                    count++;
                }
            }
            Console.WriteLine($"{guess} is right");
        }
    }
}
