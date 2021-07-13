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
    public partial class AgregarEstacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Metodo para limpiar campos
        private void limpiarCampos()
        {
            idEstacionNum.Text = "";
            capacidadNum.Text = "";

        }

        protected void registrarEstBtn_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                int id = Convert.ToInt32(idEstacionNum.Text);
                int capacidadMaxima = Convert.ToInt32(capacidadNum.Text);

                EstacionServicio es = new EstacionServicio();
                es.IdEstacionServicio = id;
                es.CapacidadMaxima = capacidadMaxima;

                EstacionServicioDAL estacionDAL = new EstacionServicioDAL();
                estacionDAL.Add(es);

                confirmacion.Text = "Registro Exitoso!";

                limpiarCampos();


            }
            else
            {
                confirmacion.Text = "Problema al registrar. Reintente :(";
            }

        }
    }
}