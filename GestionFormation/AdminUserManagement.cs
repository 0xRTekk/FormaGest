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
        public AdminUserManagement()
        {
            InitializeComponent();
        }

        private void btnAdminView_Click(object sender, EventArgs e)
        {
            AdminView adminView = new AdminView();
            adminView.ShowDialog();
        }
    }
}
