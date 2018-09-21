using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Barcos
{
    public abstract class Barco
    {
        public string nombre { get; set; }
        public int largo { get; set; }
        public int hits { get; set; }
        public TipoPanel tipoPanel { get; set; }
        public bool estaHundido {
            get
            {
                return hits >= largo;
            }
        }
    }
}
