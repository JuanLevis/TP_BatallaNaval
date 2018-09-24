using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Barcos
{
    public class Corbeta : Barco
    {
        public Corbeta()
        {
            nombre = "Corbeta";
            largo = 3;
            tipoPanel = TipoPanel.Corbeta;
        }
    }
}
