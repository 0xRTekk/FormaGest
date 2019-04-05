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
    public partial class ManagerApplicationManagement : Form
    {
        public ManagerApplicationManagement()
        {
            InitializeComponent();
        }

        private void btnAdminView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
