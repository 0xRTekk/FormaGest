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
        private string name;
        private string firstName;
        private Session laSessionChoisie;

        //
        //Builders
        //
        public Participant()
        {
            LaSessionChoisie = null;
        }

        public Participant(string LeNom, string LePrenom, Session LaSession)
        {
            if (LeNom is string)
            {
                name = LeNom;
            }

            if (LePrenom is string)
            {
                firstName = LePrenom;
            }
        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public Session LaSessionChoisie { get; set; }



        //
        //Public methods & functions
        //
        public string StrParticipant()
        {
            string StrParticipant = "Nom du participant: " + name + ". Prénom du participant: " + firstName;
            return StrParticipant;
        }

        public void save()
        {
            // Call ConnectToDb(), check if there have been any changes & save Participant from the given id
        }

        public void delete()
        {
            // Call ConnectToDb(), delete Participant from the given id
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
