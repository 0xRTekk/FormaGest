using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

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
        private String email;
        private int telephone;
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

        public Participant(int Id, String Name, String First_name, String Email, int Telephone, int IdSession)
        {
            id = Id;
            name = Name;
            first_name = First_name;
            email = Email;
            telephone = Telephone;
            idSession = IdSession;
        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public String Name { get; set; }
        public String First_name { get; set; }
        public String Email { get; set; }
        public int Tel { get; set; }
        public int IdSession { get; set; }



        //
        //Public methods & functions
        //
        public String StrParticipant()
        {
            String StrParticipant = "Nom du participant: " + name + ". Prénom du participant: " + first_name;
            return StrParticipant;
        }

        public void Save(Participant participant)
        {
            DbGestionFormation db = new DbGestionFormation();
            db.InitDb();
            //Quand on crée un participant, son id est initialisé à 0
            if (participant.Id == 0)
            {
                db.AddParticipant(participant.Name, participant.First_name, participant.Email, participant.Tel.ToString(), participant.IdSession.ToString());
                //Faire proc server qui retourne l'id du participant ajouté
            }
            else //Si l'id est valorisé, c'est que l'on veut modifier le participant en question
            {
                db.UpdateParticipant(participant.Name, participant.First_name, participant.Email, participant.Tel.ToString(), participant.IdSession.ToString());
                //Faire proc server qui retourne l'id du participant modifié
            }

        }
    }
}
