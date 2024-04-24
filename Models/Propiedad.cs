using System;
using System.Collections.Generic;

namespace RentFacil.Models
{
    [Serializable]
    public class Propiedad
    {
        public int IdPropiedad {get; set;}
        public int Area {get; set;}
        public string NroHabitaciones {get; set;}
        public bool Disponible { get; set;}
        public int PrecioAlquiler { get; set;}

        public static List<Propiedad> DatosPropiedad(int cantidad)
        {
            var random = new Random();
            var propiedadDatos = new List<Propiedad>();

            for (int i = 0; i < cantidad; i++)
            {
                var propiedad = new Propiedad
                {
                    IdPropiedad = random.Next(1000),
                    Area = random.Next(50, 200),
                    NroHabitaciones = random.Next(1, 5).ToString(),
                    Disponible = random.Next(2) == 0,
                    PrecioAlquiler = random.Next(500, 2000)
                };

                propiedadDatos.Add(propiedad);
            }

            return propiedadDatos;
        }
    }
}