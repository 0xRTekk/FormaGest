using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormation
{
    public class Formation
    {
        //
        //Properties
        //
        private int id;
        private String name;
        private int level;
        private List<Session> lesSessions = new List<Session>();

        //
        //Builders
        //
        public Formation()
        {
            this.name = "inconnue";
            this.level = 0;
        }

        public Formation(String Name, int Level)
        {
            if (Name is String)
            {
                this.name = Name;
            }

            if (Level >= 0 && Level <= 10)
            {
                this.level = Level;
            }
        }

        public Formation(String Name)
        {
            if (Name is String)
            {
                this.name = Name;
            }
        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public String Name { get; set; }
        public int Level { get; set; }
        public Session LesSessions { get; set; }



        //
        //Public methods & functions
        //
        public String StrFormation()
        {
            String StrFormation = "La formation " + name + " est de niveau : " + level;
            return StrFormation;
        }

        public void save()
        {
            // Call ConnectToDb(), check if there have been any changes & save Formation from the given id
        }

        public void delete()
        {
            // Call ConnectToDb(), delete Formation from the given id
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
