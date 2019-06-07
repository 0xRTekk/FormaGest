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
    public partial class AdminCancelApplication : Form
    {
        private DbGestionFormation db = new DbGestionFormation();
        private Session contextSession = new Session();
        private Participant contextParticipant = new Participant();

        public AdminCancelApplication(Session session, Participant participant)
        {
            db.InitDb();
            InitializeComponent();
            contextSession = session;
            contextParticipant = participant;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            String refus = rtbRefus.Text;
            String accepter = "0";
            db.updateCandidater(contextSession.Id.ToString(), contextParticipant.Id.ToString(), accepter, refus);
            this.DialogResult = DialogResult.OK;
        }
    }
}
