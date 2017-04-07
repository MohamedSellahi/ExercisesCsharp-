using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSalarie {
  class Pers {
    private int _matricule;
    private string _nom;
    private int _age;

    public int Matricule { get { return _matricule; } set { _matricule = value; } }
    public string Nom { get { return _nom; } set { _nom = value; } }
    public int Age { get { return _age; } set { _age = value; } }

    public Pers(int mat, string nom, int age) {
      Matricule = mat;
      Nom = nom;
      Age = age;
    }

    public override string ToString() {
      return String.Format("{0} est agé de {1} ans", Nom, Age);
    }


  }
}
