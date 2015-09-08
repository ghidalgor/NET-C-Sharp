using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploVehiculo
{
    class Automovil : vehiculo
    {
        protected int cantidadPuertas;
        public void AbrirPuertas(int puertaNum)
        {
            Console.WriteLine("Clase Automóvil, método Abrir Puerta");
        }

        public void CerrarPuertas(int puertaNum)
        {
            Console.WriteLine("Clase Automóvil, método Cerrar Puerta");
        }

    }
}
