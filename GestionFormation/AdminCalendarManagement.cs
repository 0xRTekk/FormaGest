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
    public partial class AdminCalendarManagement : Form
    {
        private Session contextSession = new Session();
        private Formation contextFormation = new Formation();
        private DbGestionFormation db = new DbGestionFormation();

        public AdminCalendarManagement()
        {
            InitializeComponent();
            db.InitDb();
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            contextFormation = (Formation)cbTraining.SelectedItem;

            AdminAddSession adminAddSession = new AdminAddSession(contextFormation);
            adminAddSession.ShowDialog();
        }

        //
        //Passer l'objet session selectionné dans la dgvSessions en parametre
        //
        private void btnEditSession_Click(object sender, EventArgs e)
        {
            contextFormation = (Formation)cbTraining.SelectedItem;
            contextSession = (Session)dgvSessions.CurrentRow.DataBoundItem;

            AdminEditSession adminEditSession = new AdminEditSession(contextSession, contextFormation);
            adminEditSession.ShowDialog();
        }

        private void btnAdminView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminCalendarManagement_Load(object sender, EventArgs e)
        {
            //Data binding with List<Formation>
            cbTraining.DataSource = db.GetFormations();
            cbTraining.DisplayMember = "name";
            cbTraining.ValueMember = "id";

            //DataGrid binding from Session of Formation selected
            contextFormation = (Formation)cbTraining.SelectedItem;
            dgvSessions.DataSource = db.GetSessions(contextFormation.Id.ToString());
        }

        private void cbTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataGrid binding from Session of Formation selected
            contextFormation = (Formation)cbTraining.SelectedItem;
            dgvSessions.DataSource = db.GetSessions(contextFormation.Id.ToString());
        }

        private void btnRemoveSession_Click(object sender, EventArgs e)
        {
            contextSession = (Session)dgvSessions.CurrentRow.DataBoundItem;
            db.DeleteSession(contextSession.Id.ToString());

            MessageBox.Show("Session supprimée");
            dgvSessions.DataSource = null;
            dgvSessions.DataSource = db.GetSessions(contextFormation.Id.ToString());

        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            AdminAddTraining adminAddTraining = new AdminAddTraining();
            adminAddTraining.ShowDialog();
        }
    }
}
