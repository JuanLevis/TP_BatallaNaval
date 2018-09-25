using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_BatallaNaval.Models;

namespace TP_BatallaNaval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void menu_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_jugar_automatico_Click(object sender, EventArgs e)
        {
            ganador_automatico.Text = "";
            ganados_jugador1.Text = "";
            ganados_jugador2.Text = "";

            turnControls(panel_automatico, false);
            int victorias_j1 = 0, victorias_j2 = 0;

            int numJuegos = int.Parse(txt_automatico.Text);

            for (int i = 0; i < numJuegos; i++)
            {
                Partida partida = new Partida(txt_nombre_jugador1.Text, txt_nombre_jugador2.Text);
                partida.jugarHastaFinal();
                if (partida.Jugador1.haPerdido)
                {
                    victorias_j2++;
                }
                else
                {
                    victorias_j1++;
                }
            }
            turnControls(panel_automatico, true);
            if (victorias_j1 > victorias_j2)
            {
                ganador_automatico.Text = "El ganador es Jugador 1 (" + txt_nombre_jugador1.Text + ")";
            }
            else
            {
                if(victorias_j1 < victorias_j2)
                {
                    
                    ganador_automatico.Text = "El ganador es Jugador 2 (" + txt_nombre_jugador2.Text + ")";
                }
                else
	            {
                    ganador_automatico.Text = " La partida resulto en empate";
                }
                
            }
            
            ganados_jugador1.Text = "Victorias de Jugador 1 (" + txt_nombre_jugador1.Text + "): " + victorias_j1;
            ganados_jugador2.Text = "Victorias de Jugador 2 (" + txt_nombre_jugador2.Text + "): " + victorias_j2;
            
        }

        /// <summary>
        /// Activa (true) y desactiva (false) los controles del panel parametro
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="param"></param>
        private void turnControls(Panel panel, bool param)
        {
            if(!param)
            {
                foreach (Control control in panel.Controls)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                foreach (Control control in panel.Controls)
                {
                    control.Enabled = true;
                }
            }
            
        }
    }
}
