using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Barcos
{
    public class Submarino : Barco
    {
        public Submarino()
        {
            nombre = "Submarino";
            largo = 4;
            tipoPanel = TipoPanel.Submarino;
        }
    }
}
