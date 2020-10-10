using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroValoraciones valoraciones = new LibroValoraciones();
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

            
            valoraciones.AgregarValoraciones(5);
            valoraciones.AgregarValoraciones(3);
            valoraciones.AgregarValoraciones(1.5f);
            speechSynthesizer.Speak("El Promedio de valoraciones: " + valoraciones.getPromedio());
            Console.WriteLine("Promedio de valoraciones: "+valoraciones.getPromedio());
            speechSynthesizer.Speak("La Valoracion Minima es: " + valoraciones.getMinValoracion());
            Console.WriteLine("Valoracion Minima: " + valoraciones.getMinValoracion());
            speechSynthesizer.Speak("La Valoracion Maxima es: " + valoraciones.getMaxValoracion());
            Console.WriteLine("Valoracion Maxima: " + valoraciones.getMaxValoracion());
            Console.ReadLine();
        }
    }
}
