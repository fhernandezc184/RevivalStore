using Avance_3.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iText.IO.Image;
using Avance_3.DbConnector;

namespace Avance_3.Facturas
{
    public partial class FacturaForm : Form
    {
        private SQLDbConnect conn = new SQLDbConnect();
        public FacturaForm()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btn_SavePDF_Click(object sender, EventArgs e)
        {
            string Par1 = txt_name.Text;
            string Par2 = txt_ced.Text;
            string Par3 = txt_monto.Text;

            string Date = dtm_Fecha.Value.ToString();

            Paragraph p1 = new Paragraph("Nombre: " + Par1);

            Paragraph p2 = new Paragraph("Cédula: " + Par2);

            Paragraph p3 = new Paragraph("Monto total: " + Par3);

            Paragraph p4 = new Paragraph("Fecha de emisión: " + Date);


            string imagePath = "C:\\Users\\emb10\\Documents\\Visual Studio 2017\\Projects\\Avance 3\\images\\revival_logoPDF.png";
            ImageData data = ImageDataFactory.Create(imagePath);

            Image img = Image.GetInstance(imagePath);

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());

                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(img);
                        doc.Add(p1);
                        doc.Add(p2);
                        doc.Add(p3);
                        doc.Add(p4);
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
    }
}
