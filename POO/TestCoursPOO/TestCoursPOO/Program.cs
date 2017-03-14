using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCoursPOO {
   class Program {
      static void Main(string[] args) {
         Employe emp1 = new Employe();
         Employe emp2 = new Employe();
         Console.WriteLine(Employe.NbEmploye());

         /****************************************/
         
         Personne p0 = new Personne("Sellahi");
         p0.Afficher();

         p0.IntegrerSociete("Afpa");
         p0.Afficher();

         p0.Nom = "NewName";
         p0.Entreprise = "NewComparny";
         p0.Afficher();

         Personne p1 = new Personne("Dupont", "AFPA_saint Jean de vedas");
         p1.Afficher();

      }
   }
}
