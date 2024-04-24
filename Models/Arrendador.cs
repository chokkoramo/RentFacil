using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentFacil.Models
{
    public class Arrendador
    {
        private string nombre;
        private string direccion;
        private List<Propiedad> propiedades;

        public Arrendador(string nombre, string direccion, List<Propiedad> propiedades)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.propiedades = propiedades;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<Propiedad> Propiedades { get => propiedades; set => propiedades = value; }
    }
}