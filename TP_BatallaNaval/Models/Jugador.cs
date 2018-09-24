using System;
using System.Collections.Generic;
using System.Linq;
using TP_BatallaNaval.Models.Barcos;
using TP_BatallaNaval.Models.Tableros;
using TP_BatallaNaval.Models;
using System.Text;
using System.Threading.Tasks;
namespace TP_BatallaNaval.Models
{

    public class Jugador
    {
        public string name { get; set; }
        public Tablero Tablero { get; set; }
        public TableroDisparo TableroDisparo { get; set; }
        public List<Barco> Barcos { get; set; }
        public bool haPerdido
        {
            get
            {
                return Barcos.All(x => x.estaHundido);
            }
        }
        public Jugador(string name)
        {
            this.name = name;
            Barcos = new List<Barco>()
            {
                new Corbeta(),
                new Destructor(),
                new Fragata(),
                new Portaaviones(),
                new Submarino()

            };
            Tablero = new Tablero();
            TableroDisparo = new TableroDisparo();
        }
        public void ubicarBarcos()

        {
            //Esta creacion del numero random es un forma muy util encontrada en StackOverflow
            Random aleatorio = new Random(Guid.NewGuid().GetHashCode());
            foreach (var barco in Barcos)
            {
                //Se selecciona una columna/fila aleatoria, y se selecciona una orientacion aleatoria
                //Si ninguno de esos paneles estan ocupados, se situa el barco
                //Se hace eso para cada tipo de barco

                bool estaAbierto = true;
                while (estaAbierto)
                {
                    var columnaInicio = aleatorio.Next(1, 33);
                    var filaInicio = aleatorio.Next(1, 65);
                    int filaFinal = filaInicio, columnaFinal = columnaInicio;
                    var orientacion = aleatorio.Next(1, 2049) % 2; //0 para que sea horizontal

                    List<int> NumerosPaneles = new List<int>();
                    if (orientacion == 0)
                    {
                        for (int i = 1; i < barco.largo; i++)
                        {
                            filaFinal++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < barco.largo; i++)
                        {
                            columnaFinal++;
                        }
                    }
                    //no se puede ubicar barcos afuera de los limites del tablero
                    if (filaFinal > 64 || columnaFinal > 32)
                    {
                        estaAbierto = true;
                        continue;
                    }
                    var panelesAfectados = Tablero.paneles.Rango(filaInicio, columnaInicio, filaFinal, columnaFinal);
                    if (panelesAfectados.Any(x => x.estaOcupado))
                    {
                        estaAbierto = true;
                        continue;
                    }
                    foreach (var panel in panelesAfectados)
                    {
                        panel.tipoPanel = barco.tipoPanel;
                    }
                    estaAbierto = false;

                }

            }
        }

        public Coordenada Disparo()
        {
            //Si no hay hits en el tablero, no tenemos disparos, por lo tanto debemos disparar primero
            var hitAdyacentes = TableroDisparo.obtenerAdyacentesDisparados();
            Coordenada coords;
            if (hitAdyacentes.Any())
            {
                coords = DisparoBuscado();
            }
            else
            {
                coords = DisparoAleatorio();
            }
            return coords;

        }

        public Coordenada DisparoAleatorio()
        {
            var panelesDisponibles = TableroDisparo.casillasDisponibles();
            Random aleatorio = new Random(Guid.NewGuid().GetHashCode());
            var panelID = aleatorio.Next(panelesDisponibles.Count);
            return panelesDisponibles[panelID];
        }

        public Coordenada DisparoBuscado()
        {
            Random aleatorio = new Random(Guid.NewGuid().GetHashCode());
            var hitAdyacentes = TableroDisparo.obtenerAdyacentesDisparados();
            var adyacenteID = aleatorio.Next(hitAdyacentes.Count);
            return hitAdyacentes[adyacenteID];
        }

        public void procesarResultado(Coordenada coordenada, ResultadoDisparo resultado)
        {
            var panel = TableroDisparo.paneles.ubicado(coordenada.fila, coordenada.columna);
            switch(resultado)
            {
                case Models.ResultadoDisparo.Hit:
                    panel.tipoPanel = TipoPanel.Hit;
                    break;
                default:
                    panel.tipoPanel = TipoPanel.Miss;
                    break;
            }


        }
        public ResultadoDisparo procesarDisparo(Coordenada coordenadas)
        {
            var panel = Tablero.paneles.ubicado(coordenadas.fila, coordenadas.columna);
            if (!panel.estaOcupado)
            {
                return ResultadoDisparo.Miss;
            }
            var barco = Barcos.First(x => x.tipoPanel == panel.tipoPanel);
            barco.hits++;
            return ResultadoDisparo.Hit;
        }
    }

}
    


