using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocNotas
{
    internal class Nota
    {
        public String Titulo { get; set; }
        public String Cuerpo { get; set; }
        public Nota(String titulo, String cuerpo)
        {
            Titulo = titulo;
            Cuerpo = cuerpo;
        }
    }
}
