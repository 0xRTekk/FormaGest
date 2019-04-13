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
        private int hour_begin;
        private int hour_end;
        private String place;
        private Formation laFormation;
        private List<Participant> lesParticipants;


        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int HourBegin { get; set; }
        public int HourEnd { get; set; }
        public String Place { get; set; }
        public Formation LaFormation { get; set; }
        public List<Participant> LesParticipants { get; set; }


        //
        //Builders
        //
        public Session()
        {
            this.date = Date;
            this.hour_begin = HourBegin;
            this.hour_end = HourEnd;
            this.place = Place;
        }

        public Session(DateTime Date, int HourBegin, int HourEnd, String Place)
        {
            this.date = Date;
            this.hour_begin = HourBegin;
            this.hour_end = HourEnd;
            this.place = Place;
        }

        public Session(DateTime Date, int HourBegin, int HourEnd, String Place, Formation Formation)
        {
            this.date = Date;
            this.hour_begin = HourBegin;
            this.hour_end = HourEnd;
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
