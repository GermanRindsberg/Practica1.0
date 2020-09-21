using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._0.CapaDato
{
    class Jerarquia
    {
        int idJerarquia;
        string nombre;

        public int IdJerarquia { get => idJerarquia; set => idJerarquia = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Jerarquia(int idJerarquia, string nombre)
        {
            IdJerarquia = idJerarquia;
            Nombre = nombre;
        }

        public Jerarquia()
        {
        }
    }
}
