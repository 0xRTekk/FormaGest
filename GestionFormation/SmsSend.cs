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
    }
}
