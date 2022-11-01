using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Jugadores
    {
        public int DNI { get; set; }

        public string NOMBRE { get; set; }
        public string EQUIPO { get; set; }
        public string TARJETAS { get; set; }

        public int DIASSUSPENCION { get; set; }

        public bool controlarventana { get; set; } = true;

        
    }
}
