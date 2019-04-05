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
    public partial class AdminTicketsView : Form
    {
        DbGestionFormation db = new DbGestionFormation();
        public AdminTicketsView()
        {
            InitializeComponent();
            db.InitDb();

            dgvListTickets.DataSource = db.GetTickets();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
