using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void check(Personne p)
        {
            bool test = p is Personne;
            if (test == true)
            {
                string res = p.ToString();


                switch (res)
                {
                    case "Employee": Console.WriteLine("Un Employee"); break;
                    case "Etudiant": Console.WriteLine("Un Etudiant"); break;
                    case "Personne": Console.WriteLine("Une Personne"); break;
                    default: Console.WriteLine("On s'est pas"); break;
                }
            }
            else
                Console.WriteLine("Une refrence sur null");


        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Exercice 1 ");

            Personne p1 = new Personne();
            Etudiant e1 = new Etudiant();
            Employe emp1 = new Employe();

            check(emp1);   // Employe
            //check(e1);
            //check(p1);

            Personne p = null;
            check(p);  // reference sur null
            Console.ReadKey();

        }
    }
}
