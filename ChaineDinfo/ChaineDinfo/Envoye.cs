using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfo {
    class Envoye: Journaliste {
        // properties 
        /// <summary>
        /// zone d'affectation
        /// </summary>
        public string LieuDaffectation { get; set; }
        /// <summary>
        /// Décrit le poste de l'envoyer
        /// </summary>
        public Poste PosteDelenvoye { get; set; }

        public Reportage Filmer() {
            Console.WriteLine("Je filme un reportage");
            Reportage repo = new Reportage();
            repo.sujetDuReportage = "Final pétanque 2017";
            return repo;
        }

        // 
        public override Reportage Rediger(string testDuSujet, DateTime dateDuSujet) {
            Console.WriteLine("Je redige un reportage");
            Reportage repo = new Reportage();
            repo.sujetDuReportage = "un sujet";
            return repo;
        }

    }
}
