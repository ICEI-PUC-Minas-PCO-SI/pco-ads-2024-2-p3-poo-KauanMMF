using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Figuras
{
    internal class Retangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (Base * Altura);
        }
        public override string Mostrar()
        {
            return $"Retângulo: \nÁrea = {CalcularArea()} \nPerímetro = {CalcularPerimetro()}";
        }
    }
}
