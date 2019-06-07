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
    public partial class AdminApplicationManagement : Form
    {
        private DbGestionFormation db = new DbGestionFormation();
        private List<Participant> contextParticipants = new List<Participant>();
        private List<Formation> contextInterets = new List<Formation>();
        private List<Session> contextSessions = new List<Session>();
        Participant selectParticipant = new Participant();
        Formation interetSelect = new Formation();
        Session selectSession = new Session();


        public AdminApplicationManagement()
        {
            InitializeComponent();
            db.InitDb();
            contextParticipants = db.GetParticipants();
        }

        private void btnAdminView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminApplicationManagement_Load(object sender, EventArgs e)
        {
            //Data binding with List<Participant>
            cbCandidat.DataSource = contextParticipants;
            cbCandidat.DisplayMember = "name";
            cbCandidat.ValueMember = "id";

            //DataGrid binding from Session of Formation selected
            Participant cbParticipant = (Participant)cbCandidat.SelectedItem;
            contextInterets = db.GetFormationsByPartiId(cbParticipant.Id.ToString());
            dgvInterests.DataSource = contextInterets;


            // Personnalisation apparence dataGridView
            dgvInterests.Columns["Id"].Visible = false;
            dgvInterests.Columns["Name"].Width = 131;
            dgvInterests.Columns["Name"].HeaderText = "Formation";

            

        }

        private void cbCandidat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataGrid binding from Session of Formation selected
            selectParticipant = (Participant)cbCandidat.SelectedItem;
            contextInterets = db.GetFormationsByPartiId(selectParticipant.Id.ToString());
            dgvInterests.DataSource = contextInterets;
        }

        private void dgvInterests_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            interetSelect = (Formation)dgvInterests.CurrentRow.DataBoundItem;
            contextSessions = db.GetSessions(interetSelect.Id.ToString());
            dgvSessions.DataSource = contextSessions;

            dgvSessions.Columns["Id"].Visible = false;
            dgvSessions.Columns["Date"].Width = 70;
            dgvSessions.Columns["LaFormation"].Visible = false;
            dgvSessions.Columns["Hour_begin"].HeaderText = "Heure de début";
            dgvSessions.Columns["Hour_begin"].Width = 80;
            dgvSessions.Columns["Hour_end"].HeaderText = "Heure de fin";
            dgvSessions.Columns["Hour_end"].Width = 70;
            dgvSessions.Columns["Place"].HeaderText = "Adresse";
            dgvSessions.Columns["Place"].Width = 202;
        }
        
        private void btnRefus_Click(object sender, EventArgs e)
        {
            selectSession = (Session)dgvSessions.CurrentRow.DataBoundItem;
            AdminCancelApplication adminCancelApplication = new AdminCancelApplication(selectSession, selectParticipant);
            adminCancelApplication.ShowDialog();
            if (adminCancelApplication.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Candidature refusée");
                refreshDGV();
                dgvSessions.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
            }
            else
                adminCancelApplication.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            selectSession = (Session)dgvSessions.CurrentRow.DataBoundItem;
            String refus = null;
            String accepter = "1";
            db.updateCandidater(selectSession.Id.ToString(), selectParticipant.Id.ToString(), accepter, refus);
            MessageBox.Show("Candidature acceptée");
            refreshDGV();
            dgvSessions.CurrentRow.DefaultCellStyle.ForeColor = Color.Green;

        }

        private void refreshDGV()
        {
            dgvSessions.Columns["Id"].Visible = false;
            dgvSessions.Columns["Date"].Width = 70;
            dgvSessions.Columns["LaFormation"].Visible = false;
            dgvSessions.Columns["Hour_begin"].HeaderText = "Heure de début";
            dgvSessions.Columns["Hour_begin"].Width = 80;
            dgvSessions.Columns["Hour_end"].HeaderText = "Heure de fin";
            dgvSessions.Columns["Hour_end"].Width = 70;
            dgvSessions.Columns["Place"].HeaderText = "Adresse";
            dgvSessions.Columns["Place"].Width = 202;
        }
    }
}
