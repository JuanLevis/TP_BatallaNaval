using System;
namespace TP_BatallaNaval.Models.Tableros
{
    public class Juego
    {
         
        public Jugador jugador1 { get; set; }
        public Jugador jugador2 { get; set; }

        public Juego(string nombre1, string nombre2)
        {
            jugador1 = new Jugador(nombre1);
            jugador2 = new Jugador(nombre2);

            jugador1.ubicarBarcos();
            jugador2.ubicarBarcos();
        }
         public void jugarRonda()
        {
            //se le llama ronda a cada intercambio de disparos
            var coordenadas = jugador1.Disparo();
            var resultado = jugador2.procesarDisparo(coordenadas);
            jugador1.procesarResultado(coordenadas,resultado);
            if (!jugador2.haPerdido)//si ya perdio no tiene porque seguir jugando
            {
                coordenadas = jugador2.Disparo();
                resultado = jugador1.procesarDisparo(coordenadas);
                jugador2.procesarResultado(coordenadas,resultado);
            }
        }

        public void jugarHastaElFinal()
        {
            while(!jugador1.haPerdido && !jugador2.haPerdido)
            {
                jugarRonda();
            }
        }
     }
}
        


