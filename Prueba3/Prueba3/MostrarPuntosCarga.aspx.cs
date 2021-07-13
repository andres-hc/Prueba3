using Prueba3DAL;
using Prueba3DAL.DAL;
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
            ptosCargaGrid.DataSource = puntos;
            ptosCargaGrid.DataBind();
        }

        protected void ptosCargaGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                String idPtoEliminar = e.CommandArgument.ToString();
                int pC = Convert.ToInt32(idPtoEliminar);
                puntoCargaDAL.Remove(pC);
            }
        }
    }
}