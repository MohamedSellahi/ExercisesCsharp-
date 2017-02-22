using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo11p10 {
  class Program {
    static void Main(string[] args) {
      int[,] sodokuAleatoire = new int[9,9];

      // solved sodoku
      int[,] sodoku = { {9,6,3, 1,7,3, 2,5,8},
                        {1,7,8, 3,2,5, 6,4,9},
                        {2,5,4, 6,8,9, 7,3,1},

                        {8,2,1, 4,3,7, 5,9,6},
                        {4,9,6, 8,5,2, 3,1,7},
                        {7,3,5, 9,6,1, 8,2,4},

                        {5,8,9, 7,1,3, 4,6,2},
                        {3,1,7, 2,4,6, 9,8,5},
                        {6,4,2, 5,9,8, 1,7,3}
                      };


      /* Test affichage sousBlock
      int[] SB = CopySousBlock(sodoku, 0,1);

      for(int i = 0; i < 3; i++) {
        for(int j = 0; j < 3; j++) {
          Console.Write("{0} ", SB[3 * i + j]);
        }
        Console.WriteLine();
      }
      */

      // remplir grille 


      RempliGrilleRandom(sodokuAleatoire);
      AfficherGrille(sodoku);

      afficherGrilleCouleur(sodokuAleatoire, true);

      afficherGrilleCouleur(sodoku, false);
      afficherGrilleCouleur(sodoku, true);




     
      int nLigne = 0;
      int sbi = 0;
      int sbj = 0;

      if(!VerfieLignes(sodoku, ref nLigne)) {

        Console.WriteLine("ligne {0} contient chiffre répété", nLigne);
      }
      else {
        Console.WriteLine(" pas de chifre répété dans les lignes ");
      }

      /******Verification des colonnes */

      if(!VerifieColonnes(sodoku, ref nLigne)) {

        Console.WriteLine("colonne {0} contient chiffre répété", nLigne);
      }
      else {
        Console.WriteLine(" pas de chifre répété dans les colonnes ");
      }

      /**** verification des sous block ***/


      if(!VerifieSousBlocks(sodoku, ref sbi, ref sbj)) {

        Console.WriteLine("sousBlock ({0},{1}) contient une répétition", sbi, sbj);
      }
      else {
        Console.WriteLine("pas de chiffre répété. ");
      }


    }






    // remplir le soduku avec des chiffres aléatoire
    public static void RempliGrilleRandom(int[,] grille) {
      Random rnd = new Random();

      for(int i = 0; i < grille.GetLength(0); i++) { // dim 0 is rows 
        for(int j = 0; j < grille.GetLength(1); j++) {
          grille[i, j] = rnd.Next(1, 9);
        }
      }
    }

    // verifie une ligne si il n y pas de répétition:  la fonction renvoie:  true en cas 
    // de no répétition et false en cas de répétition  

    public static bool TousDifferent(int[] tab) {

      for(int i = 0; i < tab.Length; i++) {

        for(int j = i+1; j < tab.Length; j++) {
          if(tab[i] == tab[j])
            return false;
        }
        
      }
      return true;
    }


    // Verifie lignes : fonctions qui verifie toutes les lignes   
    public static bool VerfieLignes(int[,] grille, ref int nLigne) {
      int[] tmpTab;

      for(int i = 0; i < grille.GetLength(0); i++) {
        tmpTab = CopyLigne(grille, i);

        if(!TousDifferent(tmpTab)) {// il ya repitition : Diffirent = false.        
          nLigne = i;
          return false;
        }

      }

      nLigne = -1;
      return true;
    }

    // verifie colonne: verifie toutes le colonnes pour non répétition
    public static bool VerifieColonnes(int[,] grille, ref int nLigne) {
      int[] tmpTab;

      for(int i = 0; i < grille.GetLength(1); i++) {
        tmpTab = CopyColumn(grille, i);

        if(!TousDifferent(tmpTab)) {
          nLigne = i;        
          return false;
        }
      }

      nLigne = -1;
      return true; 
    }

    // verification d'un seul sous block 
    public static bool VerifieSousBlock(int[,] grille, int sbI, int sbJ) {
      int[] tmpTab = CopySousBlock(grille, sbI, sbJ);

      if(!TousDifferent(tmpTab)) {
        return false;
      }
      return true;
    }


    // verfication des tous les sous blocks: I,J
    // la vérification s'arrete au premier sous block contenant une répitions 
    public static bool VerifieSousBlocks(int[,] grille, ref int sbI, ref int sbJ) {
      int[] tmpTab;
      int dim = grille.GetLength(0)/3;

      for(int i = 0; i < dim; i++) {
        for(int j = 0; j < dim; j++) {
          tmpTab = CopySousBlock(grille, i, j);
          if(!TousDifferent(tmpTab)) {
            sbI = i;
            sbJ = j;
            return false;
          }
        }

      }

      sbI = -1;
      sbJ = -1;
      return true;
    }



    // fonction pour copier une ligne dans un tableau 1D a partir d'un tableau 2D 
    public static int[] CopyLigne(int[,] grille, int nLigne) {

      int dim1 = grille.GetLength(1); // colomn number
      int[] Ligne = new int[dim1];

      for(int i = 0; i < dim1; i++) {
        Ligne[i] = grille[nLigne, i];
      }
      return Ligne;
    }

    // fonction pour copier une column dans un tableau 1D a partir d'un tableau 2D
    public static int[] CopyColumn(int[,] grille, int nLigne) {

      int dim0 = grille.GetLength(0); // row number
      int[] col = new int[dim0];
      for(int i = 0; i < dim0; i++) {
        col[i] = grille[i, nLigne];
      }

      return col;

    }


    // Copy sous-block : (I,J) : avec I(J) : 0 1 2 
    public static int[] CopySousBlock(int[,]grille, int I, int J) {
      int dim = grille.GetLength(0)/3;
      int[] tmp = new int[dim*3];

      for(int i = 0 ; i < dim; i++) {

        for(int j = 0; j < dim; j++) {
          tmp[j + 3 * i] = grille[3 * I + i, 3 * J + j];
        }
      }



      return tmp;
    }



    // afficher la grille

    public static void AfficherGrille(int[,] grille) {
      for(int i = 0; i < grille.GetLength(0); i++) {// dim 0 is rows 
        if(i % 3 == 0) {
          Console.WriteLine("+-------+-------+-------+");
        }
        for(int j = 0; j < grille.GetLength(1); j++) {
          if(j % 3 == 0)
            Console.Write("| ");
          Console.Write("{0} ", grille[i,j]);
        }
        Console.WriteLine("|");
      }
      Console.Write("");
      Console.WriteLine("+-------+-------+-------+");
    }


    // affichage en couleur de la grille: 
    // Jaune répétition dans la ligne 
    // orange répétition ligne colummns
    // répition block

    public static int[,] genererGrilleScore(int[,] grille) {

      int dim0 = grille.GetLength(0);
      int dim1 = grille.GetLength(1);
      int[,] grilleScore = new int[dim0, dim1];

      // scores des lignes 

      for(int i = 0; i < dim0; i++) {// scoring 
        int[] tmp = CopyLigne(grille, i);
        int[] score = scoreLine(tmp);

        for(int j = 0; j < dim1; j++) { // remplir la première ligne des scores 
          grilleScore[i, j] += score[j];
        }

      }

      // score des colonne

      for(int j = 0; j < dim1; j++) {
        int[] tmp = CopyColumn(grille, j);
        int[] score = scoreLine(tmp);
        for(int i = 0; i < dim0; i++) {
          grilleScore[i, j] += score[i]; 
        }
      }

      // scores des sousBlock
// TODO add score block
      

      // limiter la valeur max de score à 3
      for(int i = 0; i < dim0; i++) {
        for(int j = 0; j < dim1; j++) {
          if(grilleScore[i, j] > 3)
            grilleScore[i, j] = 3;
        }
      }

      return grilleScore;
    }

    public static void afficherGrilleCouleur(int[,] grille, bool legend) {

      if(legend) {
        Console.WriteLine("----------------------------------");
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.Write("  ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine(" : Ou moins un répétition par ligne");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("  ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine(" : Ou moins un répétition par ligne et par colonne");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("  ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine(" : Ou moins un répétition par ligne et par colonne et par sougrille");
        Console.WriteLine();
      }

      int[,] score = genererGrilleScore(grille);
      ConsoleColor[] colors = { ConsoleColor.Black, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Red };

      for(int i = 0; i < grille.GetLength(0); i++) {// dim 0 is rows 
        if(i % 3 == 0) {
          Console.WriteLine("+-------+-------+-------+");
        }
        for(int j = 0; j < grille.GetLength(1); j++) {
          if(j % 3 == 0)
            Console.Write("| ");

          Console.BackgroundColor = colors[score[i, j]];
          if(colors[score[i, j]] != ConsoleColor.Black) {
            Console.ForegroundColor = ConsoleColor.Black;
          }
          Console.Write("{0} ", grille[i, j]);
          if(colors[score[i, j]] != ConsoleColor.Black) {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
          }
         
          Console.BackgroundColor = colors[0];  // back to black
        }
        Console.WriteLine("|");
      }
      Console.Write("");
      Console.WriteLine("+-------+-------+-------+");
      Console.WriteLine();
      Console.WriteLine("-----------------------------");
      Console.WriteLine();
    }
    


    public static int[] scoreLine(int[] L) {
      int len = L.Length;
      int[] score = new int[len];
      int[] finalScore = new int[len];

      for(int i = 1; i < 10; i++) {
        for(int j = 0; j < len; j++) {
          if(L[j] == i) {
            score[i - 1]++;
          }
        }
      }

      for(int i = 0; i < len; i++) { // -1
        if(score[i] != 0)
          --score[i];
      }
      /* */

      for(int i = 0; i < len; i++) {
        finalScore[i] = score[L[i] - 1];
      }

      return finalScore; 
    }





  }
}
