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
        DateTime dateCourante = DateTime.Now;
        public User contextUser = new User();
        private DbGestionFormation db = new DbGestionFormation();

        public User ContextUser { get; set; }


        public Connection_form()
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database
        }

        private void btn_co_validate_Click(object sender, EventArgs e)
        {
            String login = tb_co_login.Text;
            String pass = tb_co_pass.Text;
            pass = SHA.GenerateSHA256String(pass);
            
            if (db.Connection(login, pass).Count() == 1)
            {
                this.DialogResult = DialogResult.OK;

                List<User> accounts = db.Connection(login, pass);
                foreach (User userAccount in accounts)
                {
                    contextUser = userAccount;
                }

                var hours = (dateCourante - contextUser.HeurePremiereCo).TotalHours; // Difference d'heure entre la dernière co et l'heure courante
                if (contextUser.HeurePremiereCo == null)// Initialisation de l'heure de première co
                {
                    contextUser.HeurePremiereCo = dateCourante;
                }
                else if (hours >= 24)// Si 24h se sont écoulés depuis la dernière co, remet le compteur à la date courante
                {
                    contextUser.HeurePremiereCo = dateCourante;
                }
                if (contextUser.TentativeCo >= 6 && hours <= 24) //6 mauvais logs en moins de 24h
                {
                    MessageBox.Show("Votre compte est gelé. Veuillez contacter et attendre l'action de l'administrateur.");
                }
                else if (contextUser.DemandeChangePass)
                {
                    // Fermet la fenetre lors du clic sur les boutons Valider et Annuler
                    ChangePass changePass = new ChangePass(contextUser);
                    changePass.ShowDialog();
                    if (changePass.DialogResult == DialogResult.OK)
                        changePass.Close();
                    else
                        changePass.Close();
                }
            }
            else if (db.Connection(login, pass).Count() > 1)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Erreur: plusieurs utilisateurs ont le même couple login/mdp que vous. Veuillez contacter l'administrateur de l'application");
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                //Requete qui va incrémenter tentativeCo de l'utilisateur dont soit le login correspond, soit le mdp.

                MessageBox.Show("Mauvais login ou mot de passe");
            }
                
        }

        private void btn_co_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
