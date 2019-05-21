using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormation
{
    class Candidater
    {
        //
        //PROPS
        //
        private int session_id;
        private int participant_id;
        private int accepter;
        private string motif_refus;

        //
        //GET SET
        //
        public int Session_id { get; set; }
        public int Participant_id { get; set; }
        public int Accepter { get; set; }
        public string Motif_refus { get; set; }

        //
        //BUILDERS
        //
        public Candidater()
        {
            session_id = 0;
            participant_id = 0;
            accepter = 0;
        }

        public Candidater(int Session_id, int Participant_id, int Accepter, string Motif_refus)
        {
            session_id = Session_id;
            participant_id = Participant_id;
            accepter = Accepter;
            motif_refus = Motif_refus;
        }
    }
}
