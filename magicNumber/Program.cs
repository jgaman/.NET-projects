using System;

namespace nb_magique_console
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int NOMBRE_MAGIQUE_MIN = 5;
            const int NOMBRE_MAGIQUE_MAX = 10;
            Random random = new Random();
            int nombreMagique = random.Next(NOMBRE_MAGIQUE_MIN, NOMBRE_MAGIQUE_MAX);
            const int NOMBRE_DE_VIES = 3;
            int nombreDeVies = NOMBRE_DE_VIES;

            while (nombreDeVies > 0)
            {

                Console.Write("Devinez le nombre magique entre " + NOMBRE_MAGIQUE_MIN + " et " + NOMBRE_MAGIQUE_MAX + " (il vous reste " + nombreDeVies + " vies): ");
                String resultat = Console.ReadLine();

                int nombreUtilisateur = 0;
                if (int.TryParse(resultat, out nombreUtilisateur))
                {
                    // La convertion s'est bien passée

                    if ((nombreUtilisateur < NOMBRE_MAGIQUE_MIN) || (nombreUtilisateur > NOMBRE_MAGIQUE_MAX))
                    {
                        Console.WriteLine("ERREUR: Vous devez rentrer un nombre entre " + NOMBRE_MAGIQUE_MIN + " et " + NOMBRE_MAGIQUE_MAX);
                    }
                    else
                    {
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
                        nombreDeVies--;
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
                Console.WriteLine("Désolé, vous avez perdu, le nombre magique était: " + nombreMagique);
            }
        }
    }
}
