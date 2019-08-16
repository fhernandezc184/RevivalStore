using Avance_3.DbConnector;
using Avance_3.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Avance_3.Pedidos
{
    public partial class PedidoForm : Form
    {
        private SQLDbConnect conn = new SQLDbConnect();
        private DataTable dtbl = new DataTable();

        public PedidoForm()
        {
            InitializeComponent();
            cmb_Status.Items.Add("Completo");
            cmb_Status.Items.Add("Incompleto");
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().ShowDialog();
        }

        private void PedidoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (conn.conexion = new SqlConnection(conn.conexion.ConnectionString))
            {
                conn.EstablecerConexion();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT idPedido" +
                    ",Nombre_Cliente" +
                    ",Vivienda" +
                    ",Cedula" +
                    ",No_Pedido" +
                    ",CASE WHEN [Status] = 1 THEN 'Completo'" +
                    "WHEN [status]=0 THEN 'Incompleto'" +
                    "END AS [Status]" +
                    "FROM Pedidos ORDER BY Status DESC;", conn.conexion);

                sda.Fill(dtbl);
                dgv_Pedidos.DataSource = dtbl;
            }
        }

        private void Dgv_Pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Pedidos.Rows[index];
            txt_ID.Text = selectedRow.Cells[0].Value.ToString();
            txt_Nombre.Text = selectedRow.Cells[1].Value.ToString();
            txt_Vivienda.Text = selectedRow.Cells[2].Value.ToString();
            txt_Cedula.Text = selectedRow.Cells[3].Value.ToString();
            txt_Pedido.Text = selectedRow.Cells[4].Value.ToString();
            cmb_Status.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void GetSelectedToTextBox()
        {
            //int index = e.RowIndex;
            //DataGridViewRow selectedRow = dgv_Pedidos.Rows[index];
            //txt_ID.Text = selectedRow.Cells[0].Value.ToString();
            //txt_Nombre.Text = selectedRow.Cells[1].Value.ToString();
            //txt_Vivienda.Text = selectedRow.Cells[2].Value.ToString();
            //txt_Cedula.Text = selectedRow.Cells[3].Value.ToString();
            //txt_Pedido.Text = selectedRow.Cells[4].Value.ToString();

            // txt_Precio.Text = selectedRow.Cells[5].Value.ToString();
        }
    }
}
