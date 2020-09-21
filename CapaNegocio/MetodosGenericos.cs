using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1._0.CapaNegocio
{
    class MetodosGenericos: ConexionBBDD
    {
        private SqlCommand Comando = new SqlCommand();
        SqlDataReader LeerFilas;

        public void LlenarComboBox(ComboBox cb)
        {
            DataTable Tabla = new DataTable();
            
            Comando.Connection = Conexion;
            Conexion.Open();
            Comando.CommandText = "ListarJerarquia";
            Comando.CommandType = CommandType.StoredProcedure;

            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);

            DataRow fila = Tabla.NewRow();
            fila[0] = 0;
            fila[1] = "Seleccione un valor";
            Tabla.Rows.InsertAt(fila, 0);


            LeerFilas.Close();
            Conexion.Close();

            cb.DataSource = Tabla;
            cb.DisplayMember = "nombre";
            cb.ValueMember = "idJerarquia";

            cb.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb.AutoCompleteSource = AutoCompleteSource.ListItems;

        }


        }
    }
