using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormation
{
    class User
    {
        //
        //Properties
        //
        private int id;
        private String login;
        private String pass;
        private String role;
        private DateTime heurePremiereCo;
        private int tentativeCo;
        private int demandeChangePass;

        //
        //Builders
        //
        public User()
        {
            this.login = "Inconnue";
            this.pass = "Inconnue";
            this.role = "Inconnue";
            this.heurePremiereCo = DateTime.Now;
            this.tentativeCo = 0;
            this.demandeChangePass = 0;
        }

        public User(String theLogin, String thePass, String theRole, DateTime premiereCo, int nbTentativeCo, int changePassDemande)
        {
            this.login = theLogin;
            this.pass = thePass;
            this.role = theRole;
            this.heurePremiereCo = premiereCo;
            this.tentativeCo = nbTentativeCo;
            this.demandeChangePass = changePassDemande;
        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public String Login { get; set; }
        public String Pass { get; set; }
        public String Role { get; set; }
        public DateTime HeurePremiereCo { get; set; }
        public int TentativeCo { get; set; }
        public int DemandeChangePass { get; set; }
    }
}
