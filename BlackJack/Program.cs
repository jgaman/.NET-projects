using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int playerFirstCard = 0;
            int playerSecondCard = 0;

            Random dice = new Random(); //appel de la methode Random

            int bankScore = dice.Next(16, 22);

            Console.WriteLine("🃟🃟🃟 WELCOME TO THE BLACKJACK 🃟🃟🃟");
            Console.WriteLine("  ---------------------------");
            Console.WriteLine("  ---------------------------");
            Console.WriteLine(" ");

            Console.Write(@"Press 'ENTER' to select your first card 🂱: ");
            Console.ReadLine();
            playerFirstCard = dice.Next(1, 22);

            Console.WriteLine(" ");
            Console.WriteLine($@"This is your first card: {playerFirstCard}");


            Console.Write(@"Press 'ENTER' to select your second card 🂱: ");
            Console.ReadLine();
            playerSecondCard = dice.Next(1, 22);

            Console.WriteLine(" ");
            Console.WriteLine($@"This is your second card: {playerSecondCard}");

            playerScore = playerFirstCard + playerSecondCard;

            if ((bankScore > playerScore) || (playerScore > 21))
            {
                Console.WriteLine($"The Bank score was: {bankScore}");
                Console.WriteLine("You lose ! 🂡🂡🂡");
            }

            else
            {
                Console.WriteLine($"The bank Score is: {bankScore}");
                Console.WriteLine(@"🂱🂱🂱 BLACK JACK 🂱🂱🂱");
                Console.WriteLine(" YOU WIN !!!");
            }
            


        }
    }
}
