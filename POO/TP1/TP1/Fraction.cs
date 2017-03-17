using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
  class Fraction {
    private int _num;
    private int _denum;

    public Fraction(int num, int denum) {
      _num = num;
      _denum = denum;
    }

    public override string ToString() {
      return _num + "/" + _denum;
    }


    public override bool Equals(object obj) {
      return (obj is Fraction) && (_num * ((Fraction)obj)._denum == _denum * ((Fraction)obj)._num);
    }

    // deuxième possibilité de Equals

    //public override bool Equals(object obj) {
    //   Fraction fr = obj as Fraction;
    //   //return (_num * ((Fraction)obj)._denum == _denum * ((Fraction)obj)._num);
    //   return (_num * fr._denum == _denum * fr._num);
    //}



  }
}
