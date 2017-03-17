using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfo {
    class Program {
        static void Main(string[] args) {

            Envoye maurice = new Envoye();
            maurice.Nom = "Dupont";
            maurice.Prenom = "maurice";
            maurice.Theme = "Pethanque";
            maurice.PosteDelenvoye = Poste.cameraman;
            
            Reportage finalDePetanque = maurice.Filmer();
            Reportage finalDePetanqueRapport = maurice.Rediger("test", DateTime.Today);

        }
    }
}
