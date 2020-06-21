using System;

namespace nb_magique_console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int nombreDeVies = 0;
            int nombreMagique = 5;
            const int NOMBRE_DE_VIES = 3;

            for (nombreDeVies = NOMBRE_DE_VIES; nombreDeVies > 0; nombreDeVies--)
            {

                Console.Write("Devinez le nombre magique (il vous reste " + nombreDeVies + " vies): ");
                String resultat = Console.ReadLine();

                int nombreUtilisateur = 0;
                if (int.TryParse(resultat, out nombreUtilisateur))
                {
                    // La convertion s'est bien passée

                    if (nombreUtilisateur < nombreMagique)
                    {
                        Console.WriteLine("Le nombre magique est plus grand.");
                    }
                    else if (nombreUtilisateur > nombreMagique)
                    {
                        Console.WriteLine("Le nombre magique est plus petit.");
                    }
                    else
                    {
                        // Egalité : on a gagné
                        Console.WriteLine("BRAVO: Vous avez trouvé le nombre magique");
                        break;
                    }
                }
                else
                {
                    // Erreur de la conversion
                    Console.WriteLine("ERREUR: Vous devez rentrer un nombre.");
                }

                Console.WriteLine("");
            }

            // Sortie de la boucle
            if (nombreDeVies == 0)
            {
                Console.WriteLine("Désolé, vous avez perdu.");
            }
        }
    }
}
