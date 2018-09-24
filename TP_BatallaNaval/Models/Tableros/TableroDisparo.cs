using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models.Tableros
{
    public class TableroDisparo : Tablero
    {

        /// <summary>
        /// Devuelve una lista de coordenadas que tengo disponible para disparar con estrategia random
        /// </summary>
        /// <returns></returns>
        public List<Coordenada> casillasDisponibles()
        {
            return paneles.Where(x => x.tipoPanel == TipoPanel.Vacio && x.utilizaRandom).Select(x => x.coordenadas).ToList();
        }

        /// <summary>
        /// Obtiene los paneles adyacentes a los paneles que se les pego y tienen un barco
        /// </summary>
        /// <returns></returns>
        public List<Coordenada> obtenerAdyacentesDisparados()
        {
            List<Panel> lstPaneles = new List<Panel>();
            var hits = paneles.Where(x => x.tipoPanel == TipoPanel.Hit);

            foreach (var hit in hits)
            {
                lstPaneles.AddRange(obtenerAdyacentes(hit.coordenadas).ToList());
            }
            return lstPaneles.Distinct().Where(x => x.tipoPanel == TipoPanel.Vacio).Select(x => x.coordenadas).ToList();
        }

        /// <summary>
        /// Devuelve los paneles adyacentes a una coordenada dada
        /// </summary>
        /// <param name="coordenadas"></param>
        /// <returns></returns>
        public List<Panel> obtenerAdyacentes(Coordenada coordenadas)
        {
            int fila = coordenadas.fila;
            int columna = coordenadas.columna;

            List<Panel> lstPaneles = new List<Panel>();
            if (columna > 1) { lstPaneles.Add(paneles.ubicado(fila, columna - 1)); } //Oeste

            if (fila > 1) { lstPaneles.Add(paneles.ubicado(fila - 1, columna)); } //Norte

            if (fila < 64) { lstPaneles.Add(paneles.ubicado(fila + 1, columna)); } //Sur

            if (columna < 32) { lstPaneles.Add(paneles.ubicado(fila, columna + 1)); } //Este

            return lstPaneles;
        }

    }
}
