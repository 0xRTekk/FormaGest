using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormation
{
    public class Participant
    {
        //
        //Properties
        //
        private int id;
        private String name;
        private String first_name;
        private int idSession;

        //
        //Builders
        //
        public Participant()
        {

        }

        public Participant(String Name, String First_name)
        {
            name = Name;
            first_name = First_name;
        }

        public Participant(int Id, String Name, String First_name, int IdSession)
        {
            id = Id;
            name = Name;
            first_name = First_name;
            idSession = IdSession;

        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public String Name { get; set; }
        public String First_name { get; set; }
        public int IdSession { get; set; }



        //
        //Public methods & functions
        //
        public String StrParticipant()
        {
            String StrParticipant = "Nom du participant: " + name + ". Prénom du participant: " + first_name;
            return StrParticipant;
        }
    }
}
