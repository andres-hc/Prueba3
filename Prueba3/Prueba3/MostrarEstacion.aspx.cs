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
    public partial class MostrarEstacion : System.Web.UI.Page
    {

        EstacionServicioDAL estacionServicioDAL = new EstacionServicioDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(estacionServicioDAL.GetAll());
            }
        }

        private void CargarTabla(List<EstacionServicio> estaciones)
        {
            estacionesGrid.DataSource = estaciones;
            estacionesGrid.DataBind();
        }

        protected void estacionesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                String idEstEliminar = e.CommandArgument.ToString();
                int eS = Convert.ToInt32(idEstEliminar);
                estacionServicioDAL.Remove(eS);
                //Actualizar
                CargarTabla(estacionServicioDAL.GetAll());
            }
        }
    }
}