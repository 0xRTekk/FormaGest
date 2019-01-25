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

        //
        //Properties
        //
        private string nameFormation;
        private string idSession;


        //
        //Builder
        //
        public Form2(string NameFormation, string IdSession)
        {
            InitializeComponent();
            db.InitDb();
            nameFormation = NameFormation;
            idSession = IdSession;
        }



        //
        //Methods & Functions
        //
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxFormation.Text = nameFormation;
        }
    }
}
