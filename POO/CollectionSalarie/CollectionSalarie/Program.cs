using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSalarie {
  class Program {
    static void Main(string[] args) {

      Salarie s1 = new Salarie("colaborateur1", 1, 2, 3, 100);
      Salarie[] salTab = new Salarie[5];
      Commercial[] comTab = new Commercial[5];
      

      // Creer un tableaux de salarié
      for (int i = 0; i < salTab.Length; i++) {
        salTab[i] = new Salarie("Colabo" + i, i, 1, 2, i * 100);
      }

      // Creer un tableau de commercial
      for (int i = 0; i < comTab.Length; i++) {
        comTab[i] = new Commercial("Colabo" + i, i, 1, 2, i * 100, 5, i * 1000);
      }

      foreach (var item in salTab) {
        Console.WriteLine("{0} touche {1}, matricule: {2}", item.NOM, item.SALAIRE,item.MATRICULE);
      }

      Console.WriteLine();
      foreach (var item in comTab) {
        Console.WriteLine("{0} touche {1}, matricule: {2}", item.NOM, item.SALAIRE, item.MATRICULE);
      }

      // 
      List<Salarie> listSalarie = new List<Salarie>();

      foreach (var item in salTab) {
        listSalarie.Add(item);
      }

      foreach (var item in comTab) {
        listSalarie.Add(item);
      }

      // affichage de la list
      Console.WriteLine("\nAffichage de la liste");
      foreach (var item in listSalarie) {
        Console.WriteLine("{0} touche {1}, matricule: {2}", item.NOM, item.SALAIRE, item.MATRICULE);
      }

      // Utilisation d'un dictionnaire pour stoquer les salariés 

      SortedDictionary<int, Salarie> dictSal = new SortedDictionary<int, Salarie>();

      for (int i = 0; i < 5; i++) {
        dictSal.Add(listSalarie[i].MATRICULE, listSalarie[i]);
      }

      Console.WriteLine("------------------------------");
      foreach (KeyValuePair<int,Salarie> item in dictSal) {
        Console.WriteLine("{0} touche {1}, matricule: {2}", item.Value.NOM, item.Value.MATRICULE, item.Key);
      }

     
      



    }
  }
}
