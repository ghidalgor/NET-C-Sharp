using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploVehiculo
{
    class PalaMecanica:vehiculo
    {
        public void LevantarPala()
        {
            Console.WriteLine("Clase PalaMecanica, Método Levantar Pala");
        }


        public void BajarrPala()
        {
            Console.WriteLine("Clase PalaMecanica, Método Bajar Pala");
        }
    }
}
