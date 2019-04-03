using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFormation
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Connection_form connection_Form = new Connection_form();

            //Permet de fermer la fenetre de connection une fois que l'utilisateur est connecte
            connection_Form.ShowDialog();
            if (connection_Form.DialogResult == DialogResult.OK)
            {
                User contextUser = connection_Form.contextUser;
                String role = contextUser.Role;

                connection_Form.Close();
                
                switch (role) //Redirection vers la bonne vue selon le role
                {
                    case "administrateur":
                        AdminView adminView = new AdminView();
                        adminView.ShowDialog();
                        break;
                    case "gestionnaire":
                        ManagerView managerView = new ManagerView();
                        managerView.ShowDialog();
                        break;
                    case "utilisateur":
                        GuestView guestView = new GuestView(contextUser);
                        guestView.ShowDialog();
                        break;
                    default:
                        connection_Form.ShowDialog();
                        break;
                }
            }
            else
                connection_Form.Close();
        }
    }
}
