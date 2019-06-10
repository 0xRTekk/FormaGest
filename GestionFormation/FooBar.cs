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
    public partial class FooBar : Form
    {
        DbGestionFormation db = new DbGestionFormation();
        Foo contextFoo = new Foo();
        Bar contextBar = new Bar();
        List<Foo> contextListFoo = new List<Foo>();
        List<Bar> contextListBar = new List<Bar>();

        public FooBar()
        {
            InitializeComponent();
            db.InitDb();
            contextListBar = db.GetBars();
            contextListFoo = db.GetFoos();
        }

        private void FooBar_Load(object sender, EventArgs e)
        {
            dgvFoo.DataSource = contextListFoo;
            cbFoo.DataSource = contextListFoo;
            cbFoo.DisplayMember = "f2";
            cbFoo.ValueMember = "id";
            
            dgvBar.DataSource = contextListBar;
            cbBar.DataSource = contextListBar;
            cbBar.DisplayMember = "f2";
            cbBar.ValueMember = "id";
        }

        private void Validate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
