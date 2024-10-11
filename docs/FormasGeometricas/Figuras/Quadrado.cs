using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Figuras
{
    internal class Quadrado : Figura
    {
        public double Lados { get; set; } //Os lados de um quadrado são sempre iguais

        public Quadrado(double lados) {
            Lados = lados;
        }
        public override double CalcularArea()
        {
            return Lados * Lados;
        }
        public override double CalcularPerimetro()
        {
            return 4 * Lados;
        }
        public override string Mostrar()
        {
            return $"Quadrado: \nÁrea = {CalcularArea()} \nPerímetro = {CalcularPerimetro()}";
        }
    }
}
