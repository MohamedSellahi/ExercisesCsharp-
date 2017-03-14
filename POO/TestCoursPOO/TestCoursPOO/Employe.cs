namespace TestCoursPOO {
   class Employe {

      /// <summary>
      /// matricule d'identification de l'emplyé
      /// </summary>
      private int matricule;
      /// <summary>
      /// champ statique pour sauvegarder le nombre d'emplye 
      /// </summary>
      private static int _dernierMat = 0;

      // constructor 
      public Employe() {
         matricule = ProchainMatricule();
      }

      private static int ProchainMatricule() {
         return ++_dernierMat;
      }

      public int GetMatricule() {
         return matricule;
      }

      public static int NbEmploye() {
         return _dernierMat;
      }



   }
}