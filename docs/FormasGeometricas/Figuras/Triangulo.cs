using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Figuras
{
    internal class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Triangulo(double Base, double Altura, double Lado1, double Lado2)
        {
            this.Base = Base;
            this.Altura = Altura;
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
        }

        public override double CalcularPerimetro()
        {
            return Base + Lado1 + Lado2;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override string Mostrar()
        {
            return $"Triângulo: \nÁrea = {CalcularArea()} \nPerímetro = {CalcularPerimetro()}";
        }
    }
}

