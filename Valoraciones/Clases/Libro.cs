using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Clases
{
    class Libro
    {
        LibroValoraciones valoraciones;
        string title;
        string autor;

        public Libro(string title,string autor)
        {
            this.title = title;
            this.autor = autor;
        }

    }
}
