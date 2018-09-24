using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Tableros
{
    public class Panel
    {
        public TipoPanel tipoPanel { get; set; }
        public Coordenada coordenadas { get; set; }

        public Panel(int fila, int columna)
        {
            coordenadas = new Coordenada(fila, columna);
            tipoPanel = TipoPanel.Vacio;
        }

        public string Estado
        {
            get
            {
                return tipoPanel.GetAttributeOfType<DescriptionAttribute>().Description;
            }
        }

        public bool estaOcupado
        {
            get
            {
                return tipoPanel == TipoPanel.Corbeta
                    || tipoPanel == TipoPanel.Destructor
                    || tipoPanel == TipoPanel.Fragata
                    || tipoPanel == TipoPanel.Portaaviones
                    || tipoPanel == TipoPanel.Submarino;
            }
        }


        public bool utilizaRandom
        {
            get
            {
                return (coordenadas.fila % 2 == 0 && coordenadas.columna % 2 == 0)
                    || (coordenadas.fila % 2 == 1 && coordenadas.columna % 2 == 1);
            }
        }
    }
}
