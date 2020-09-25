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
    public partial class FormUsuarioNuevo : Form
    {
        MetodosLogin metodoLogin = new MetodosLogin();
        MetodosGenericos mg = new MetodosGenericos();

        public FormUsuarioNuevo()
        {
            InitializeComponent();
        }

        private void listarJerarquiaEnComboBox()
        {
            mg.LlenarComboBox(comboJerarquia);
        }

        private void FormUsuarioNuevo_Load_1(object sender, EventArgs e)
        {
            listarJerarquiaEnComboBox();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Login lg = new Login(txtUsuario.Text, txtPass.Text,Convert.ToInt32(comboJerarquia.SelectedValue.ToString()));//creo el objeto a insertar, con el constructor
            metodoLogin.InsertarUsuarioYpass(lg);//inserto el objeto que cree arriba
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
