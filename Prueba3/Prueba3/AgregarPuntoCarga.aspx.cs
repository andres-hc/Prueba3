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
    public partial class AgregarPuntoCarga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Tipo> tipo = new TipoDAL().GetAll();
                tipoDd.DataSource = tipo;
                tipoDd.DataTextField = "Nombre";
                tipoDd.DataValueField = "Id";
                tipoDd.DataBind();
            }
        }

        protected void registrarPtoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}