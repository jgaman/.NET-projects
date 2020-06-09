using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Emprunt
{
    class Program
    {
        static void Main(string[] args)
        {
            //montant emprunté
            double montant;
            Console.Write("Tapez le montant à emprunter (ex: 10000) :");
            string strMontant = Console.ReadLine();
            if (double.TryParse(strMontant, out montant)==false)
            {
                Console.WriteLine("montant incorrect !");
                Console.ReadLine();
                return;
            }
            montant = Convert.ToDouble(strMontant);

            //taux annuel
            double taux;
            Console.Write("taux (pour 3,2% tapez 3,2) :");
            string srtTaux = Console.ReadLine();
            taux = Convert.ToDouble(srtTaux);

            //durée en années 
            int durée;
            Console.Write("durée en années (ex: 10) :");
            string strDurée = Console.ReadLine();
            durée = Convert.ToInt32(strDurée);

            //montnt du remboursement mensuel
            double échéance = Financial.Pmt(taux / 12, durée * 12, montant);

            //format P=percent N=number C=currency
            Console.WriteLine("mensualité en € {1:C2} avec taux {0:N2}% ", taux, -échéance);
            Console.ReadLine();
                

        }

    }
}
