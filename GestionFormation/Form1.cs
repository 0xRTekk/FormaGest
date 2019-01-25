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
        List<Formation> contextFormation = new List<Formation>();

        public Form1()
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contextFormation = db.GetFormations();

            //Using ComboValue to fill the ComboBox
            var comboListeFormations = new List<ComboValue>();
            foreach (Formation uneFormation in contextFormation)
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

            dataGridViewSessions.DataSource = db.GetSessions(indexFormation);
        }

        private void dataGridViewSessions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Extract the Name's Formation selected
            var objectFormation = (ComboValue)comboBoxFormations.SelectedItem;
            String nameFormation;
            nameFormation = objectFormation.Name;

            //Extract 
            var objectSession = (Session)dataGridViewSessions.CurrentRow.DataBoundItem;
            string idSession = objectSession.Id.ToString();

            Form2 form2 = new Form2(nameFormation, idSession);
            form2.ShowDialog();
        }
    }
}
