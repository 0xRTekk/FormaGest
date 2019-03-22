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
    public partial class ChangePass : Form
    {
        User contextUser = new User();
        private DbGestionFormation db = new DbGestionFormation();
        
        public ChangePass(User contextUserPassed)
        {
            InitializeComponent();
            db.InitDb();
            contextUser = contextUserPassed;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            String newPass = tbNewPass.Text;
            String confirmNewPass = tbNewPassConfirm.Text;

            if (newPass == confirmNewPass)
            {
                db.UpdatePass(contextUser.Id, newPass);
                MessageBox.Show("Mot de passe changé");
            }
            else
            {
                MessageBox.Show("Les mots de passes entrés ne sont pas identiques !");
            }
        }
    }
}
