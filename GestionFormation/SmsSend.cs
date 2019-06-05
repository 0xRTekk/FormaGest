using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace GestionFormation
{
    public partial class SmsSend : Form
    {
        public SmsSend()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String msg = rtbMsg.Text;
            Sms.Send(msg);
            MessageBox.Show("Sms envoyé");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            String convocation = "Paris, le [Date] .\n" +
                "Objet: Rendez-vous pour votre formation de [Formation]\n" +
                "Cher adhérent(e), merci pour l'interêt que vous portez à notre programme de formations\n" +
                "Suite à votre demande, nous avons le plaisir de vous annoncez que vous êtes inscrits pour un cours de [Formation] qui se déroulera " +
                "le [Date] à [Heure_début] jusqu'à [Heure_fin] et aure lieu au [Lieu]\n\n" +
                "A bientôt !\n" +
                "L'équipe de Belle Table";

            rtbMsg.Text = convocation;
        }

        private void rtbMsg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
