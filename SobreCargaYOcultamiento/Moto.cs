using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaYOcultamiento
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            base.RealizarMantenimiento();
            Console.WriteLine("Mantenimiento de la moto: Lubricacion de cadena y Revision de neumaticos");
        }

        public override double ObtenerCostoMantenimiento()
        {
            base.ObtenerCostoMantenimiento();
            return 100.0;
        }

        
    }
}
