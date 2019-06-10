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
            if (adminAddSession.DialogResult == DialogResult.OK)
                refreshDgv();
            else
                adminAddSession.Close();
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
            if (adminEditSession.DialogResult == DialogResult.OK)
                refreshDgv();
            else
                adminEditSession.Close();
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

            refreshDgv();
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
            refreshDgv();

        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            AdminAddTraining adminAddTraining = new AdminAddTraining();
            adminAddTraining.ShowDialog();
            if(adminAddTraining.DialogResult == DialogResult.OK)
            {
                cbTraining.DataSource = db.GetFormations();
                cbTraining.DisplayMember = "name";
                cbTraining.ValueMember = "id";
                MessageBox.Show("Formation ajoutée");
            }
            else
            {
                adminAddTraining.Close();
            }
        }



        //
        //Public functions
        //
        public void refreshDgv()
        {
            dgvSessions.DataSource = null;
            dgvSessions.DataSource = db.GetSessions(contextFormation.Id.ToString());

            dgvSessions.Columns["Id"].Visible = false;
            dgvSessions.Columns["Id"].Width = 200;
            dgvSessions.Columns["LaFormation"].Visible = false;
            dgvSessions.Columns["Hour_begin"].HeaderText = "Heure de début";
            dgvSessions.Columns["Hour_begin"].Width = 130;
            dgvSessions.Columns["Hour_end"].HeaderText = "Heure de fin";
            dgvSessions.Columns["Hour_end"].Width = 130;
            dgvSessions.Columns["Place"].HeaderText = "Adresse";
            dgvSessions.Columns["Place"].Width = 222;
        }
    }
}
