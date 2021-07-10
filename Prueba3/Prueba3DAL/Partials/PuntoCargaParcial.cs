using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3DAL
{
    public partial class PuntoCarga
    {

        public String TipoTxt
        {
            get
            {
                String texto = "";
                switch (Tipo)
                {
                    case 1: texto = "Gasolina";
                        break;
                    case 2: texto = "Electrico";
                        break;
                }
                return texto;
            }
        }
    }
}
