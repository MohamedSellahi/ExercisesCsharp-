using System;

namespace TestCoursPOO {
   class Personne {
      /// <summary>
      /// le nom de la personne 
      /// </summary>
      private string _nom;
      /// <summary>
      /// la société dans laquelle la personne travaille si il y en a 
      /// </summary>
      private string _societe;

      /// <summary>
      /// constructeur d-un objet personne de société inconnue
      /// </summary>
      /// <param name="nom">le nom de la personne</param>
      public Personne(string nom) {
         this._nom = nom.ToUpper();
         this._societe = "?";
      }

      public Personne(string nom, string entreprise) {
         this.Nom = nom;
         this.Entreprise = entreprise;
      }

      /// <summary>
      /// Définire l'entreprise dans laquelle la personne travaille
      /// </summary>
      /// <param name="entreprise"></param>
      public void IntegrerSociete(string entreprise) {
         this._societe = entreprise;
      }
      /// <summary>
      /// afficher les charateristiques de la personne
      /// </summary>
      public void Afficher() {
         Console.Write("Je m'appelle " + _nom);
         if (this._societe.Equals("?"))
         {
            Console.WriteLine(" et je ne suis pas salarié.");
         }
         else
         {
            Console.WriteLine(" et je travaille chez " + this._societe);
         }
      }

      // 
      public string LireSociete() {
         return _societe;
      }

      public void ChangerSociete(string entreprise) {
         this._societe = entreprise;
      }

      // Utilisation des Properties:
      public string Nom {
         get { // accesseur en lectre 
            return this._nom;
         }
         set {// accessor en affectation
            this._nom = value;
         }
      }

      public string Entreprise {
         get {
            return this._societe;
         }
         set {
            this._societe = value;

         }
      }




   }
}