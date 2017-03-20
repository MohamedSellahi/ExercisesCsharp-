using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
  class Salarie : Personne, IRemunerable, IComparable<Salarie> {
    /// <summary>
    /// matricule de salarié
    /// </summary>
    protected int _matricule;
    /// <summary>
    /// catégorie de salarié: 
    /// </summary>
    protected int _categorie;
    /// <summary>
    /// les services assurés par la salarié
    /// </summary>
    protected int _service;

    /// <summary>
    /// salaire 
    /// </summary>
    protected double _salaire;

    // membre statique 
    /// <summary>
    /// Conteur de nombre d'instance de la classe Salarié
    /// </summary>
    private static int Count = 0;

    // les methodes
    public virtual void CalculerSalaire() {
      Console.WriteLine("le salaire de " + _nom + " est de " + _salaire);
    }

    // get/set attributs
    public int GetMatricule() {
      return _matricule;
    }
    /// <summary>
    /// permet de definir le salaire. La fonction tests peut implementer un test 
    /// de vcalisation de l'entrée. 
    /// </summary>
    /// <param name="mat">matricule: </param>
    public void SetMatricule(int mat) {
      // TODO: ajout validation d'entrée
      _matricule = mat;
    }

    public static void AjoutSalarie() {
      ++Count;
    }


    // utilisation des propriétés pour get/set

    public int MATRICULE {
      get {
        return _matricule;
      }
      set {
        if (value < 0) {
          Console.WriteLine("matricule ne peut pas êtrenégatif");
        }
        else {
          _matricule = value;
        }
      }
    }
    public double Salaire {
      get {
        return _salaire;
      }
      set {
        if (value < 0) {
          Console.WriteLine("Salaire ne peut pas être négatifs");
        }
        else {
          _salaire = value;
        }
      }
    }
    public string NOM {
      get {
        return _nom;
      }
      set {
        if (value.Length > 20) {
          Console.WriteLine("Le nom éntré n'est et très long");
        }
        else {
          _nom = value;
        }
      }
    }

    public static int NombreSalarie {
      get {
        return Salarie.Count;
      }
      set {
        Count = value;
      }
    }

    // constructeurs 

    public Salarie(string nomSal, int mat, int catg, int serv, double sal) : base(nomSal) {
      _matricule = mat;
      _categorie = catg;
      _service = serv;
      Salaire = sal;
      ++Count;
    }

    // destructeur 
    ~Salarie() {
      Console.WriteLine("Destructeur pour {0}", NOM);
      Salarie.NombreSalarie--;
    }

    /*********************************************************
    **********************************************************
                           TP2
    *********************************************************/
    public override bool Equals(object obj) {
      return (obj is Salarie) && (_nom == ((Salarie)obj)._nom) && (_matricule == ((Salarie)obj)._matricule);
    }

    public override string ToString() {
      StringBuilder str = new StringBuilder();
      str.Append(_nom).Append(": ")
         .Append(_matricule)
         .Append(", ")
         .Append(_categorie)
         .Append(", ")
         .Append(_service)
         .Append(", ")
         .Append(_salaire);
      return str.ToString();
    }

    public override int GetHashCode() {
      return base.GetHashCode();
    }

    // for any ibject 
    public int CompareTo(object obj) {
      if (!(obj is Salarie)) {
        throw new InvalidCastException(String.Format("Argument de type {0} n'est pas comparable avec {0}", obj.GetType().Name, this.GetType().Name));
      }
      return String.Compare(this.NOM, ((Salarie)obj).NOM);
    }

    // for salaire objects 
    public int CompareTo(Salarie other) {
      return String.Compare(this.NOM, other.NOM);
    }


    // TP 5 utilisation d'un interface
    // ajout de l'interface IRemunerable
    // ajout de la class Personne (abstrat), avec un constructeur prenant le nom 


  }
}