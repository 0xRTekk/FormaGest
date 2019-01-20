using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormation
{
    class Session
    {
        //Properties
        private int id;
        private string dateBegin;
        private string dateEnd;
        private string place;
        private Formation laFormation;
        private Participant lesParticipants;

        //Construct
        public Session()
        {
            LaFormation = null;
            LesParticipants = null;
        }

        public Session(string TheBegin, string TheEnd, string ThePlace)
        {
            if (TheBegin is string && TheEnd is string && ThePlace is string)
            {
                dateBegin = TheBegin;
                dateEnd = TheEnd;
                place = ThePlace;
            }
        }

        //Getters & Setters
        public int Id { get; set; }
        public string DateBegin { get; set; }
        public string DateEnd { get; set; }
        public string Place { get; set; }
        public Formation LaFormation { get; set; }
        public Participant LesParticipants { get; set; }



        //
        //Public methods & functions
        //
        public string StrSession()
        {
            string StrSession = "L'épreuve de " + laFormation + " se déroulera à " + place + " du " + dateBegin + " au " + dateEnd;
            return StrSession;
        }

        public void deleteParticipant()
        {
            // Call ConnectToDb(), delete Participant from the given id of the Session
        }

        public void save()
        {
            // Call ConnectToDb(), check if there have been any changes & save Session from the given id
        }

        public void delete()
        {
            // Call ConnectToDb(), delete Session from the given id
        }


        //
        //Private methods & functions
        //
        private void ConnectToDb()
        {
            // Connection to the Db
        }
    }
}
