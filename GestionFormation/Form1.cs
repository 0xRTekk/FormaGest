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
            contextFormations = db.GetFormations();

            //Using ComboValue to fill the ComboBox
            var comboListeFormations = new List<ComboValue>();
            foreach (Formation uneFormation in contextFormations)
                comboListeFormations.Add(new ComboValue() { Name = uneFormation.Name, Value = uneFormation.Id.ToString() });
            comboBoxFormations.DataSource = comboListeFormations;
            comboBoxFormations.DisplayMember = "Name";
            comboBoxFormations.ValueMember = "Value";
            
            //Extract the Id's Formation selected
            var objectFormation = (ComboValue)comboBoxFormations.SelectedItem;
            String indexFormation;
            indexFormation = objectFormation.Value;
            
            dataGridViewSessions.DataSource = db.GetSessions(indexFormation);
        }

        private void comboBoxFormations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var formationObject = (ComboValue)comboBoxFormations.SelectedItem;
            String indexFormation;
            indexFormation = formationObject.Value;

            contextSessions = db.GetSessions(indexFormation);
            dataGridViewSessions.DataSource = contextSessions;
        }

        private void dataGridViewSessions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var objectFormation = (ComboValue)comboBoxFormations.SelectedItem;
            var objectSession = (Session)dataGridViewSessions.CurrentRow.DataBoundItem;

            Form2 form2 = new Form2(objectFormation, objectSession);
            form2.ShowDialog();
        }
    }
}
