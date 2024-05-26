using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaYOcultamiento
{
    public class CambioDeAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite.");
        }

        public override double CalcularCosto()  
        { 
            return 50.0;                //costo del cambio de aceite 
        }

        public override int CalcularTiempoTTServicio()
        {
            return 2;
        }
    }
}
