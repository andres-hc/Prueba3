﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3DAL
{
    public partial class PuntoCarga
    {
        //id, tipo, capacidadMaxima, fechaVencimiento.
        private int id;
        private int tipo;
        private int capacidadMaxima;
        private String fechaVencimiento;

        public int Id { get => id; set => id = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
    }
}
