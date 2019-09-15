using Avance_3.UI;
using System;
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
                login(cedula, pswd);
            }
        }

        public Boolean login(string cedula, string contrasena)
        {
            Boolean prueba = true;
            txt_id.Text = cedula;
            txt_pass.Text = contrasena;


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
                    prueba = true;
                }
            }
            else
            {
                MessageBox.Show("Credenciales no correctas");
                prueba = false;
            }


            NuevaConnexion.conexion.Close();
            return prueba;
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
