using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFormation
{
    public partial class UserTicket : Form
    {
        DbGestionFormation db = new DbGestionFormation();

        //PROP
        private User contextUser;
        //BUILDER
        public UserTicket(User ContextUser)
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database

            this.contextUser = ContextUser;
        }
        //GET SET
        public User ContextUser { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            DbGestionFormation db = new DbGestionFormation();
            db.InitDb();
            String libelle = tbLibelle.Text;
            String description = rtbDescription.Text;
            DateTime date_emission = DateTime.Now;
            String etat = "emis";
            int niveau = 1;
            int idUser = contextUser.Id;

            db.CreateTicket(libelle, description, date_emission, etat, niveau, idUser);

            this.Close();
        }
    }
}
