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
    public partial class Form1 : Form
    {
        private DbGestionFormation db = new DbGestionFormation();
        List<Formation> contextFormations = new List<Formation>();
        List<Session> contextSessions = new List<Session>();

        public Form1()
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data binding with List<Formation> contextFormations
            comboBoxFormations.DataSource = db.GetFormations(); 
            comboBoxFormations.DisplayMember = "Name";

            //Extract the Id's Formation selected
            Formation formationObject = (Formation)comboBoxFormations.SelectedItem;
            String indexFormation;
            indexFormation = formationObject.Id.ToString();

            dataGridViewSessions.DataSource = db.GetSessions(indexFormation);
        }

        private void comboBoxFormations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Formation formationObject = (Formation)comboBoxFormations.SelectedItem;
            String indexFormation;
            indexFormation = formationObject.Id.ToString();

            contextSessions = db.GetSessions(indexFormation);
            dataGridViewSessions.DataSource = contextSessions;
        }

        private void dataGridViewSessions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Formation objectFormation = (Formation)comboBoxFormations.SelectedItem;
            var objectSession = (Session)dataGridViewSessions.CurrentRow.DataBoundItem;

            Form2 form2 = new Form2(objectFormation, objectSession);
            form2.ShowDialog();
        }
    }
}
