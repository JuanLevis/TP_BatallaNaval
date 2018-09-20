using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Tableros
{
    public class Coordenada
    {
        public int fila { get; set; }
        public int columna { get; set; }

        public Coordenada(int fila, int columna)
        {
            this.fila = fila;
            this.columna = columna;
        }
    }
}
