using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
  class Commercial : Salarie {


    double _chiffreAffaire;
    int _commission;


    public Commercial(string nomSal, int mat, int catg, int serv, double sal, int commission) : base(nomSal, mat, catg, serv, sal) {
      COMMISSION = commission;
    }

    // methodes

    public override void CalculerSalaire() {
      Console.WriteLine("le salaire de " + _nom + " est de " + _salaire * (1 + _commission));
    }


    // propriétés
    public double CHIFFREAFFAIRE {
      get {
        return _chiffreAffaire;
      }
      set {
        _chiffreAffaire = value;
      }
    }

    public int COMMISSION {
      get {
        return _commission;
      }
      set {
        if (value > 100) {
          Console.WriteLine("Valeur commission pas valide: commission > 100");
        }
        else {
          _commission = value;
        }
      }
    }




  }
}
