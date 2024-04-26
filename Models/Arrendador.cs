using System.Collections.Generic;

namespace RentFacil.Models
{
    public class Arrendador
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Propiedad> Propiedades { get; set; }

        public Arrendador(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Propiedades = new List<Propiedad>();
        }
    }
}
