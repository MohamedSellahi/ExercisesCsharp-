using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4p6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Tockens;
            decimal highScore = 0;
            int candidatFavori = 0;

            Console.WriteLine("entrer les scores des 4 candidats: ");
            /* normalement on  vérifie la validité des entrés */

            Tockens = Console.ReadLine().Split();
            int nbCandidat = Tockens.Count();
            decimal[] scores = new decimal[nbCandidat];

            if (nbCandidat != 4)
            {
                Console.WriteLine("Entrés non valide");
                System.Environment.Exit(1);
            }
            else
            {
                for (int i = 0; i < nbCandidat; i++)
                {
                    scores[i] = decimal.Parse(Tockens[i]);
                }

                /* la somme des scores doit être 100%*/
                decimal somme = 0;
                for (int i = 0; i < nbCandidat; i++)
                {
                    somme += scores[i];
                }
                if (somme != 100) // 
                {
                    Console.WriteLine("Entrées non valid: somme score != 100%");
                    System.Environment.Exit(0);
                }


            }

            /* chercher pour un un président dès le premier tour */

            for (int i = 0; i < nbCandidat; i++)
            {
                if (scores[i] >= 50)
                {
                    Console.WriteLine("le candidat {i} serait président dès le premier tour");
                    System.Environment.Exit(0);
                }
                else // classer les candidats 
                {
                    if (scores[i] > highScore)
                    {
                        highScore = scores[i];
                        candidatFavori = i;
                    }
                }
            }

            /* pas de candidat élu dès le premier tour */
            /* tester if candiadt 0 et favori*/
            if (scores[0] > 12 )
            {
                Console.WriteLine("candidat serait au deuxième tour");
                if(scores[0] == highScore)
                {
                    Console.WriteLine("et il se trouve en ballotage favorable");
                }
            }

            



        }
    }
}
