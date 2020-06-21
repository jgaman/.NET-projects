using System;

namespace magicNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int magicNumber = 5;
            int nombreUtilisateur = 0;
            int nombreDeVies = 4;

            while (nombreUtilisateur > 0)
            {

      

            Console.WriteLine("Devinez le nombre magique:");
            String resultat = Console.ReadLine();

            if (int.TryParse(resultat, out nombreUtilisateur))
                //La conversion s'est bien passée

            {
                if (nombreUtilisateur < magicNumber)
                {
                    Console.WriteLine("Le nombre magique est plus grand.");
                }
                else if (nombreUtilisateur > magicNumber)
                {
                    Console.WriteLine("Le nombre magique est plus petit.");
                }
                else
                {
                    //egalité on a gagné
                    Console.WriteLine("Bravo: Vous vez trouvé le nombre magique");
                }
            }

        }
    }
    }
}
