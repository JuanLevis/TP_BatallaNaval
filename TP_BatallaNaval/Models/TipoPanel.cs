using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_BatallaNaval.Models
{
    public enum TipoPanel
    {
        [Description("O")]
        Vacio,

        [Description("X")]
        Hit,

        [Description("M")]
        Miss,

        [Description("B")]
        Barco   
    }

    public enum ResultadoDisparo
    {
        Hit, Miss
    }
}
