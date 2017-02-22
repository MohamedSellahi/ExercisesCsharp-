using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo8p7 {
  class Program {
    static void Main(string[] args) {
      int nRow = 8, nCol = 8;
      int iPion = 0, jPion = 0;
      int iPrev = iPion, jPrev = jPion;
      
      char[,] dammier = new char[8, 8];
      int i, j;
      for(i = 0; i < nRow; i++) {
        for(j = 0; j < nCol; j++) {
          dammier[i, j] = 'O'; 
        }
      }

      bool isInside = true;
      bool gameIson = true;
      int movement; 

      while(gameIson) {

        Console.WriteLine("Entrer la position du pion (ligne, colonne) : ");
        /* normalement il faut valider la saisie */
        iPion = Convert.ToInt32(Console.ReadLine());
        jPion = Convert.ToInt32(Console.ReadLine());

        if((iPion < nRow) && (jPion < nCol)) {
          /* on commence le jeu */
          /* affichage de dammier */
          if(iPion == 5) {
            iPrev = 0;
          }
          else {
            iPrev = 5;
          }

          if(jPrev == 5) {
            jPrev = 0;
          }
          else {
            jPrev = 5;
          }
          

          Afficherdamier(dammier, iPion, jPion, iPrev, jPrev);
          do {
            Console.WriteLine("Quelle mouvement:");
            Console.WriteLine("0 - Haut gauche");
            Console.WriteLine("1 - Haut droite");
            Console.WriteLine("2 - bas gauche");
            Console.WriteLine("3 - bas droit");

            movement = Convert.ToInt32(Console.ReadLine());
            switch(movement) {
              case 0 :
                iPrev = iPion--; ;// on sauvgarde la position : ca sert a donner une nouvelle chanche 
                jPrev = jPion--;
                if((iPion > -1) && (iPion < nRow) && (jPion > -1 ) && (jPion < nCol)) { // on est dans la damier ?
                  Afficherdamier(dammier, iPion, jPion, iPrev, jPrev);
                }
                else {
                  Console.WriteLine("movement pas possible");
                  isInside = false; 
                }
                break;
              case 1:
                iPrev = iPion--;
                jPrev = jPion++;
                if((iPion > -1) && (iPion < nRow) && (jPion > -1) && (jPion < nCol)) { // on est dans la damier ?
                  Afficherdamier(dammier, iPion, jPion, iPrev, jPrev);
                }
                else {
                  Console.WriteLine("movement pas possible");
                  isInside = false;
                }
                break;

              case 2:
                iPrev = iPion++;
                jPrev = jPion--;
                if((iPion > -1) && (iPion < nRow) && (jPion > -1) && (jPion < nCol)) { // on est dans la damier ?
                  Afficherdamier(dammier, iPion, jPion, iPrev, jPrev);
                }
                else {
                  Console.WriteLine("movement pas possible");
                  isInside = false;
                }
                break;
              case 3:
                iPrev = iPion++;
                jPrev = jPion++;
                if((iPion > -1) && (iPion < nRow) && (jPion > -1) && (jPion < nCol)) { // on est dans la damier ?
                  Afficherdamier(dammier, iPion, jPion, iPrev, jPrev);
                }
                else {
                  Console.WriteLine("movement pas possible");
                  isInside = false;
                }
                break;

              default:
                Console.WriteLine("Entrée non valide \n");
                break;
            }


            /* donner une deuxième chance on cas de debordement */
            if(!isInside) {
              Console.Write("voullez vous essayer une nouveau movement (O pour reesayer):  ");
              string tmp = Console.ReadLine();
              if(tmp == "O") {
                iPion = iPrev;
                jPion = jPrev;
                isInside = true;
              }
              else {
                Console.WriteLine("A bientot! ");
                gameIson = false; 
              }
            }
            
          } while(isInside);

        }
        else {
          Console.WriteLine("Entrée non valide: voulez vous reéssayer : O/N: ");
          string tmp = Console.ReadLine();
          if(tmp != "O") {
            Console.WriteLine("A bientot! ");
            break;
          }  
        }

      }








      
      
      
      
      
      






    }

    /* affichage damier */
    public static void Afficherdamier(char[,] Dammier, int iPion, int jPion, int iPrev, int jPrev) {

      Console.Write("   | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7  |\n");
      Console.Write("------------------------------------|\n");
      int nRow = 8, nCol = 8;
      int i, j;

      if((iPion < nRow ) && (jPion < nCol )) {
        Dammier[iPion, jPion] = 'X';
        Dammier[iPrev, jPrev] = 'O';
      }

      for(i =0; i < nRow; i++) {
        Console.Write(" {0} |", i);
        for(j = 0; j < nCol; j++) {
          Console.Write(" {0}  ", Dammier[i,j]);
        }
        Console.WriteLine("|");
      }
      Console.Write("------------------------------------+\n");
    }

  }
}
