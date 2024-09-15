using System;
using Aula5_POO.com.aluno.veiculos.entidades.servicos;

namespace Aula5_POO.com.kauan.veiculos.entidades.motos
{
    public class Moto : Veiculo, Seguro
    {
        public string placa;
        public string renavam;
        public int rodas = 2;

        public Moto(string marca, string modelo, string placa, string renavam) : base(marca, modelo)
        {
            this.placa = placa;
            this.renavam = renavam;
        }

        public override void mostrar()
        {
            Console.WriteLine($"Moto: {marca} {modelo}, Placa: {placa}, Renavam: {renavam}, Rodas: {rodas}");
        }
        public void seguroParticular()
        {
            Console.WriteLine("Seguro particular para moto.");
        }
    }
}
