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
        private int idEstacionServicio;
        private int capacidadMaxima;

        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public int IdEstacionServicio { get => idEstacionServicio; set => idEstacionServicio = value; }
    }
}
