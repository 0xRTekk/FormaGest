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

        //
        //Builders
        //
        public Formation()
        {
            this.name = "inconnue";
        }

        public Formation(int Id, String Name)
        {
            id = Id;
            name = Name;
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
    }
}
