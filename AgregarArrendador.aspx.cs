using RentFacil.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3]
                {
                    new DataColumn("Nombre", typeof(string)),
                    new DataColumn("Direccion", typeof(string)),
                    new DataColumn("Propieadad", typeof(string))
                });
                ViewState["Arrendador"] = dt;

                if (ViewState["Propiedades"] == null)
                {
                    ViewState["Propiedades"] = Propiedad.DatosPropiedad();
                }

                var propiedades = (List<Propiedad>)ViewState["Propiedades"];

                var propiedadesDisponiblesViewState = ((List<Propiedad>)ViewState["Propiedades"]).OrderBy(p => p.IdPropiedad).ToList();
                var propiedadesDisponiblesFiltradas = propiedadesDisponiblesViewState.Where(p => p.Disponible).ToList();
                
                ddlPropiedades.DataSource = propiedadesDisponiblesFiltradas;
                ddlPropiedades.DataTextField = "IdPropiedad";
                ddlPropiedades.DataValueField = "IdPropiedad";
                ddlPropiedades.DataBind();

            }
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreArrendador.Text;
            string direccion = txtDireccionArrendador.Text;
            int idPropiedad = Convert.ToInt32(ddlPropiedades.SelectedItem.Text);

            Arrendador nuevoArrendador = new Arrendador(nombre, direccion);
            listaArrendadores.Add(nuevoArrendador);

            var propiedadSeleccionada = Propiedad.DatosPropiedad().FirstOrDefault(p => p.IdPropiedad == idPropiedad);
            if (propiedadSeleccionada != null)
            {
                nuevoArrendador.Propiedades.Add(propiedadSeleccionada);
                ddlPropiedades.Items.Remove(ddlPropiedades.SelectedItem);
            }
            DataTable dt = (DataTable)ViewState["Arrendador"];
            dt.Rows.Add(nombre, direccion, idPropiedad);
            ViewState["Arrendador"]= dt;

            GridViewArrendador.DataSource = dt;
            GridViewArrendador.DataBind(); 

            ddlPropiedades.SelectedIndex = -1;
        }
        protected void GridViewArrendador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlPropiedades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
