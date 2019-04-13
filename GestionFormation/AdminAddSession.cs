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
    public partial class AdminAddSession : Form
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
        public AdminAddSession(Formation TheFormation)
        {
            InitializeComponent();
            this.contextFormation = TheFormation;

            tbTraining.Text = contextFormation.Name;
        }

        //
        //Get/Set
        //
        public Formation TheFormation { get; set; }


        //
        //Functions
        //
        private void AdminAddSession_Load(object sender, EventArgs e)
        {
            db.InitDb();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            contextSession.Date = dateTimePicker.Value;
            contextSession.HourBegin = (int)hourBegin.Value;
            contextSession.HourEnd = (int)hourEnd.Value;
            contextSession.Place = tbPlace.Text;
            contextSession.LaFormation = contextFormation;

            db.AddSession(contextSession.Date, contextSession.HourBegin, contextSession.HourEnd, contextSession.Place, contextSession.LaFormation.Id.ToString());
        }

    }
}
