using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
  abstract class Personne {
    /// <summary>
    /// nom du salarié
    /// </summary>
    protected string _nom;

    public Personne(string nom) {
      _nom = nom; 
    }

  }
}
