using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargaYOcultamiento
{
    public class Vehiculo
    {

        public virtual void RealizarMantenimiento()
        {
          Console.WriteLine("Realizando mantenimiento general del vehiculo");
        }

        public virtual double ObtenerCostoMantenimiento() 
        {
            return 50.0;
        }

        public void LavarV() 
        {
            Console.WriteLine("Lavando el vehículo.");
        }


    }

}
