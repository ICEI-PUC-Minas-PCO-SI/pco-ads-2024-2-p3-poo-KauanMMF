using System;

namespace Aula5_POO.com.kauan.veiculos.entidades
{
    public class Veiculo
    {
        protected string marca;
        protected string modelo;

        public Veiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public virtual void mostrar()
        {
            Console.WriteLine($"Veículo: {marca} {modelo}");
        }
    }
}
