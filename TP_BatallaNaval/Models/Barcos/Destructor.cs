using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Barcos
{
    public class Destructor : Barco
    {
        public Destructor()
        {
            nombre = "Destructor";
            largo = 2;
            tipoPanel = TipoPanel.Destructor;
        }
    }
}
