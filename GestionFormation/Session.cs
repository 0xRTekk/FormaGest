using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormation
{
    public class Session
    {
        //
        //Properties
        //
        private int id;
        private DateTime date;
        private string hour_begin;
        private string hour_end;
        private string place;
        private Formation laFormation;
        private List<Participant> lesParticipants;


        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Hour_begin { get; set; }
        public string Hour_end { get; set; }
        public string Place { get; set; }
        public Formation LaFormation { get; set; }
        public List<Participant> LesParticipants { get; set; }


        //
        //Builders
        //
        public Session()
        {
            /*this.date = Date;
            /*this.hour_begin = HourBegin;
            this.hour_end = HourEnd;*/
            //this.place = Place;
        }

        public Session(int Id, DateTime Date, string Hour_begin, string Hour_end, string Place)
        {
            id = Id;
            this.date = Date;
            this.hour_begin = Hour_begin;
            this.hour_end = Hour_end;
            this.place = Place;
        }

        public Session(DateTime Date, string Hour_begin, string Hour_end, string Place, Formation Formation)
        {
            this.date = Date;
            this.hour_begin = Hour_begin;
            this.hour_end = Hour_end;
            this.place = Place;
            this.laFormation = Formation;
        }




        //
        //Public methods & functions
        //
        public string StrSession()
        {
            string StrSession = "L'épreuve de " + laFormation + " se déroulera à " + place + " du " + hour_begin + " au " + hour_end;
            return StrSession;
        }
    }
}
