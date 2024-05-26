using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaYOcultamiento
{
    public abstract class Servicio
    {
        public abstract void RealizarServicio();
        public abstract double CalcularCosto();

        public abstract int CalcularTiempoTTServicio();
    }
}
