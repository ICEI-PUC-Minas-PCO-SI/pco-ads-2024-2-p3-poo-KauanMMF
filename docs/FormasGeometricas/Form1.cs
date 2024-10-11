using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FormasGeometricas.Figuras;
using static System.Windows.Forms.DataFormats;

namespace FormasGeometricas
{
    public partial class Form1 : Form
    {
        private List<Figura> Figuras = new List<Figura>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\smf19\OneDrive\Documentos\Faculdade Kauan\POO\FormasGeometricas\FormasGeometricas\Figuras\dadosFiguras.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string fileContent = sr.ReadToEnd();
                    MessageBox.Show(fileContent);
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado!");
            }
        }

        // Originalmente, fiz os valores das figuras serem aleatórios, mas consegui fazer esse método funcionar e utilizei no trabalho inteiro //
        //QUADRADO
        private void btnCriarQuadrado_Click(object sender, EventArgs e)
        {
            string inputLado = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor do lado do quadrado:", "Entrada de Dados", "1");

            if (double.TryParse(inputLado, out double lado))
            {
                Quadrado quadrado = new Quadrado(lado);
                Figuras.Add(quadrado);
                SalvarFigura(quadrado);
                MessageBox.Show("Quadrado criado com sucesso!");
            }
            else
            {
                MessageBox.Show("Valor inválido. Por favor, insira um número válido.");
            }
        }

        private void btnAreaPerimetroQuadrados_Click(object sender, EventArgs e)
        {
            foreach (var Figura in Figuras)
            {
                if (Figura is Quadrado quadrado)
                {
                    MessageBox.Show($"Quadrado - Lados: {quadrado.Lados} cm | Área: {quadrado.CalcularArea()} | Perímetro: {quadrado.CalcularPerimetro()}");
                }
            }
        }

        //RETÂNGULO
        private void btnCriarRetangulo_Click(object sender, EventArgs e)
        {
            string inputBase = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor da base do retângulo:", "Entrada de Dados", "1");
            string inputAltura = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor da altura do retângulo:", "Entrada de Dados", "1");

            if (double.TryParse(inputBase, out double BASE) && double.TryParse(inputAltura, out double altura))
            {
                Retangulo retangulo = new Retangulo(BASE, altura);
                Figuras.Add(retangulo);
                SalvarFigura(retangulo);
                MessageBox.Show("Retângulo criado com sucesso!");
            }
            else
            {
                MessageBox.Show("Valor inválido. Por favor, insira números válidos.");
            }
        }
        private void btnAreaPerimetroRetangulos_Click(object sender, EventArgs e)
        {
            foreach (var Figura in Figuras)
            {
                if (Figura is Retangulo retangulo)
                {
                    MessageBox.Show($"Retângulo - Base: {retangulo.Base} | Altura: {retangulo.Altura} | Área: {retangulo.CalcularArea()} | Perímetro: {retangulo.CalcularPerimetro()}");
                }
            }
        }

        // TRIÂNGULO
        private void btnCriarTriangulo_Click(object sender, EventArgs e)
        {
            string inputBase = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor da base do triângulo:", "Entrada de Dados", "1");
            string inputAltura = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor da altura do triângulo:", "Entrada de Dados", "1");
            string inputLado1 = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor do primeiro lado do triângulo:", "Entrada de Dados", "1");
            string inputLado2 = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor do segundo lado do triângulo:", "Entrada de Dados", "1");

            if (double.TryParse(inputBase, out double baseTriangulo) &&
                double.TryParse(inputAltura, out double alturaTriangulo) &&
                double.TryParse(inputLado1, out double lado1) &&
                double.TryParse(inputLado2, out double lado2))
            {
                Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo, lado1, lado2);
                Figuras.Add(triangulo);
                SalvarFigura(triangulo);
                MessageBox.Show("Triângulo criado com sucesso!");
            }
            else
            {
                MessageBox.Show("Valores inválidos. Por favor, insira números válidos.");
            }
        }
        private void btnAreaPerimetroTriangulos_Click(object sender, EventArgs e)
        {
            foreach (var Figura in Figuras)
            {
                if (Figura is Triangulo triangulo)
                {
                    MessageBox.Show($"Triângulo - Base: {triangulo.Base} | Lado 1: {triangulo.Lado1} | Lado 2: {triangulo.Lado2} | Área: {triangulo.CalcularArea()}, Perímetro: {triangulo.CalcularPerimetro()}");
                }
            }
        }

        private void btnApagarFigura_Click(object sender, EventArgs e)
        {
            if (Figuras.Count > 0)
            {
                Figuras.RemoveAt(Figuras.Count - 1);

                string filePath = @"C:\Users\smf19\OneDrive\Documentos\Faculdade Kauan\POO\FormasGeometricas\FormasGeometricas\Figuras\dadosFiguras.txt";
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    foreach (var figura in Figuras)
                    {
                        sw.WriteLine(figura.Mostrar());
                        sw.WriteLine("----------------------------");
                    }
                }

                MessageBox.Show("Última figura apagada com sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhuma figura para apagar.");
            }
        }

        private void SalvarFigura(Figura figura)
        {
            string filePath = @"C:\Users\smf19\OneDrive\Documentos\Faculdade Kauan\POO\FormasGeometricas\FormasGeometricas\Figuras\dadosFiguras.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(figura.Mostrar());
                sw.WriteLine("----------------------------");
                sw.Flush();
            }
        }
    }

}
