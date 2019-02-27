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
    public partial class Connection_form : Form
    {
        private DbGestionFormation db = new DbGestionFormation();
        public Connection_form()
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database
        }

        private void btn_co_validate_Click(object sender, EventArgs e)
        {
            String login = tb_co_login.ToString();
            String pass = tb_co_pass.ToString();
            if (db.Authentification(login, pass))
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
                
        }
    }
}
