using Prueba3DAL;
using Prueba3DAL.DAL;
using Prueba3DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba3
{
    public partial class MostrarPuntosCarga : System.Web.UI.Page
    {

        PuntoCargaDAL puntoCargaDAL = new PuntoCargaDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }
        }

        private void CargarTabla(List<PuntoCarga> puntos)
        {
            puntosGrid.DataSource = puntos;
            puntosGrid.DataBind();
        }

        protected void tipoDd_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tipoSlct = tipoDd.SelectedValue;
            if (tipoDd.SelectedValue == "")
            {
                CargarTabla(puntoCargaDAL.GetAll());
            }
            else
            {
                List<PuntoCarga> filtro = puntoCargaDAL.GetAll(Convert.ToInt32(tipoSlct));
                CargarTabla(filtro);
            }
        }

        protected void puntosGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }

        protected void puntosGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            //GridViewRow obj = puntosGrid.Rows[e.RowIndex];

            //String tipo = (obj.FindControl("tipo2") as TextBox).Text.ToUpper();
            //int capacidad = Convert.ToInt32((obj.FindControl("cap2") as TextBox).Text);
            //String fV = (obj.FindControl("fv2") as TextBox).Text.ToUpper();

        }

        protected void puntosGrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }
    }
}