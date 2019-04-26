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
    public partial class AdminEditSession : Form
    {
        //
        //Props
        //
        private Session contextSession = new Session();
        private Formation contextFormation = new Formation();
        private DbGestionFormation db = new DbGestionFormation();

        //
        //Builder
        //
        public AdminEditSession(Session TheSession, Formation TheFormation)
        {
            InitializeComponent();

            this.contextFormation = TheFormation;
            this.contextSession = TheSession;
        }
        
        //
        //Get/Set
        //
        public Formation TheFormation { get; set; }
        public Session TheSession { get; set; }


        //
        //Functions
        //
        private void AdminEditSession_Load(object sender, EventArgs e)
        {
            db.InitDb();

            tbTraining.Text = contextFormation.Name;
            dateTimePicker.Value = contextSession.Date;
            hourBegin.Text = contextSession.Hour_begin;
            hourEnd.Text = contextSession.Hour_end;
            tbPlace.Text = contextSession.Place;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            contextSession.Date = dateTimePicker.Value;
            contextSession.Hour_begin = hourBegin.Text;
            contextSession.Hour_end = hourEnd.Text;
            contextSession.Place = tbPlace.Text;

            db.UpdateSession(contextSession.Id.ToString(), contextSession.Date, contextSession.Hour_begin, contextSession.Hour_end, contextSession.Place);

            MessageBox.Show("Session modifiée");
            this.Close()
;        }

    }
}
