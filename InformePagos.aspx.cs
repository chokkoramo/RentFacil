using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
using RentFacil.Models;

namespace RentFacil
{
    public partial class InformePagos : System.Web.UI.Page
    {
        private List<Arrendatario> listaArrendatarios = new List<Arrendatario>();
        public List<Propiedad> propiedadDatos;

        protected void Page_Load(object sender, EventArgs e)
        {
            propiedadDatos = Propiedad.DatosPropiedad();
            if (!IsPostBack)
            {

            }
        }

        protected void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
            DateTime fechaFin = Convert.ToDateTime(txtFechaFin.Text);


            DataTable dtPagos = ObtenerDatosDePagos(fechaInicio, fechaFin);


            GenerarInforme(dtPagos);
        }

        private DataTable ObtenerDatosDePagos(DateTime inicio, DateTime fin)
        {

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[3]
            {
                new DataColumn("Arrendatario", typeof(string)),
                new DataColumn("FechaPago", typeof(DateTime)),
                new DataColumn("Monto", typeof(decimal))
            });

            dt.Rows.Add(listaArrendatarios);


            return dt;
        }

        private void GenerarInforme(DataTable datosPagos)
        {

        }
    }
}
