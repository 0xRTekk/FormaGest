using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormation
{
    public class Incident
    {
        private int id;
        private String libelle;
        private String description;
        private DateTime date_emission;
        private String date_resolustion;
        private int niveau;
        private String etat;
        private int idUser;

        Incident (int Id, String Libelle)
        {
            this.id = Id;
            this.libelle = Libelle;
        }

        Incident(String theLibelle, String theDescription, DateTime theDateEmi, String theEtat, int theUser)
        {
            this.libelle = theLibelle;
            this.description = theDescription;
            this.date_emission = theDateEmi;
            this.date_resolustion = null;
            this.niveau = 1;
            this.etat = theEtat;
            this.idUser = theUser;
        }


        Incident(String theLibelle, String theDescription, DateTime theDateEmi, String theDateReso, int theNiveau, String theEtat, int theUser)
        {
            this.libelle = theLibelle;
            this.description = theDescription;
            this.date_emission = theDateEmi;
            this.date_resolustion = theDateReso;
            this.niveau = theNiveau;
            this.etat = theEtat;
            this.idUser = theUser;
        }

        public int Id { get; set; }
        public String Libelle { get; set; }
        public String Description { get; set; }
        public DateTime Date_emission { get; set; }
        public String Date_Resolution { get; set; }
        public int Niveau { get; set; }
        public String Etat { get; set; }
        public int IdUser { get; set; }


    }
}
