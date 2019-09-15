using Avance_3.UI;
using System;
using System.Windows.Forms;
using Avance_3.DbConnector;
using System.Data.SqlClient;
using System.Data;

namespace Avance_3.Facturas
{
    public partial class FacturaForm : Form
    {
        SQLDbConnect nuevaconnexion = new SQLDbConnect();
        SqlCommand sqlcommand = new SqlCommand();
        static SqlDataReader dr;
        DataTable dtbl = new DataTable();
        int something = 0;

        public FacturaForm()
        {
            InitializeComponent();
            cargarDataEnDataGrid();
            lblEmpleado.Text = UserDisplayName.displayName;
            txtNumeroFactura.Text = ObtenerNumeroFactura().ToString();
            cmbdescuento.DataSource = Enum.GetValues(typeof(DescuentosEnums));
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

        private void Btncrearfactura_Click(object sender, EventArgs e)
        {
            txtMontoAPagar.Text = pagarcompra().ToString();
            txtDescuentoAplicado.Text = obtenerDescuentoAplicado(cmbdescuento.SelectedValue.ToString()).ToString();
            txtMontoAPagar.Text = (Int32.Parse(txtMontoAPagar.Text.ToString()) - obtenerDescuentoAplicado(cmbdescuento.SelectedValue.ToString())).ToString();
            InsertarFactura();
            InsertarDetalleFactura();
            RestarInventario();
            txtNumeroFactura.Text = ObtenerNumeroFactura().ToString();
            cargarDataEnDataGrid();
            dgv_prendas_comprar.Rows.Clear();



        }

        private void Btn_agregar_compras_Click(object sender, EventArgs e)
        {
            dgv_prendas_comprar.Rows.Clear();
            foreach (DataGridViewRow item in dgv_inventario.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dgv_prendas_comprar.Rows.Add();
                    //new gridview                             old gridview
                    dgv_prendas_comprar.Rows[n].Cells[0].Value = false;
                    dgv_prendas_comprar.Rows[n].Cells[1].Value = item.Cells[1].Value.ToString();
                    dgv_prendas_comprar.Rows[n].Cells[2].Value = item.Cells[2].Value.ToString();
                    dgv_prendas_comprar.Rows[n].Cells[3].Value = item.Cells[3].Value.ToString();
                    dgv_prendas_comprar.Rows[n].Cells[4].Value = item.Cells[4].Value.ToString();
                    dgv_prendas_comprar.Rows[n].Cells[5].Value = item.Cells[5].Value.ToString();
                    
                }
            }
        }

        private void cargarDataEnDataGrid()
        {
            using (nuevaconnexion.conexion = new SqlConnection(nuevaconnexion.conexion.ConnectionString))
            {
                nuevaconnexion.EstablecerConexion();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Inventario", nuevaconnexion.conexion);

                sda.Fill(dtbl);
                dgv_inventario.Rows.Clear();

                foreach (DataRow item in dtbl.Rows)
                {
                    int n = dgv_inventario.Rows.Add();
                    dgv_inventario.Rows[n].Cells[0].Value = false;
                    dgv_inventario.Rows[n].Cells[1].Value = item["idPrenda"].ToString();
                    dgv_inventario.Rows[n].Cells[2].Value = item["Tipo_Prenda"].ToString();
                    dgv_inventario.Rows[n].Cells[3].Value = item["Precio"].ToString();
                    dgv_inventario.Rows[n].Cells[4].Value = item["Marca_Prenda"].ToString();
                    dgv_inventario.Rows[n].Cells[5].Value = item["Talla_Prenda"].ToString();
                    dgv_inventario.Rows[n].Cells[6].Value = item["Cant_Prenda"].ToString();
                }

            }
            txtMontoAPagar.Text = "0";
        }

        private void InsertarFactura()
        {
            string query = "INSERT INTO Factura ( NumeroFactura, NombreCliente, Fecha, Empleado, Descuento, TotalDescuento, TotalPagar ) " +
                "VALUES('" + ObtenerNumeroFactura() + "','" + txtNombre.Text.ToString() + "'," + "GETDATE()" + ",'" + lblEmpleado.Text.ToString() + "','" + something + "','" + Int32.Parse(txtDescuentoAplicado.Text.ToString()) + "','" + Int32.Parse(txtMontoAPagar.Text.ToString()) + "');";
            nuevaconnexion.SqlQuery(query);
            nuevaconnexion.Execute();
            nuevaconnexion.CloseConnection();
            MessageBox.Show("Datos ingresados correctamente!");
            LimpiarCajasTexto();
        }

