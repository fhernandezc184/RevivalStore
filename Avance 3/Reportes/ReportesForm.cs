using Avance_3.UI;
using System;
using System.Data;
using System.Windows.Forms;
using Avance_3.DbConnector;
using System.Data.SqlClient;
using Microsoft.Office;

namespace Avance_3.Reportes
{
    public partial class ReportesForm : Form
    {
        static SQLDbConnect nuevaconnexion = new SQLDbConnect();
        DataTable dtbl = new DataTable();
        private SqlDataAdapter sda;
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            new MenuPrincipal().ShowDialog();

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoadInventario()
        {
            DateTime FechaDesde = DeFecha.Value;
            Console.WriteLine(FechaDesde.ToString());
            DateTime fechadesdeformato = FechaDesde.Date;
            DateTime FechaHasta = hastafecha.Value;
            Console.WriteLine(FechaHasta.ToString());
            DateTime fechahastaformato = FechaHasta.Date;

            using (nuevaconnexion.conexion = new SqlConnection(nuevaconnexion.conexion.ConnectionString))
            {
                dtbl.Clear();
                nuevaconnexion.EstablecerConexion();
                sda = new SqlDataAdapter(@"SELECT NumeroFactura, NombreCliente, CONVERT(varchar, Fecha, 23) as 'Fecha', Empleado, Descuento, TotalDescuento, TotalPagar 
                                            FROM Factura WHERE Fecha  >= '" + fechadesdeformato.ToString("yyyy-MM-dd") + "' " +
                                            "AND  Fecha <= '" + fechahastaformato.ToString("yyyy-MM-dd") + "' ORDER BY Fecha;", nuevaconnexion.conexion);
                sda.Fill(dtbl);
                Compras.DataSource = dtbl;
            }
        }


        private void ExportarDataGridAExcel()
        {
            // Crea la applicaion de excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // Hace un nuevo libro de trabajo en excel 
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // Crea una nueva hoja de trabajo en excel
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // Se ve el excel detras del programa
            app.Visible = true;
            // Se crea la referencia a la hoja 1 de excel  
            // se almacena la referecia en la hoja de excel
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // se modifica el nombre de la hoja de excel 
            worksheet.Name = "Exported from gridview";
            // se guarda el nombre de las columnas en el excel
            for (int i = 1; i < Compras.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Compras.Columns[i - 1].HeaderText;
            }
            // se guardon los valores en las casillas de excel
            for (int i = 0; i < Compras.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Compras.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Compras.Rows[i].Cells[j].Value.ToString();
                }
            }
            // se guarda el archivo  
            workbook.SaveAs(@"C:\Users\faher\Desktop\excel.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // se cierra la applicacion 
            app.Quit();
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            LoadInventario();
            ExportarDataGridAExcel();
        }

        private void Compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
