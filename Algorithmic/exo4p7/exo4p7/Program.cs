using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo4p7 {
  class Program {
    static void Main(string[] args) {
      decimal age = 0;
      int NbAccident = 0;
      decimal permisDepuis = 0;
      bool a_droit = true;
      string strTmp;
      /* better design : mettre les couleurs dans un tableau pour pouvoir 
         ajuster les couleurs en fonction de l'ancienté du client 
      */
      string[] couleurContrat = { "Rouge", "Orange", "Vert", "Bleu" };
      int couleur = 0;

      Console.Write("entrer age : ");
      strTmp = Console.ReadLine();
      age = Convert.ToDecimal(strTmp);

      Console.Write("Vous avez permis depuis quand ?: ");
      strTmp = Console.ReadLine();
      permisDepuis = Convert.ToDecimal(strTmp);

      Console.WriteLine("Avez vous eu des accident , combient : ");
      strTmp = Console.ReadLine();
      NbAccident = Convert.ToInt32(strTmp);

      if(age < 25) {
        if(permisDepuis < 2) // 
        {
          if(NbAccident == 0) {/* tarif rouge */
            couleur = 0; 
            Console.WriteLine("vous avez droit au tarif {0}", couleurContrat[couleur]);
          }
          else {
            Console.WriteLine("Vous etes pas illigible a une assurance chez nous ");
          }
        }
        else {
          switch(NbAccident) {
            case 0:
              couleur = 1;
              Console.WriteLine("Vous avez droit au tarif {1}", couleurContrat[couleur]);
              break;
            case 1:
              couleur = 0;
              Console.WriteLine("Vous avez droit au tarif {0}", couleurContrat[couleur]);
              break;
            default:
              Console.WriteLine("Vous n'etes pas ligible a une assurance chez nous ");
              a_droit = false; 
              break;
          }
        }// if permis < 2
      }// endif age 25

      if(age >= 25) {
        if(permisDepuis < 2) {
          switch(NbAccident) {
            case 0:
              couleur = 1;
              Console.WriteLine("Vous avez droit au tarif {0}", couleurContrat[couleur]);
              break;
            case 1:
              couleur = 0;
              Console.WriteLine("Vous avez droit au tarif {0} ", couleurContrat[couleur]);
              break;
            default:
              Console.WriteLine("Nous n'etes pas illigible a une assurance chez nous");
              break;
          }
        }// if permisDepuis < 2
        else {
          switch(NbAccident) {
            case 0:
              couleur = 2;
              Console.WriteLine("Vous avez droit au tarif {0}", couleurContrat[couleur]);
              break;
            case 1:
              couleur = 1;
              Console.WriteLine("Vous avez droit au tarif {0}", couleurContrat[couleur]);
              break;
            case 2:
              couleur = 0;
              Console.WriteLine("vous avez droit au tarif {0}", couleurContrat[couleur]);
              break;
            default:
              Console.WriteLine("Vous n'etes pas illigible à une assurance chez nous");
              a_droit = false;
              break;
          }
        }
      }

      if(a_droit) {
        Console.WriteLine("Etes vous actuellemnt un client chez nous depuis 5 ans O/N? ");
        strTmp = Console.ReadLine();
        if(strTmp == "O") {
          Console.WriteLine("Cette avantage vous permet de passer en contrat {0}",couleurContrat[++couleur]);
        }
      }
            
    }
  }
}
