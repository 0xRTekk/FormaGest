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
        private String firstName;
        private Session laSessionChoisie;

        //
        //Builders
        //
        public Participant()
        {
            LaSessionChoisie = null;
        }

        public Participant(String Name, String FirstName, Session LaSessionChoisie)
        {
            if (Name is String)
            {
                this.name = Name;
            }

            if (FirstName is String)
            {
                this.firstName = FirstName;
            }
        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public String Name { get; set; }
        public String FirstName { get; set; }
        public Session LaSessionChoisie { get; set; }



        //
        //Public methods & functions
        //
        public String StrParticipant()
        {
            String StrParticipant = "Nom du participant: " + name + ". Prénom du participant: " + firstName;
            return StrParticipant;
        }
    }
}
