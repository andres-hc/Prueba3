using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3DAL.DAL
{
    public class EstacionServicioDAL
    {
        private static List<EstacionServicio> estacionServicio = new List<EstacionServicio>();

        private void Add(EstacionServicio e)
        {
            estacionServicio.Add(e);
        }

        //Recuperar lista de estaciones servicio
        public List<EstacionServicio> GetAll()
        {
            return estacionServicio;
        }
        
        //Eliminar Estacion Servicio
        public void Remove(int idEstacionServicio)
        {
            EstacionServicio eS = estacionServicio.Find(e => e.IdEstacionServicio == idEstacionServicio);
            estacionServicio.Remove(eS);
        }
    }
}
