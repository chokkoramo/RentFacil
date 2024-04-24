using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentFacil.Models
{
    public class Arrendatario
    {
        private int idArrendatario;
        private string nombre;
        private string direccion;
        private string correo;

        public Arrendatario(int idArrendatario, string nombre, string direccion, string correo)
        {
            this.idArrendatario = idArrendatario;
            this.nombre = nombre;
            this.direccion = direccion;
            this.correo = correo;
        }

        public int IdArrendatario { get => idArrendatario; set => idArrendatario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}