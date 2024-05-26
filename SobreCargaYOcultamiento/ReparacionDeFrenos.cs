using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaYOcultamiento
{
    public class ReparacionDeFrenos : Servicio 
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparacion de frenos.");
        }

        public override double CalcularCosto()
        {
            return 120.0;   //Costo de la reparacion de frenos 
        }

        public override int CalcularTiempoTTServicio()
        {
            return 4;
        }
    }
}
