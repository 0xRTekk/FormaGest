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
    public partial class Form2 : Form
    {
        DbGestionFormation db = new DbGestionFormation();
        List<Participant> ContextParticipants = new List<Participant>();
        List<Participant> ContextInscrits = new List<Participant>();

        //
        //Properties
        //
        private Formation formation;
        private Session session;


        //
        //Getters & Setters
        //
        public Formation Formation { get; set; }
        public Session Session { get; set; }


        //
        //Builder
        //
        public Form2(Formation passedFormation, Session passedSession)
        {
            InitializeComponent();
            db.InitDb();
            formation = passedFormation;
            session = passedSession;
        }



        //
        //Methods & Functions
        //
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxFormation.Text = formation.Name;
            textBoxDateBegin.Text = session.HourBegin.ToString();
            textBoxDateEnd.Text = session.HourEnd.ToString();


            //Fill dataGridViewParticipants with all participants
            ContextParticipants = db.GetParticipants();
            dataGridViewParticipants.DataSource = ContextParticipants;


            //Fill dataGridViewInscrits with all inscrits
            ContextInscrits = db.GetInscrits(session.Id.ToString());
            dataGridViewInscrits.DataSource = ContextInscrits;
        }

        private void buttonArrowLeft_Click(object sender, EventArgs e)
        {
            //Update the dataGridViewInscrits display
            foreach (DataGridViewRow row in dataGridViewParticipants.SelectedRows)
            {
                var objectParticipant = (Participant)dataGridViewParticipants.CurrentRow.DataBoundItem;
                Participant unInscrit = row.DataBoundItem as Participant;
                
                ContextInscrits.Add(unInscrit);
                dataGridViewInscrits.DataSource = null;
                dataGridViewInscrits.DataSource = ContextInscrits;
            }
        }

        private void buttonArrowRight_Click(object sender, EventArgs e)
        {
            //Update the dataGridViewParticipant display
            foreach (DataGridViewRow row in dataGridViewInscrits.SelectedRows)
            {
                var objectInscrit = (Participant)dataGridViewInscrits.CurrentRow.DataBoundItem;
                Participant unInscrit = row.DataBoundItem as Participant;

                int posInscritInSource = -1;
                posInscritInSource = ContextInscrits.IndexOf(objectInscrit);
                ContextInscrits.RemoveAt(posInscritInSource);
                dataGridViewInscrits.DataSource = null;
                dataGridViewInscrits.DataSource = ContextInscrits;
            }
        }
    }
}
