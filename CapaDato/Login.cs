using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._0.CapaDato
{
    class Login
    {
        private string usuario;
        private string pass;
        int idJerarquia;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Pass { get => pass; set => pass = value; }
        public int IdJerarquia { get => idJerarquia; set => idJerarquia = value; }

        public Login(string usuario, string pass, int idJerarquia)
        {
            Usuario = usuario;
            Pass = pass;
            IdJerarquia = idJerarquia;
        }

        public Login(string usuario, string pass)
        {
            Usuario = usuario;
            Pass = pass;
        }
    }
}
