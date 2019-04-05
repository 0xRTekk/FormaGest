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
    public partial class GuestView : Form
    {
        private DbGestionFormation db = new DbGestionFormation();
        
        //PROP
        private User contextUser;
        //BUILDER
        public GuestView(User ContextUser)
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database

            this.contextUser = ContextUser;
        }
        //GET SET
        public User ContextUser { get; set; }


        private void GuestView_Load(object sender, EventArgs e)
        {
            //Data binding with List<Formation> contextFormations
            cbFormations.DataSource = db.GetFormations();
            cbFormations.DisplayMember = "name";
            cbFormations.ValueMember = "id";

            //DataGrid binding from Session of Formation selected
            Formation formationObject = (Formation)cbFormations.SelectedItem;
            dgvSessions.DataSource = db.GetSessions(formationObject.Id.ToString());
        }

        private void cbFormations_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataGrid binding from Session of Formation selected
            Formation formationObj = (Formation)cbFormations.SelectedItem;
            dgvSessions.DataSource = db.GetSessions(formationObj.Id.ToString());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserTicket userTicket = new UserTicket(this.contextUser);
            userTicket.ShowDialog();
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            GuestAddApplication guestAddApplication = new GuestAddApplication();
            guestAddApplication.ShowDialog();
        }
    }
}
