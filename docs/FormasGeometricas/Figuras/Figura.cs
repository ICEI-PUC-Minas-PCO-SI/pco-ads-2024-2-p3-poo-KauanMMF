using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Figuras
{
    public abstract class Figura
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();

        public virtual string Mostrar()
        {
            return "Dados da Figura:";
        }
    }
}

