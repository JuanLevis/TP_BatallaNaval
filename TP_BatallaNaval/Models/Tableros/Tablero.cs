using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Tableros
{
    public class Tablero
    {
        public List<Panel> paneles { get; set; }

        public Tablero()
        {
            paneles = new List<Panel>();
            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    paneles.Add(new Panel(i, j));
                }
            }
        }
    }
}
