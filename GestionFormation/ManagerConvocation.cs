using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GestionFormation
{
    public partial class ManagerConvocation : Form
    {
        public ManagerConvocation()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(rtbConvocation.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtbConvocation.Clear();
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
            rtbConvocation.Text = convocation;
        }
    }
}
