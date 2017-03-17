using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaineDinfo {
    abstract class Journaliste {

        // properties

        /// <summary>
        /// prénom du journaliste  
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// nom du journaliste
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// theme du journaliste 
        /// <exemple>
        /// Sport, politique
        /// </exemple>
        /// </summary>
        public string Theme { get; set; }


        /* --------------------|
        *        method        |
        ---------------------- */
        /// <summary>
        ///  Rédige un srticle avec precision de la date et du sujet.
        ///  doit être impmlementer par les heritiers de cette classe
        /// </summary>
        /// <param name="testDuSujet"></param>
        /// <param name="dateDuSujet"></param>


        /// <returns></returns>
        public abstract Reportage Rediger(string testDuSujet, DateTime dateDuSujet);


    }
}
