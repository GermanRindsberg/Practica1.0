using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1._0.CapaDato;

namespace Practica1._0.CapaNegocio
{
    class MetodosLogin : ConexionBBDD
    {
        private SqlCommand Comando = new SqlCommand();

        SqlDataReader LeerFilas;

        public Boolean VerificarPassword(Login lg)
        {
            Comando.Connection = Conexion;//le paso la conexion a donde conectarse, que esta heredada de conexionBBDD
            Conexion.Open();//abro la conexion a base de datos
            Comando.CommandText = "ValidarUserYpass";//le pasas al comando que tiene que buscar
            Comando.CommandType = CommandType.StoredProcedure;//que tipo de dato vas a buscar?
            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("@usuario", lg.Usuario);
            Comando.Parameters.AddWithValue("@pass", lg.Pass);
            LeerFilas = Comando.ExecuteReader();
            if (LeerFilas.Read())
            {
                MessageBox.Show("Ingresado con exito!");
                LeerFilas.Close();
                Conexion.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Error en usuario o contraseña");
                LeerFilas.Close();
                Conexion.Close();
                return false;
            }
            
        }

        public void InsertarUsuarioYpass(Login lg)
        {

            if (ValidarDueño() == true)
            {
                MessageBox.Show("Usuario dueño ya existente");
            }
            else
            {
                Comando.Connection = Conexion;//le paso la conexion a donde conectarse, que esta heredada de conexionBBDD
                Conexion.Open();//abro la conexion a base de datos
                Comando.CommandText = "InsertarUsuario";//le pasas al comando que tiene que buscar
                Comando.CommandType = CommandType.StoredProcedure;//que tipo de dato vas a buscar
                Comando.Parameters.AddWithValue("@usuario", lg.Usuario);
                Comando.Parameters.AddWithValue("@pass", lg.Pass);
                Comando.Parameters.AddWithValue("@idJerarquia", lg.IdJerarquia);
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Insertado con exito");//mensaje en pantalla
            }
        }

        public Boolean ValidarDueño()
        {
            Comando.Connection = Conexion;//le paso la conexion a donde conectarse, que esta heredada de conexionBBDD
            Conexion.Open();//abro la conexion a base de datos
            Comando.CommandText = "validarDueño";//le pasas al comando que tiene que buscar
            Comando.CommandType = CommandType.StoredProcedure;//que tipo de dato vas a buscar
            LeerFilas = Comando.ExecuteReader();
            while (LeerFilas.Read())
            {
                if (LeerFilas.GetValue(0).ToString() == "1")
                {
                  
                    return true;
                }
            }
            Conexion.Close();
            LeerFilas.Close();
            return false;
        }


    }
}
