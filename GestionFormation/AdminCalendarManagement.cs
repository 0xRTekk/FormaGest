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
        private DbGestionFormation db = new DbGestionFormation();

        public AdminCalendarManagement()
        {
            InitializeComponent();
            db.InitDb();
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            AdminSessionManagement adminAddSession = new AdminSessionManagement();
            adminAddSession.ShowDialog();
            this.Hide();
        }

        //
        //Passer l'objet session selectionné dans la dgvSessions en parametre
        //
        private void btnEditSession_Click(object sender, EventArgs e)
        {
            Session session = (Session)dgvSessions.CurrentRow.DataBoundItem;

            AdminSessionManagement adminEditSession = new AdminSessionManagement(session);
            adminEditSession.ShowDialog();
            this.Hide();
        }

        private void btnAdminView_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView();
            adminView.ShowDialog();
        }

        private void AdminCalendarManagement_Load(object sender, EventArgs e)
        {
            //Data binding with List<Formation>
            cbTraining.DataSource = db.GetFormations();
            cbTraining.DisplayMember = "name";
            cbTraining.ValueMember = "id";

            //DataGrid binding from Session of Formation selected
            Formation formationObject = (Formation)cbTraining.SelectedItem;
            dgvSessions.DataSource = db.GetSessions(formationObject.Id.ToString());
        }

        private void cbTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataGrid binding from Session of Formation selected
            Formation formationObject = (Formation)cbTraining.SelectedItem;
            dgvSessions.DataSource = db.GetSessions(formationObject.Id.ToString());
        }
    }
}
