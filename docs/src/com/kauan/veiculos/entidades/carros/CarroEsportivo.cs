using System;
using Aula5_POO.com.aluno.veiculos.entidades.servicos;

namespace Aula5_POO.com.kauan.veiculos.entidades.carros
{
    public class CarroEsportivo : Carro
    {
        public int velocidadeMaxima;
        public int nPortas;

        public CarroEsportivo(string marca, string modelo, string placa, string renavam, int velocidadeMaxima, int nPortas)
            : base(marca, modelo, placa, renavam)
        {
            this.velocidadeMaxima = velocidadeMaxima;
            this.nPortas = nPortas;
        }

        public override void mostrar()
        {
            Console.WriteLine($"Carro Esportivo: {marca} {modelo}, Placa: {placa}, Renavam: {renavam}, Velocidade Máxima: {velocidadeMaxima} km/h, Número de Portas: {nPortas}");
        }

        public override void seguroParticular()
        {
            Console.WriteLine("Seguro particular para carro esportivo.");
        }
    }
}
