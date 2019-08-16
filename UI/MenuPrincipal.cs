using Avance_3.Facturas;
using Avance_3.Inventario;
using Avance_3.Pedidos;
using Avance_3.Reportes;
using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iText.IO.Image;

namespace Avance_3.UI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            lbl_user.Text = UserDisplayName.displayName;
            btn_Pedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn_Ajustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn_Facturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn_inventarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn_Prendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btn_Reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }

        private void Btn_Pedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PedidoForm().ShowDialog();
        }

        private void Btn_Facturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FacturaForm().ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btn_inventarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InventarioForm().ShowDialog();
        }

        private void Btn_Reportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportesForm().ShowDialog();
        }

        private void Btn_Prendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InventarioForm().ShowDialog();
        }
    }
}

/*
 * 
 * PdfWriter.GetInstance(doc, new FileStream(, FileMode.Create));

            doc.Open();

            Paragraph p1 = new Paragraph("Probando creación de pdf!");
            doc.Add(p1);
            doc.Close();
            MessageBox.Show("PDF creado yes pez");
 * 
 * 
 * */
