using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_BatallaNaval.Models
{
    public class Partida
    {
        public Jugador Jugador1 { get; set; }
        public Jugador Jugador2 { get; set; }

        public Partida(string nombreJugador1 = "Jugador 1", string nombreJugador2 = "Jugador 2")
        {
            Jugador1 = new Jugador(nombreJugador1);
            Jugador2 = new Jugador(nombreJugador2);

            Jugador1.ubicarBarcos();
            Jugador2.ubicarBarcos();
        }

        /// <summary>
        /// Juega un solo intercambio de disparos
        /// </summary>
        public void jugarRonda()
        {
            var coordenadas = Jugador1.Disparo();
            var resultado = Jugador2.procesarDisparo(coordenadas);
            Jugador1.procesarResultado(coordenadas, resultado);

            if(!Jugador2.haPerdido)
            {
                coordenadas = Jugador2.Disparo();
                resultado = Jugador1.procesarDisparo(coordenadas);
                Jugador2.procesarResultado(coordenadas, resultado);
            }
        }

        /// <summary>
        /// Juega hasta que alguno de los jugadores haya perdido
        /// </summary>
        public void jugarHastaFinal()
        {
            while (!Jugador1.haPerdido && !Jugador2.haPerdido)
            {
                jugarRonda();
            }
        }
    }
}
