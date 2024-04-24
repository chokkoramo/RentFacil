
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentFacil.Models
{
    public class Contratos
    {
        public Contratos(int idContrato, DateTime fechaInicio, double costoMensual)
        {
            this.IdContrato = idContrato;
            this.FechaInicio = fechaInicio;
            this.CostoMensual = costoMensual;
            this.Propiedades = new List<Propiedad>();
        }

        private int idContrato;
        private DateTime fechaInicio;
        private double costoMensual;


        public int IdContrato { get => idContrato; set => idContrato = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public double CostoMensual { get => costoMensual; set => costoMensual = value; }
        public List<Propiedad> Propiedades { get; set; }
        public static List<Contratos> GenerarDatosAleatorios(int cantidad, List<Propiedad> propiedades)
        {
            var random = new Random();
            var contratosAleatorios = new List<Contratos>();

            for (int i = 0; i < cantidad; i++)
            {
                var contrato = new Contratos(
                    idContrato: random.Next(1000),
                    fechaInicio: DateTime.Now.AddDays(-random.Next(365)), 
                    costoMensual: random.NextDouble() * 1000 
                );

                int cantidadPropiedades = random.Next(1, 4);
                for (int j = 0; j < cantidadPropiedades; j++)
                {
                    var propieda = propiedades[random.Next(propiedades.Count)];
                    contrato.Propiedades.Add(propieda);
                }

                contratosAleatorios.Add(contrato);
            }

            return contratosAleatorios;
        }

    }
}