using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avance_3.UI
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_password.Text.Equals("") || txt_confirmpswd.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar ambos campos para la contraseña.");
            } else if (txt_password.Text.Equals(txt_confirmpswd.Text))
            {

            }
            else
            {
                MessageBox.Show("Las contraseñas NO coinciden. Deben coincidir.");
            }
        
        }

        private void SaveUser()
        {

        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
