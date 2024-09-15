using System;
using Aula5_POO.com.kauan.veiculos.entidades;
using Aula5_POO.com.aluno.veiculos.entidades.servicos;

namespace Aula5_POO.com.kauan.veiculos.entidades.carros
{
    public class Carro : Veiculo, Seguro
    {
        public string placa;
        public string renavam;

        public Carro(string marca, string modelo, string placa, string renavam) : base(marca, modelo)
        {
            this.placa = placa;
            this.renavam = renavam;
        }

        public override void mostrar()
        {
            Console.WriteLine($"Carro: {marca} {modelo}, Placa: {placa}, Renavam: {renavam}");
        }

        public virtual void seguroParticular()
        {
            Console.WriteLine("Seguro particular para carro.");
        }
    }
}
