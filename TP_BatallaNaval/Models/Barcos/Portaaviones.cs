using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Barcos
{
    public class Portaaviones : Barco
    {
        public Portaaviones()
        {
            nombre = "Portaaviones";
            largo = 6;
            tipoPanel = TipoPanel.Portaaviones;
        }
    }
}
