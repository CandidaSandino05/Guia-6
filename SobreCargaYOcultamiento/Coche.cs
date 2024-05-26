using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaYOcultamiento
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            base.RealizarMantenimiento();
            Console.WriteLine("Mantenimiento del coche: Cambio de aceite y revision de frenos.");
        }

        public override double ObtenerCostoMantenimiento()
        {
            base.ObtenerCostoMantenimiento();
            return 150.0;
        }

        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial. ");
        }


    }
}
