using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPException {
  class SalarieException: Exception {

    // constructeur
    // appel le constructeur de la classe Exception qui attend une chaine de character 
    // pour initialiser la propriété Message
    private string _message = null;

    public enum SalarieExceptionType {
      InvalidName,
      InvalidMat,
      InvalidSalary,
      InvalidCategory,
      IvalidService
    }

    public SalarieException(Salarie sal, SalarieExceptionType excType ):base(sal.ToString()) {
      switch (excType) {
        case SalarieExceptionType.InvalidName:
          _message = "Le nom du salarié est invalide ";
          break;
        case SalarieExceptionType.InvalidMat:
          _message = "l'immatriculation du salarié est invalide";
          break;
        case SalarieExceptionType.InvalidSalary:
          _message = "Le salaire de peut être que positif";
          break;
        case SalarieExceptionType.InvalidCategory:
          _message = "La categorie de salarie ne peut être que:  1(cadre), 2(techincien), 3(employé)";
          break;
        case SalarieExceptionType.IvalidService:
          _message = "Le service de salarié n'est pas reconnue";
          break;
        default:
          _message = "une erreur est servenue lors de l'initialisation du salarié";
          break;
      }

    }

    public new string ToString() {
      //return base.ToString(); compliqué 
      return _message;
    }

  }
}
