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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            AdminUserManagement adminUserManagement = new AdminUserManagement();
            adminUserManagement.ShowDialog();
            this.Hide();
        }

        private void btnCalendarManagement_Click(object sender, EventArgs e)
        {
            AdminCalendarManagement adminCalendarManagement = new AdminCalendarManagement();
            adminCalendarManagement.ShowDialog();
            this.Hide();
        }

        private void btnTicketsView_Click(object sender, EventArgs e)
        {
            AdminTicketsView adminTicketsView = new AdminTicketsView();
            adminTicketsView.ShowDialog();
        }
    }
}
