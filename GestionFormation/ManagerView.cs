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
    public partial class ManagerView : Form
    {
        private DbGestionFormation db = new DbGestionFormation();

        public ManagerView()
        {
            InitializeComponent();
            db.InitDb();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            //Data binding with List<Formation> contextFormations
            cbTraining.DataSource = db.GetFormations();
            cbTraining.DisplayMember = "name";
            cbTraining.ValueMember = "id";

            //DataGrid binding from Session of Formation selected
            Formation formationObject = (Formation)cbTraining.SelectedItem;
            dgvSession.DataSource = db.GetSessions(formationObject.Id.ToString());
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            ManagerAddApplication managerAddApplication = new ManagerAddApplication();
            managerAddApplication.ShowDialog();
            this.Hide();
        }

        private void cbTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formation formationObject = (Formation)cbTraining.SelectedItem;
            dgvSession.DataSource = db.GetSessions(formationObject.Id.ToString());
        }
    }
}
