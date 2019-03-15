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
        User contextUser = new User();
        private DbGestionFormation db = new DbGestionFormation();

        public Connection_form()
        {
            InitializeComponent();
            db.InitDb(); //Init connection to database
        }

        private void btn_co_validate_Click(object sender, EventArgs e)
        {
            String login = tb_co_login.Text;
            String pass = tb_co_pass.Text;
            
            if (db.Connection(login, pass).Count() == 1) //PB avec la requête. Login et MDP en dur dans le requete pour pouvoir ^poursuivre le dev de l'appli
            {
                List<User> accounts = db.Connection(login, pass);
                foreach (User userAccount in accounts)
                {
                    contextUser = userAccount;
                }
                if (contextUser.TentativeCo >= 6)
                {
                    MessageBox.Show("Votre compte est gelé. Veuillez contacter et attendre l'action de l'administrateur.");
                }
                else if (contextUser.DemandeChangePass)
                {
                    ChangePass changePass = new ChangePass();
                    changePass.ShowDialog();
                }
                else //Redirection vers la bonne vue selon le role
                {
                    String role = contextUser.Role;
                    switch (role)
                    {
                        case "administrateur":
                            AdminView adminView = new AdminView();
                            adminView.ShowDialog();
                            break;
                        case "gestionnaire":
                            ManagerView managerView = new ManagerView();
                            managerView.ShowDialog();
                            break;
                        default:
                            GuestView guestView = new GuestView();
                            guestView.ShowDialog();
                            break;
                    }
                }
                //Appeler une fonction pour determiner si c'est la premiere connexion en 24.
                //Si le resultat = null : on initialise USer.heurePremiereCo = DateTime.Now (voir constructeur)
                //Si le resultat >= 24h mais tentativeCo < 6 : le nb de mdp faux n'est pas atteint, alors on initialise User.heurePremiereCo = DateTime.Now
                //Si le resultat >= 24h et tentativeCo > 6 : le nb de tentative de co par jour est dépassé, alors on freeze le compte

            }
            else if (db.Connection(login, pass).Count() > 1)
            {
                MessageBox.Show("Erreur: plusieurs utilisateurs ont le même couple login/mdp que vous. Veuillez contacter l'administrateur de l'application");
            }
            else
            {
                //Requete qui va incrémenter tentativeCo de l'utilisateur dont soit le login correspond, soit le mdp.
                MessageBox.Show("Mauvais login ou mot de passe");
            }
                
        }

        private void btn_co_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
