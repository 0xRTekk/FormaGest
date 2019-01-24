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
        public Form1()
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFormations.DataSource = db.GetFormations();
            comboBoxFormations.DisplayMember = "Name";
            comboBoxFormations.ValueMember = "Value";
            
            var formationObject = (ComboValue)comboBoxFormations.SelectedItem;
            String indexFormation;
            indexFormation = formationObject.Value;
            
            dataGridViewSessions.DataSource = db.GetSessions(indexFormation);
        }

        private void comboBoxFormations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var formationObject = (ComboValue)comboBoxFormations.SelectedItem;
            String indexFormation;
            indexFormation = formationObject.Value;

            dataGridViewSessions.DataSource = db.GetSessions(indexFormation);
        }
    }
}
