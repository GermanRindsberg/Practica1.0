using Practica1._0.CapaDato;
using Practica1._0.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1._0.CapaPresentacion
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        MetodosLogin metodoLogin = new MetodosLogin();

        public FormLogin()
        {
            InitializeComponent();
        }

        #region EVENTOS login
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblNuevoUsuario_MouseEnter(object sender, EventArgs e)
        {
            lblNuevoUsuario.ForeColor = Color.Red;
        }

        private void lblNuevoUsuario_MouseLeave(object sender, EventArgs e)
        {
            lblNuevoUsuario.ForeColor = Color.White;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Login login = new Login(txtUsuario.Text, txtPass.Text);

            metodoLogin.VerificarPassword(login);

        }


        #endregion

        #region METODOS






        #endregion

        private void lblNuevoUsuario_Click(object sender, EventArgs e)
        {
            FormUsuarioNuevo fr = new FormUsuarioNuevo();
            fr.ShowDialog();
        }
    }
}
