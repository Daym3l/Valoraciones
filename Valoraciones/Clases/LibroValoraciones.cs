using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public class LibroValoraciones
    {
        List<float> valoraciones;
       
        
        public LibroValoraciones()
        {
            this.valoraciones = new List<float>();
         
        }

        public void AgregarValoraciones(float valoracion)
        {
            this.valoraciones.Add(valoracion + 5);
        }

        public string getPromedio()
        {
            float promedio = 0;
            foreach (var valoracion in valoraciones)
            {
                promedio += valoracion;
            }

            promedio = promedio / valoraciones.Count();
            return promedio.ToString();
        }

        public string getMinValoracion()
        {
            float min = 1;
            foreach (var valoracion in valoraciones)
            {
                min = Math.Min(min, valoracion);
            }
            return min.ToString();
        }

        public string getMaxValoracion()
        {
            float max = 0;
            foreach (var valoracion in valoraciones)
            {
                max = Math.Max(max, valoracion);
            }
            return max.ToString();
        }
    }
}
