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

        private void limpiarCampos()
        {
            idPtoCarga.Text = "";
            capacidadMax.Text = "";
            tipoDd.SelectedIndex = 0;
            fechaTxt.Text = "";
        }

        protected void registrarPtoBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int id = Convert.ToInt32(idPtoCarga.Text);
                int tipo = Convert.ToInt32(tipoDd.SelectedValue);
                int capacidadMaxima = Convert.ToInt32(capacidadMax.Text);
                String fechaVencimiento = fechaTxt.Text;

                PuntoCarga ptoCarga = new PuntoCarga();
                ptoCarga.Id = id;
                ptoCarga.Tipo = tipo;
                ptoCarga.CapacidadMaxima = capacidadMaxima;
                ptoCarga.FechaVencimiento = fechaVencimiento;

                PuntoCargaDAL ptoCargaDAL = new PuntoCargaDAL();
                ptoCargaDAL.Add(ptoCarga);

                confirmacion.Text = "Registro Exitoso !";
                limpiarCampos();
            }
            else
            {

            }
        }

        //protected void fechaCV_ServerValidate(object source, ServerValidateEventArgs args)
        //{
        //    String fecha = fechaTxt.Text.Trim();

        //    if (fecha == string.Empty)
        //    {
        //        fechaCV.ErrorMessage = "Debe ingresar una fecha valida";
        //        args.IsValid = false;
        //    }
        //    else
        //    {
        //        String[] fechaArray = fecha.Split('-');

        //        Validador de fecha formato dd - mm - aaaa

        //        if (fechaArray.Length == 3)
        //        {
        //            if (fechaArray[0].Length != 2 && fechaArray[1].Length != 2 && fechaArray[2].Length != 4)
        //            {
        //                fechaCV.ErrorMessage = "La fecha no tiene el formato valido, ingrese como se indica.";
        //                args.IsValid = false;
        //            }
        //            else
        //            {
        //                args.IsValid = true;
        //            }
        //        }
        //        else
        //        {
        //            fechaCV.ErrorMessage = "La fecha no tiene el formato valido, ingrese como se indica.";
        //            args.IsValid = false;
        //        }
        //    }
        //}
    }
}