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
using Avance_3.DbConnector;

namespace Avance_3
{
    public partial class LoginForm : Form
    {
        SQLDbConnect NuevaConnexion = new SQLDbConnect();
        SqlCommand sqlcommand = new SqlCommand();
        static SqlDataReader dr;
        public static string displayName;

        public LoginForm()
        {
            InitializeComponent();
            //UserDisplayName.displayName = txt_usr.Text;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NuevoUsuario().ShowDialog();
        }

        //Botón para iniciar sesión
        private void Btn_login_Click(object sender, EventArgs e)
        {
            SqlLogin();
        }

        private void SqlLogin()
        {
            string cedula = txt_id.Text;
            string pswd = txt_pass.Text;

            if (cedula.Equals("") && pswd.Equals(""))
            {
                MessageBox.Show("No se ha ingresado nada");
            } else
            {
                login();
            }
        }

        private void login()
        {
            string cedula = txt_id.Text;
            string contrasena = txt_pass.Text;


            NuevaConnexion.EstablecerConexion();
            sqlcommand.Connection = NuevaConnexion.conexion;
            sqlcommand.CommandText = "SELECT * FROM Usuarios WHERE cedula='" + txt_id.Text + "' AND contrasena='" + txt_pass.Text + "';";

            dr = sqlcommand.ExecuteReader();

            if (dr.Read())
            {
                if (cedula.ToString().Equals(dr["cedula"].ToString()))
                {
                    MessageBox.Show($"Bienvenido {cedula}");
                    UserDisplayName.displayName = txt_id.Text;
                    this.Hide();
                    new MenuPrincipal().ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Credenciales no correctas");
                // prueba = false;
            }
            

            NuevaConnexion.conexion.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_Time.Text = DateTime.Now.ToLongTimeString();

            lbl_Date.Text = DateTime.Now.ToLongDateString();            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

    }

    public class UserDisplayName
    {
        public static string displayName;
    }


}
