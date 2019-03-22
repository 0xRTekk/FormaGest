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
        public AdminCalendarManagement()
        {
            InitializeComponent();
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
    }
}
