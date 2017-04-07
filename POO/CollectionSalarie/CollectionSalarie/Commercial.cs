using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSalarie {
  class Commercial: Salarie {
    double _chiffreAffaire;
    int _commission;

    public int Commission { get { return _commission; } set { _commission = value; } }
    public double ChiffreAffaire { get { return _chiffreAffaire; } set { _chiffreAffaire = value; } }

    public override double SALAIRE {
      get {
        return base.SALAIRE * (1 + _commission / 100.0); 
      }

      set {
        base.SALAIRE = value;
      }
    }


    public Commercial(string nomSal, int mat, int catg, int serv, double sal,
                      int commission, double chiffreAffaire)
                    :base(nomSal,mat,catg,serv,sal) {
      Commission = commission;
      ChiffreAffaire = chiffreAffaire;
    }
  }
}
