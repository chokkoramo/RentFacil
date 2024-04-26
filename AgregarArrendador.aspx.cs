using RentFacil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace RentFacil
{
    public partial class AgregarArrendador : System.Web.UI.Page
    {
        private List<Arrendador> listaArrendadores = new List<Arrendador>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Enlazar datos al GridView
                GridViewArrendatarios.DataSource = listaArrendadores;
                GridViewArrendatarios.DataBind();
            }
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreArrendador.Text;
            string direccion = txtDireccionArrendador.Text;
            int idPropiedad = Convert.ToInt32(ddlPropiedades.SelectedValue);

            Arrendador nuevoArrendador = new Arrendador(nombre, direccion);

            var propiedadSeleccionada = Propiedad.DatosPropiedad().FirstOrDefault(p => p.IdPropiedad == idPropiedad);
            if (propiedadSeleccionada != null)
            {
                nuevoArrendador.Propiedades.Add(propiedadSeleccionada);
            }

            listaArrendadores.Add(nuevoArrendador);

            GridViewArrendatarios.DataSource = listaArrendadores;
            GridViewArrendatarios.DataBind();

        }
    }
}
