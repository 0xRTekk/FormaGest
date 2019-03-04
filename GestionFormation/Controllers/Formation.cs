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
        private string name;
        private int level;
        private List<Session> lesSessions = new List<Session>();

        //
        //Builders
        //
        public Formation()
        {
            name = "inconnue";
            level = 0;
        }

        public Formation(string LeNom, int Lelevel)
        {
            if (LeNom is string)
            {
                name = LeNom;
            }

            if (Lelevel >= 0 && level <= 10)
            {
                level = Lelevel;
            }
        }

        public Formation(string LeNom)
        {
            if (LeNom is string)
            {
                name = LeNom;
            }
        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Session LesSessions { get; set; }



        //
        //Public methods & functions
        //
        public string StrFormation()
        {
            string StrFormation = "La formation " + name + " est de niveau : " + level;
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
