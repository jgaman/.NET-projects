using System;

namespace HeroVsMonster
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random dice = new Random();
            int heroLife = 10;
            int velainLife = 10;


            do
            {
                int heroAttack = dice.Next(1, 10);
                velainLife -= heroAttack;
                Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {velainLife} health.");

                if (velainLife <= 0) continue;

                int velainAttack = dice.Next(1, 10);
                heroLife -= velainAttack;
                Console.WriteLine($"Hero was damaged and lost {velainAttack} health and now has {heroLife} health.");

            } while (heroLife > 0 && velainLife > 0);

            Console.WriteLine(heroLife > velainLife ? "Hero wins!" : "Monster wins!");
        }
    }
}
