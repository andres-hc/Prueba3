using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3DAL
{
    public class EstacionServicio
    {
        // capacidadMaxima, direccion.
        private String direccion;
        private int capacidadMaxima;

        public string Direccion { get => direccion; set => direccion = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
    }
}
