using RentFacil.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace RentFacil
{
    public partial class AgregarArrendatario : System.Web.UI.Page
    {
        private List<Arrendatario> listaArrendatarios = new List<Arrendatario>();
        public List<Propiedad> propiedadDatos;
        protected void Page_Load(object sender, EventArgs e)
        {
            propiedadDatos = Propiedad.DatosPropiedad(10);
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5]
                {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("Nombre", typeof(string)),
                    new DataColumn("Direccion", typeof(string)),
                    new DataColumn("Correo", typeof(string)),
                    new DataColumn("Contrato", typeof(string))
                });
                ViewState["Arrendatario"] = dt;

                if (ViewState["Propiedades"] == null)
                {
                    ViewState["Propiedades"] = Propiedad.DatosPropiedad(10);
                }

                var propiedades = (List<Propiedad>)ViewState["Propiedades"];
                var contratosAleatorios = Contratos.GenerarDatosAleatorios(10, propiedades);
                var propiedadesDisponiblesViewState = ((List<Propiedad>)ViewState["Propiedades"]).OrderBy(p => p.IdPropiedad).ToList();
                var propiedadesDisponiblesFiltradas = propiedadesDisponiblesViewState.Where(p => p.Disponible).ToList();

                ddlContratos.DataSource = propiedadesDisponiblesFiltradas;
                ddlContratos.DataTextField = "IdPropiedad";
                ddlContratos.DataValueField = "IdPropiedad";
                ddlContratos.DataBind();
            }


        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            int idArrendatario = Convert.ToInt32(txtID.Text);
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;
            string contrato = ddlContratos.SelectedItem.Text;

            Arrendatario arrendatario1 = new Arrendatario(idArrendatario, nombre, direccion, correo);
            listaArrendatarios.Add(arrendatario1);

            DataTable dt = (DataTable)ViewState["Arrendatario"];
            dt.Rows.Add(idArrendatario, nombre, direccion, correo, contrato);
            ViewState["Arrendatario"] = dt;

            GridViewArrendatarios.DataSource = dt;
            GridViewArrendatarios.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}