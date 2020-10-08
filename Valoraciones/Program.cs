using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroValoraciones valoraciones = new LibroValoraciones();

            valoraciones.AgregarValoraciones(5);
            valoraciones.AgregarValoraciones(3);
            valoraciones.AgregarValoraciones(1.5f);

            Console.WriteLine("Promedio de valoraciones: "+valoraciones.getPromedio());
            Console.WriteLine("Valoracion Minima: " + valoraciones.getMinValoracion());
            Console.WriteLine("Valoracion Maxima: " + valoraciones.getMaxValoracion());
            Console.ReadLine();
        }
    }
}