        private void InsertarDetalleFactura()
        {
            string detallePrenda;
            int detallePrecio;
            string detalleMarca;
            string detalleTalla;

            for (int i = 0; i < dgv_prendas_comprar.Rows.Count; i++)
            {
                //new gridview                             old gridview
                detallePrenda = dgv_prendas_comprar.Rows[i].Cells[2].Value.ToString();
                detallePrecio = Int32.Parse(dgv_prendas_comprar.Rows[i].Cells[3].Value.ToString());
                detalleMarca = dgv_prendas_comprar.Rows[i].Cells[4].Value.ToString();
                detalleTalla = dgv_prendas_comprar.Rows[i].Cells[5].Value.ToString();

                string query = "INSERT INTO DetalleFactura ( NumeroFactura, TipoPrenda, PrecioPrenda, MarcaPrenda,PrendaTalla, Empleado) " +
            "VALUES('" + ObtenerNumeroFactura() + "','" + detallePrenda + "'," + detallePrecio + ",'" + detalleMarca + "','" + detalleTalla + "','" + lblEmpleado.Text.ToString() + "');";
                nuevaconnexion.SqlQuery(query);
                nuevaconnexion.Execute();
                nuevaconnexion.CloseConnection();
            }
        }

        private void RestarInventario()
        {
            int prendaid;

            for (int i = 0; i < dgv_prendas_comprar.Rows.Count; i++)
            {
                //new gridview                             old gridview
               
                prendaid = Int32.Parse(dgv_prendas_comprar.Rows[i].Cells[1].Value.ToString());


                string query = "UPDATE Inventario SET Cant_Prenda = Cant_Prenda - 1 WHERE idPrenda = " + prendaid + ";";
                nuevaconnexion.SqlQuery(query);
                nuevaconnexion.Execute();
                nuevaconnexion.CloseConnection();
            }
        }

        private int ObtenerNumeroFactura()
        {
            int NumeroFactura;

            nuevaconnexion.EstablecerConexion();
            sqlcommand.Connection = nuevaconnexion.conexion;
            sqlcommand.CommandText = "SELECT NumeroFactura FROM Factura WHERE idFactura  = (SELECT COUNT(*) FROM Factura)+20;";

            dr = sqlcommand.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();// Get first record.
                NumeroFactura = dr.GetInt32(0) + 1;// Get value of first column as string.
            }
            else
            {
                NumeroFactura = 0;
            }
            dr.Close();// Close reader.
            nuevaconnexion.CloseConnection();
            return NumeroFactura;


        }
        private float obtenerDescuentoAplicado(string valorenum)
        {
            valorenum = cmbdescuento.SelectedItem.ToString();

            float conversionsomething = 0.0f;
            float descuento = 0;

            switch (valorenum)
            {
                case "Cinco":
                    something = (int)DescuentosEnums.Cinco;
                    break;
                case "Diez":
                    something = (int)DescuentosEnums.Diez;
                    break;
                case "Quince":
                    something = (int)DescuentosEnums.Quince;
                    break;
                case "Veinte":
                    something = (int)DescuentosEnums.Veinte;
                    break;
                case "VeintiCinco":
                    something = (int)DescuentosEnums.VeintiCinco;
                    break;
                case "Treinta":
                    something = (int)DescuentosEnums.Treinta;
                    break;
                default:
                    something = 0;
                    break;
            }
            conversionsomething = (float)something / 100f;
            descuento = float.Parse(txtMontoAPagar.Text.ToString()) * conversionsomething;

            return descuento;
        }
        private void LimpiarCajasTexto()
        {
            txtNombre.Clear();
            txtDescuentoAplicado.Clear();
            txtMontoAPagar.Clear();
            txtNumeroFactura.Clear();
            txtNumeroFactura.Text = ObtenerNumeroFactura().ToString();
        }
        private int pagarcompra()
        {
            int totalpagar = 0;

            for (int i = 0; i < this.dgv_prendas_comprar.Rows.Count; i++)
            {
                totalpagar += Int32.Parse(dgv_prendas_comprar.Rows[i].Cells[3].Value.ToString());
            }

            return totalpagar;
        }

    }
}
