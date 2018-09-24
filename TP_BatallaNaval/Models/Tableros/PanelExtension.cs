using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Tableros
{
    public static class PanelExtension
    {
        /// <summary>
        /// Devuelve el panel ubicado en las coordenadas dadas
        /// </summary>
        /// <param name="paneles"></param>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        public static Panel ubicado(this List<Panel> paneles, int fila, int columna)
        {
            return paneles.Where(x => x.coordenadas.fila == fila && x.coordenadas.columna == columna).FirstOrDefault();
        }

        public static List<Panel> Rango(this List<Panel> paneles ,int filaInicio, int columnaInicio , int filaFinal, int columnaFinal)
        {
            return paneles.Where(x => x.coordenadas.fila >= filaInicio
                                 && x.coordenadas.columna >= columnaInicio
                                 && x.coordenadas.fila <= filaFinal
                                 && x.coordenadas.columna <= columnaFinal).ToList();
        }
    }
}
