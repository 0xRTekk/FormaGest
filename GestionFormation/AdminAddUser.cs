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
    public partial class AdminAddUser : Form
    {
        DbGestionFormation db = new DbGestionFormation();
        public AdminAddUser()
        {
            InitializeComponent();
            db.InitDb();
        }

        private void AdminAddUser_Load(object sender, EventArgs e)
        {
            string[] role = new string[3];
            role[0] = "administrateur";
            role[1] = "gestionnaire";
            role[2] = "utilisateur";

            cbRole.DataSource = role;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            String login = tbLogin.Text;
            String pass = "12345";
            String role = cbRole.SelectedValue.ToString();
            int tentativeCo = 0;
            int demandeChangePass = 1;

            db.AddUser(login, pass, role, tentativeCo, demandeChangePass);

            this.Close();
        }
    }
}
