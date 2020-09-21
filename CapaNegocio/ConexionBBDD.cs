using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._0.CapaNegocio
{
    class ConexionBBDD
    {
        static private string CadenaConexion = "Server=(local);Database=Practica; integrated security=true";
      
        protected SqlConnection Conexion = new SqlConnection(CadenaConexion);
    }
}
