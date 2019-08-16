using Avance_3.DbConnector;
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

namespace Avance_3.Inventario
{
    public partial class InventarioForm : Form, IFunciones
    {
        static SQLDbConnect nuevaconnexion = new SQLDbConnect();
        static SqlDataReader dr;
        DataTable dtbl = new DataTable();
        SqlDataAdapter sda;
        SqlCommand sqlcommand;
        SqlConnection conn; //Quitar después
        DataSet ds;

        public InventarioForm()
        {
            InitializeComponent();
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            LoadInventario();
        }

        private void LoadInventario()
        {
            //SqlDataAdapter adapt;
            //string sqlConn = "Data Source=revivalstore.database.windows.net;Initial Catalog=RevivalStore;Persist Security Info=True;User ID=RevivalAdmin;Password=Nacidos2012";
            //SqlConnection conn = new SqlConnection(sqlConn);

            //conn.Open();
            //DataTable dt = new DataTable();

            //adapt = new SqlDataAdapter("SELECT * FROM Inventario", sqlConn);
            //adapt.Fill(dt);
            //dgv_Inventario.DataSource = dt;

            //conn.Close();



            
            using (nuevaconnexion.conexion = new SqlConnection(nuevaconnexion.conexion.ConnectionString))
            {
                nuevaconnexion.EstablecerConexion();                
                SqlDataAdapter sda = new SqlDataAdapter("SELECT idPrenda AS ID" +
                    ",Tipo_Prenda AS Tipo" +
                    ",Marca_Prenda AS Marca" +
                    ",Talla_Prenda AS Talla" +
                    ",Cant_Prenda AS Cantidad" +
                    ",Precio AS Precio FROM Inventario;", nuevaconnexion.conexion);

                sda.Fill(dtbl);
                dgv_Inventario.DataSource = dtbl;
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void Txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Search(string SearchValue)
        {
            DataView dv = dtbl.DefaultView;
            dv.RowFilter = string.Format("Tipo LIKE '%{0}%'", SearchValue);
            dgv_Inventario.DataSource = dv.ToTable();
        }
        
        private void TestClear()
        {
            if (dgv_Inventario.DataSource != null)
            {
                dgv_Inventario.DataSource = null;
            } 
            else
            {
                dgv_Inventario.Rows.Clear();
            }
        }

        public void Delete()
        {
            /* NO FUNKATION
            int identification = Int32.Parse(txt_ID.Text);              
            try
            {
                string query = "DELETE FROM Inventario WHERE idPrenda ='" + identification + "';";
                nuevaconnexion.SqlQuery(query);
                nuevaconnexion.Execute();
                MessageBox.Show("Datos eliminados correctamente");                
                
            } catch (Exception ex)
            {
                MessageBox.Show("Error de eliminación");
            }
            dgv_Inventario.DataSource = null;
            */
        }

        public void Insert()
        {      /*     TAMPOCO FUNKATION
            string type = txt_Tipo.Text;
            string brand = txt_Marca.Text;
            string size = txt_Talla.Text;
            string quantity = txt_Cantidad.Text;
            string price = txt_Precio.Text;

            string query = "INSERT INTO Inventario (Tipo_Prenda,Marca_Prenda,Talla_Prenda,Cant_Prenda,Precio) VALUES('" + type + "','" + brand + "','" + size + "','" + quantity + "','" + price + "');";
            nuevaconnexion.SqlQuery(query);
            nuevaconnexion.Execute();
            
            //nuevaconnexion.CloseConnection();            

            MessageBox.Show("Datos ingresados correctamente!");
            LoadInventario();
            //dgv_Inventario.DataSource = null;
            //MessageBox.Show("Been set source to null");
            //dgv_Inventario.Rows.Clear();

            //LoadInventario();
            */


        }

        public void Update()
        {

        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string searchVal = txt_Buscar.Text;
            Search(searchVal);
        }

        private void Dgv_Inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Inventario.Rows[index];
            txt_ID.Text = selectedRow.Cells[0].Value.ToString();
            txt_Tipo.Text = selectedRow.Cells[1].Value.ToString();
            txt_Marca.Text = selectedRow.Cells[2].Value.ToString();
            txt_Talla.Text = selectedRow.Cells[3].Value.ToString();
            txt_Cantidad.Text = selectedRow.Cells[4].Value.ToString();
            txt_Precio.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            //Insert();
            //dgv_Inventario.Update();
           // LoadInventario();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadInventario();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
         //   Delete();
         //   dgv_Inventario.Update();

        }
    }
}

/*
 * 
 * 
 * DataView dv = new DataView();
            dv.RowFilter = string.Format("Tipo LIKE '%{0}%'", txt_Buscar.Text);
            dgv_Inventario.DataSource = dv;
*/

//dgv_Inventario.Rows.Clear();

/*
foreach (DataRow item in dtbl.Rows)
{
    int n = dgv_Inventario.Rows.Add();
    //dgv_Inventario.Rows[n].Cells[0].Value = false;
    dgv_Inventario.Rows[n].Cells[0].Value = item["Tipo_Prenda"].ToString();
    dgv_Inventario.Rows[n].Cells[1].Value = item["Marca_Prenda"].ToString();
    dgv_Inventario.Rows[n].Cells[2].Value = item["Talla_Prenda"].ToString();
    dgv_Inventario.Rows[n].Cells[3].Value = item["Cant_Prenda"].ToString();
}
*/
