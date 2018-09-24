using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Barcos
{
    public class Fragata : Barco
    {
        public Fragata()
        {
            nombre = "Fragata";
            largo = 5;
            tipoPanel = TipoPanel.Fragata;
        }
    }
}
