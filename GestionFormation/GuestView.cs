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
        
        //
        //PROPS
        //
        private User contextUser;

        //
        //BUILDER
        //
        public GuestView(User ContextUser)
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database

            this.contextUser = ContextUser;
        }
        //
        //GET SET
        //
        public User ContextUser { get; set; }

        //
        //FUNCTIONS
        //
        private void GuestView_Load(object sender, EventArgs e)
        {
            //Data binding with List<Formation> contextFormations
            cbFormations.DataSource = db.GetFormations();
            cbFormations.DisplayMember = "name";
            cbFormations.ValueMember = "id";

            //DataGrid binding from Session of Formation selected
            Formation formationObject = (Formation)cbFormations.SelectedItem;
            dgvSessions.DataSource = db.GetSessions(formationObject.Id.ToString());

            // Personnalisation apparence dataGridView
            dgvSessions.Columns["Id"].Visible = false;
            dgvSessions.Columns["LaFormation"].Visible = false;
            dgvSessions.Columns["Hour_begin"].HeaderText = "Heure de début";
            dgvSessions.Columns["Hour_end"].HeaderText = "Heure de fin";
            dgvSessions.Columns["Place"].HeaderText = "Adresse";
            dgvSessions.Columns["Place"].Width = 270;
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

        private void button1_Click(object sender, EventArgs e)
        {
            FooBar f = new FooBar();
            f.ShowDialog();
        }
    }
}
