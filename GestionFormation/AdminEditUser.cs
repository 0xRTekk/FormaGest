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
    public partial class AdminEditUser : Form
    {
        //
        //Props
        //
        private DbGestionFormation db = new DbGestionFormation();
        private User user;

        //
        //Builder
        //
        public AdminEditUser(User myUser)
        {
            InitializeComponent();
            db.InitDb();
            this.user = myUser;
        }

        //
        //Get/Set
        //
        public User myUser { get; set; }


        private void AdminEditUser_Load(object sender, EventArgs e)
        {
            string[] role = new string[3];
            role[0] = "administrateur";
            role[1] = "gestionnaire";
            role[2] = "utilisateur";

            cbRole.DataSource = role;

            tbLogin.Text = user.Login;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            db.ResetPass(user.Id);
            MessageBox.Show("Mot de passe remit à zéro");
            this.Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            db.UpdateUser(user.Id, tbLogin.Text, cbRole.SelectedValue.ToString());
            MessageBox.Show("Modifications validés");
            this.Close();
        }
    }
}
