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

        //
        //Builders
        //
        public User()
        {
            this.login = "Inconnue";
            this.pass = "Inconnue";
            this.role = "Inconnue";
        }

        public User(String theLogin, String thePass, String theRole)
        {
            this.login = theLogin;
            this.pass = thePass;
            this.role = theRole;
        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public String Login { get; set; }
        public String Pass { get; set; }
        public String Role { get; set; }
    }
}
