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
        private List<Session> lesSessions = new List<Session>();

        //
        //Builders
        //
        public Formation()
        {
            this.name = "inconnue";
        }

        public Formation(String Name)
        {
            name = Name;
        }

        //
        //Getters & Setters
        //
        public int Id { get; set; }
        public String Name { get; set; }
        public Session LesSessions { get; set; }



        //
        //Public methods & functions
        //
        public void save()
        {
            // Call ConnectToDb(), check if there have been any changes & save Formation from the given id
        }

        public void delete()
        {
            // Call ConnectToDb(), delete Formation from the given id
        }

    }
}
