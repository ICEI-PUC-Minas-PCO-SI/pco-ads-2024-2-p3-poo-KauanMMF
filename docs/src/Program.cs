using System;
using System.Collections.Generic;
using Aula5_POO.com.kauan.veiculos.entidades.carros;
using Aula5_POO.com.kauan.veiculos.entidades.motos;
using Aula5_POO.com.kauan.veiculos.entidades;
using Aula5_POO.com.aluno.veiculos.entidades.servicos;

namespace Aula5_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> listaVeiculos = new List<Veiculo>();

            Carro carro1 = new Carro("Honda", "Civic", "XYZ-1234", "12345678900");
            Carro carro2 = new Carro("Toyota", "Corolla", "ABC-5678", "09876543210");
            listaVeiculos.Add(carro1);
            listaVeiculos.Add(carro2);

            CarroEsportivo carroEsportivo1 = new CarroEsportivo("Ferrari", "F8", "DEF-9876", "11223344556", 340, 2);
            CarroEsportivo carroEsportivo2 = new CarroEsportivo("Lamborghini", "Huracán", "GHI-5432", "22334455667", 350, 2);
            listaVeiculos.Add(carroEsportivo1);
            listaVeiculos.Add(carroEsportivo2);

            Moto moto1 = new Moto("Yamaha", "MT-07", "JKL-1234", "33445566778");
            Moto moto2 = new Moto("Honda", "CBR 600RR", "MNO-5678", "44556677889");
            listaVeiculos.Add(moto1);
            listaVeiculos.Add(moto2);

            foreach (Veiculo veiculo in listaVeiculos)
            {
                veiculo.mostrar();

                if (veiculo is Seguro)
                {
                    ((Seguro)veiculo).seguroParticular();
                }
                Console.WriteLine();
            }
        }
    }
}
