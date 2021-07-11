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
        private int region;
        private int capacidadMaxima;

        public int Region { get => region; set => region = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
    }
}
