using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Tutorial Curso C# - 8. Herencia
 * Soruce: https://www.youtube.com/watch?v=HjUP4nnihE0
 */

namespace NScliente
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create object
            clsClientesVentas Cliente;
            Cliente = new clsClientesVentas();

            //To get data
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Hidalgo Ramírez";
            Cliente.Nombres = "Gregory";
            Cliente.RFC = "HRGJ";
            Cliente.Direccion = "En alguna parte del mundo";
            Cliente.Colonia = "La Cueva del Jaguar";
            Cliente.EsCredito = true;

            //Screens
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " " + Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);

            if (Cliente.EsCredito == true)

                Console.WriteLine("El Cliente tiene crédito");
            else
                Console.WriteLine("El Cliente No tiene crédito");

            Console.ReadKey();
        }
    }
}