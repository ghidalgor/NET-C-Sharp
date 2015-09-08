using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Source https://www.youtube.com/watch?v=iutCBZSXwC8&list=PLnPcl8Zt45gUjeY2Iedba_HSHjjlUqDbV&index=34

namespace ejemploVehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil miauto = new Automovil();
            PalaMecanica palagobierno = new PalaMecanica();
            miauto.Arrancar();
            miauto.AbrirPuertas(1);

            palagobierno.Detener();
            palagobierno.LevantarPala();
            Console.ReadKey();
        }
    }
}
