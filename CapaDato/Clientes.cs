using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._0.CapaDato
{
    class Clientes
    {
        string contacto;
        string email;
        int telefono;
        int cuit;

      //getter setters cliente

        public string Contacto { get => Contacto1; set => Contacto1 = value; }
        public string Email { get => Email1; set => Email1 = value; }
        public int Telefono { get => Telefono1; set => Telefono1 = value; }
        public int Cuit { get => Cuit1; set => Cuit1 = value; }
        public string Contacto1 { get => contacto; set => contacto = value; }
        public string Email1 { get => email; set => email = value; }
        public int Telefono1 { get => telefono; set => telefono = value; }
        public int Cuit1 { get => cuit; set => cuit = value; }

        //constructor
        public Clientes(string contacto, string email, int telefono, int cuit)
        {
            this.contacto = contacto;
            this.email = email;
            this.telefono = telefono;
            this.cuit = cuit;
        }

        public Clientes()
        {

        }
    }
}
