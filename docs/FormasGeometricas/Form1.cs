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
                MessageBox.Show("Arquivo n�o encontrado!");
            }
        }

        // Originalmente, fiz os valores das figuras serem aleat�rios, mas consegui fazer esse m�todo funcionar e utilizei no trabalho inteiro //
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
                MessageBox.Show("Valor inv�lido. Por favor, insira um n�mero v�lido.");
            }
        }

        private void btnAreaPerimetroQuadrados_Click(object sender, EventArgs e)
        {
            foreach (var Figura in Figuras)
            {
                if (Figura is Quadrado quadrado)
                {
                    MessageBox.Show($"Quadrado - Lados: {quadrado.Lados} cm | �rea: {quadrado.CalcularArea()} | Per�metro: {quadrado.CalcularPerimetro()}");
                }
            }
        }

        //RET�NGULO
        private void btnCriarRetangulo_Click(object sender, EventArgs e)
        {
            string inputBase = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor da base do ret�ngulo:", "Entrada de Dados", "1");
            string inputAltura = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor da altura do ret�ngulo:", "Entrada de Dados", "1");

            if (double.TryParse(inputBase, out double BASE) && double.TryParse(inputAltura, out double altura))
            {
                Retangulo retangulo = new Retangulo(BASE, altura);
                Figuras.Add(retangulo);
                SalvarFigura(retangulo);
                MessageBox.Show("Ret�ngulo criado com sucesso!");
            }
            else
            {
                MessageBox.Show("Valor inv�lido. Por favor, insira n�meros v�lidos.");
            }
        }
        private void btnAreaPerimetroRetangulos_Click(object sender, EventArgs e)
        {
            foreach (var Figura in Figuras)
            {
                if (Figura is Retangulo retangulo)
                {
                    MessageBox.Show($"Ret�ngulo - Base: {retangulo.Base} | Altura: {retangulo.Altura} | �rea: {retangulo.CalcularArea()} | Per�metro: {retangulo.CalcularPerimetro()}");
                }
            }
        }

        // TRI�NGULO
        private void btnCriarTriangulo_Click(object sender, EventArgs e)
        {
            string inputBase = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor da base do tri�ngulo:", "Entrada de Dados", "1");
            string inputAltura = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor da altura do tri�ngulo:", "Entrada de Dados", "1");
            string inputLado1 = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor do primeiro lado do tri�ngulo:", "Entrada de Dados", "1");
            string inputLado2 = Microsoft.VisualBasic.Interaction.InputBox("Informe o valor do segundo lado do tri�ngulo:", "Entrada de Dados", "1");

            if (double.TryParse(inputBase, out double baseTriangulo) &&
                double.TryParse(inputAltura, out double alturaTriangulo) &&
                double.TryParse(inputLado1, out double lado1) &&
                double.TryParse(inputLado2, out double lado2))
            {
                Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo, lado1, lado2);
                Figuras.Add(triangulo);
                SalvarFigura(triangulo);
                MessageBox.Show("Tri�ngulo criado com sucesso!");
            }
            else
            {
                MessageBox.Show("Valores inv�lidos. Por favor, insira n�meros v�lidos.");
            }
        }
        private void btnAreaPerimetroTriangulos_Click(object sender, EventArgs e)
        {
            foreach (var Figura in Figuras)
            {
                if (Figura is Triangulo triangulo)
                {
                    MessageBox.Show($"Tri�ngulo - Base: {triangulo.Base} | Lado 1: {triangulo.Lado1} | Lado 2: {triangulo.Lado2} | �rea: {triangulo.CalcularArea()}, Per�metro: {triangulo.CalcularPerimetro()}");
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

                MessageBox.Show("�ltima figura apagada com sucesso!");
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
