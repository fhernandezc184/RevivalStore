using Avance_3.DbConnector;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Avance_3.UI;

namespace Avance_3.Inventario
{
    public partial class InventarioForm : Form, IFunciones
    {
        static SQLDbConnect nuevaconnexion = new SQLDbConnect();
        DataTable dtbl = new DataTable();
        private SqlDataAdapter sda;
        private string concesion;

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
            using (nuevaconnexion.conexion = new SqlConnection(nuevaconnexion.conexion.ConnectionString))
            {
                dtbl.Clear();
                nuevaconnexion.EstablecerConexion();                
                sda = new SqlDataAdapter("SELECT idPrenda AS ID" +
                    ",Tipo_Prenda AS Tipo" +
                    ",Marca_Prenda AS Marca" +
                    ",Talla_Prenda AS Talla" +
                    ",Cant_Prenda AS Cantidad" +
                    ",Precio AS Precio, Concesion FROM Inventario ORDER  BY idPrenda;", nuevaconnexion.conexion);
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
        

        public void Delete()
        {
         
            int identification = Int32.Parse(txt_ID.Text);
            try
            {
                string query = "DELETE FROM Inventario WHERE idPrenda  = " + identification + ";";
                nuevaconnexion.SqlQuery(query);
                nuevaconnexion.Execute();
                MessageBox.Show("Datos eliminados correctamente");
                nuevaconnexion.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de eliminación");
                nuevaconnexion.CloseConnection();
            }
        }

        public void Insert()
        {    
            string type = txt_Tipo.Text;
            string brand = txt_Marca.Text;
            string size = txt_Talla.Text;
            string quantity = txt_Cantidad.Text;
            string price = txt_Precio.Text;
            try
            {
                string query = "INSERT INTO Inventario (Tipo_Prenda,Marca_Prenda,Talla_Prenda,Cant_Prenda,Precio,Concesion) VALUES('" + type + "','" + brand + "','" + size + "','" + quantity + "','" + price + "','" + GetConsecionValue(ChkConcesion.CheckState.ToString()) + "');";
                nuevaconnexion.SqlQuery(query);
                nuevaconnexion.Execute();
                nuevaconnexion.CloseConnection();
                MessageBox.Show("Datos ingresados correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la prenda, Itente de Nuevo");
                nuevaconnexion.CloseConnection();
            }
        }

        public void Update()
        {
            int identification = Int32.Parse(txt_ID.Text);

            string type = txt_Tipo.Text;
            string brand = txt_Marca.Text;
            string size = txt_Talla.Text;
            string quantity = txt_Cantidad.Text;
            string price = txt_Precio.Text;
            try
            {
                string query = "UPDATE Inventario SET Tipo_Prenda = '" + type + "', Marca_Prenda = '" + brand + "', Talla_Prenda = '" + size + "', Cant_Prenda ='" + quantity + "', Precio ='" + price + "', Concesion ='" + GetConsecionValue(ChkConcesion.CheckState.ToString()) + "' WHERE idPrenda = '" + identification + "';";
                nuevaconnexion.SqlQuery(query);
                nuevaconnexion.Execute();
                nuevaconnexion.CloseConnection();
                MessageBox.Show("Datos ingresados correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la prenda, Itente de Nuevo");
                nuevaconnexion.CloseConnection();
            }
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            string searchVal = txt_Buscar.Text;
            Search(searchVal);
        }

        private void Dgv_Inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ChkConcesion.Checked = false;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_Inventario.Rows[index];
            txt_ID.Text = selectedRow.Cells[0].Value.ToString();
            txt_Tipo.Text = selectedRow.Cells[1].Value.ToString();
            txt_Marca.Text = selectedRow.Cells[2].Value.ToString();
            txt_Talla.Text = selectedRow.Cells[3].Value.ToString();
            txt_Cantidad.Text = selectedRow.Cells[4].Value.ToString();
            txt_Precio.Text = selectedRow.Cells[5].Value.ToString();
            if (selectedRow.Cells[6].Value.ToString() == "True")
            {
                ChkConcesion.Checked = true;
            }
            else
            {
                ChkConcesion.Checked = false;
            }
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Insert();
            dgv_Inventario.Refresh();
            LoadInventario();
        }

        public string GetConsecionValue(string concesionvalue)
        {
            if (concesionvalue == "Unchecked")
            {
                concesion = "FALSE";
            }
            else
            {
                concesion = "TRUE";
            }
            return concesion;
        }



        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Delete();
            dgv_Inventario.Refresh();
            LoadInventario();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Update();
            dgv_Inventario.Refresh();
            LoadInventario();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuPrincipal().ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadInventario();
        }
    }
}
