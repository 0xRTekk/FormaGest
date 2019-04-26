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
    public partial class AdminUserManagement : Form
    {
        private DbGestionFormation db = new DbGestionFormation();
        private User contextUser = new User();

        public AdminUserManagement()
        {
            InitializeComponent();
            db.InitDb();
        }

        private void btnAdminView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminUserManagement_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = db.GetUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            contextUser = (User)dgvUsers.CurrentRow.DataBoundItem;
            int idUser = contextUser.Id;

            db.DeleteUser(idUser);

            MessageBox.Show("utilisateur supprimé");
            //Refresh the DataGridView
            refreshDgv();
            /*dgvUsers.DataSource = null;
            dgvUsers.DataSource = db.GetUsers();*/
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AdminAddUser adminAddUser = new AdminAddUser();
            adminAddUser.ShowDialog();
            if (adminAddUser.DialogResult == DialogResult.OK)
                refreshDgv();
            else
                adminAddUser.Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            contextUser = (User)dgvUsers.CurrentRow.DataBoundItem;

            AdminEditUser adminEditUser = new AdminEditUser(contextUser);
            adminEditUser.ShowDialog();
            if (adminEditUser.DialogResult == DialogResult.OK)
                refreshDgv();
            else
                adminEditUser.Close();
        }



        //
        //Public functions
        //
        public void refreshDgv()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = db.GetUsers();
        }
    }
}
