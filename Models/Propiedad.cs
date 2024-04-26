using System;
using System.Collections.Generic;

namespace RentFacil.Models
{
    [Serializable]
    public class Propiedad
    {
        public int IdPropiedad { get; set; }
        public int Area { get; set; }
        public string NroHabitaciones { get; set; }
        public bool Disponible { get; set; }
        public int PrecioAlquiler { get; set; }

        public static List<Propiedad> DatosPropiedad()
        {
            var propiedadDatos = new List<Propiedad>
            {
                new Propiedad { IdPropiedad = 1, Area = 120, NroHabitaciones = "3", Disponible = true, PrecioAlquiler = 1500 },
                new Propiedad { IdPropiedad = 2, Area = 80, NroHabitaciones = "2", Disponible = false, PrecioAlquiler = 900 },
                new Propiedad { IdPropiedad = 3, Area = 150, NroHabitaciones = "4", Disponible = true, PrecioAlquiler = 1800 },
                new Propiedad { IdPropiedad = 4, Area = 100, NroHabitaciones = "2", Disponible = true, PrecioAlquiler = 1200 },
                new Propiedad { IdPropiedad = 5, Area = 70, NroHabitaciones = "1", Disponible = false, PrecioAlquiler = 750 },
                new Propiedad { IdPropiedad = 6, Area = 180, NroHabitaciones = "5", Disponible = true, PrecioAlquiler = 2100 },
                new Propiedad { IdPropiedad = 7, Area = 130, NroHabitaciones = "3", Disponible = true, PrecioAlquiler = 1600 },
                new Propiedad { IdPropiedad = 8, Area = 90, NroHabitaciones = "2", Disponible = false, PrecioAlquiler = 850 },
                new Propiedad { IdPropiedad = 9, Area = 110, NroHabitaciones = "3", Disponible = true, PrecioAlquiler = 1400 },
                new Propiedad { IdPropiedad = 10, Area = 60, NroHabitaciones = "1", Disponible = true, PrecioAlquiler = 700 }
            };

            return propiedadDatos;
        }
    }
}
