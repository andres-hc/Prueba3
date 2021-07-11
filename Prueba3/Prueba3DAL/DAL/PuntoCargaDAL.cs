using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3DAL.DAL
{
    public class PuntoCargaDAL
    {
        private static List<PuntoCarga> puntoCarga = new List<PuntoCarga>();

        private void Add(PuntoCarga p)
        {
            puntoCarga.Add(p);
        }

        //Recuperar lista de puntos carga
        public List<PuntoCarga> GetAll()
        {
            return puntoCarga;
        }

        //Filtrar por tipo
        public List<PuntoCarga> GetAll(int tipo)
        {
            return puntoCarga.FindAll(t => t.Tipo == tipo);
        }

        //Eliminar Punto Carga

    }
}
