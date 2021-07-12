using Prueba3DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3DAL.DAL
{
    public class TipoDAL
    {

        private static List<Tipo> tipo = new List<Tipo>()
        {
            new Tipo()
            {
                Id = 1,
                Nombre = "Gasolina"
            },
            new Tipo()
            {
                Id = 2,
                Nombre = "Electrico"
            }
        };

        public List<Tipo> GetAll()
        {
            return tipo;
        }

    }
}
