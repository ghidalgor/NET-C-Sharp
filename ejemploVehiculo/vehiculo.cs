using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploVehiculo
{
    class vehiculo
    {
        protected int caballosDeFuerza;

        public void Arrancar()
        {
            Console.WriteLine("Clase de vehículo, método Arrancar");
        }

        public void Detener()
        {
            Console.WriteLine("Clase de vehículo, método Detener");
        }

    }
}
