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
    public partial class ManagerAddApplication : Form
    {
        private DbGestionFormation db = new DbGestionFormation();
        private List<Formation> contextFormations = new List<Formation>();
        private List<Formation> contextInterest = new List<Formation>();
        private List<Candidater> contextApplications = new List<Candidater>();

        public ManagerAddApplication()
        {
            InitializeComponent();
            db.InitDb();
        }

        private void ManagerAddApplication_Load(object sender, EventArgs e)
        {
            contextFormations = db.GetFormations();
            dgvTraining.DataSource = contextFormations;

            dgvTraining.Columns["Id"].Visible = false;
            dgvTraining.Columns["LesSessions"].Visible = false;
            dgvTraining.Columns["Name"].HeaderText = "Formation";
            dgvTraining.Columns["Name"].Width = 212;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            // Add Participant
            String name = tbName.Text;
            String first_name = tbFirstName.Text;
            String tel = tbTel.Text;
            String mail = tbMail.Text;
            int participantId = db.AddParticipantRtnId(name, first_name, mail, tel);

            // Add Interest list
            foreach (Formation interet in contextInterest)
            {
                db.addInterests(interet.Id.ToString(), participantId.ToString());
            }

            MessageBox.Show("Candidat et souhaits ajoutés");
            this.Close();
        }

        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTraining.SelectedRows)
            {
                var objectFormation = (Formation)dgvTraining.CurrentRow.DataBoundItem;
                Formation uneFormation = row.DataBoundItem as Formation;

                contextInterest.Add(uneFormation);
                contextFormations.RemoveAt(contextFormations.IndexOf(uneFormation));
            }
            refreshDgv();
        }

        private void btnArrowLeft_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInterest.SelectedRows)
            {
                var objectInterest = (Formation)dgvInterest.CurrentRow.DataBoundItem;
                Formation unInteret = row.DataBoundItem as Formation;

                contextFormations.Add(unInteret);
                contextInterest.RemoveAt(contextInterest.IndexOf(unInteret));
            }
            refreshDgv();
        }

        public void refreshDgv()
        {
            dgvTraining.DataSource = null;
            dgvTraining.DataSource = contextFormations;

            dgvInterest.DataSource = null;
            dgvInterest.DataSource = contextInterest;
            dgvInterest.Columns["Id"].Visible = false;
            dgvInterest.Columns["LesSessions"].Visible = false;
            dgvInterest.Columns["Name"].HeaderText = "Formation";
            dgvInterest.Columns["Name"].Width = 212;
        }
    }
}
