namespace FormasGeometricas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCriarQuadrado = new Button();
            btnAbrirArquivo = new Button();
            btnAreaPerimetroQuadrados = new Button();
            btnCriarRetangulo = new Button();
            btnAreaPerimetroRetangulos = new Button();
            btnAreaPerimetroTriangulos = new Button();
            btnCriarTriangulo = new Button();
            btnApagarFigura = new Button();
            SuspendLayout();
            // 
            // btnCriarQuadrado
            // 
            btnCriarQuadrado.BackColor = SystemColors.Control;
            btnCriarQuadrado.Location = new Point(78, 91);
            btnCriarQuadrado.Name = "btnCriarQuadrado";
            btnCriarQuadrado.Size = new Size(288, 34);
            btnCriarQuadrado.TabIndex = 1;
            btnCriarQuadrado.Text = "Criar Quadrado";
            btnCriarQuadrado.UseVisualStyleBackColor = false;
            btnCriarQuadrado.Click += btnCriarQuadrado_Click;
            // 
            // btnAbrirArquivo
            // 
            btnAbrirArquivo.BackColor = SystemColors.Control;
            btnAbrirArquivo.Location = new Point(78, 41);
            btnAbrirArquivo.Name = "btnAbrirArquivo";
            btnAbrirArquivo.Size = new Size(605, 34);
            btnAbrirArquivo.TabIndex = 2;
            btnAbrirArquivo.Text = "Abrir Arquivo";
            btnAbrirArquivo.UseVisualStyleBackColor = false;
            btnAbrirArquivo.Click += btnAbrirArquivo_Click;
            // 
            // btnAreaPerimetroQuadrados
            // 
            btnAreaPerimetroQuadrados.BackColor = SystemColors.Control;
            btnAreaPerimetroQuadrados.Location = new Point(395, 91);
            btnAreaPerimetroQuadrados.Name = "btnAreaPerimetroQuadrados";
            btnAreaPerimetroQuadrados.Size = new Size(288, 34);
            btnAreaPerimetroQuadrados.TabIndex = 3;
            btnAreaPerimetroQuadrados.Text = "Calcular Área e perímetro dos quadrados";
            btnAreaPerimetroQuadrados.UseVisualStyleBackColor = false;
            btnAreaPerimetroQuadrados.Click += btnAreaPerimetroQuadrados_Click;
            // 
            // btnCriarRetangulo
            // 
            btnCriarRetangulo.BackColor = SystemColors.Control;
            btnCriarRetangulo.Location = new Point(78, 131);
            btnCriarRetangulo.Name = "btnCriarRetangulo";
            btnCriarRetangulo.Size = new Size(288, 34);
            btnCriarRetangulo.TabIndex = 4;
            btnCriarRetangulo.Text = "Criar Retângulo";
            btnCriarRetangulo.UseVisualStyleBackColor = false;
            btnCriarRetangulo.Click += btnCriarRetangulo_Click;
            // 
            // btnAreaPerimetroRetangulos
            // 
            btnAreaPerimetroRetangulos.BackColor = SystemColors.Control;
            btnAreaPerimetroRetangulos.Location = new Point(395, 131);
            btnAreaPerimetroRetangulos.Name = "btnAreaPerimetroRetangulos";
            btnAreaPerimetroRetangulos.Size = new Size(288, 34);
            btnAreaPerimetroRetangulos.TabIndex = 5;
            btnAreaPerimetroRetangulos.Text = "Calcular área e perímetro dos retângulos";
            btnAreaPerimetroRetangulos.UseVisualStyleBackColor = false;
            btnAreaPerimetroRetangulos.Click += btnAreaPerimetroRetangulos_Click;
            // 
            // btnAreaPerimetroTriangulos
            // 
            btnAreaPerimetroTriangulos.BackColor = SystemColors.Control;
            btnAreaPerimetroTriangulos.Location = new Point(395, 171);
            btnAreaPerimetroTriangulos.Name = "btnAreaPerimetroTriangulos";
            btnAreaPerimetroTriangulos.Size = new Size(288, 34);
            btnAreaPerimetroTriangulos.TabIndex = 7;
            btnAreaPerimetroTriangulos.Text = "Calcular área e perímetro dos triângulos";
            btnAreaPerimetroTriangulos.UseVisualStyleBackColor = false;
            btnAreaPerimetroTriangulos.Click += btnAreaPerimetroTriangulos_Click;
            // 
            // btnCriarTriangulo
            // 
            btnCriarTriangulo.BackColor = SystemColors.Control;
            btnCriarTriangulo.Location = new Point(78, 171);
            btnCriarTriangulo.Name = "btnCriarTriangulo";
            btnCriarTriangulo.Size = new Size(288, 34);
            btnCriarTriangulo.TabIndex = 6;
            btnCriarTriangulo.Text = "Criar Triângulo";
            btnCriarTriangulo.UseVisualStyleBackColor = false;
            btnCriarTriangulo.Click += btnCriarTriangulo_Click;
            // 
            // btnApagarFigura
            // 
            btnApagarFigura.BackColor = SystemColors.Control;
            btnApagarFigura.Location = new Point(78, 211);
            btnApagarFigura.Name = "btnApagarFigura";
            btnApagarFigura.Size = new Size(605, 34);
            btnApagarFigura.TabIndex = 8;
            btnApagarFigura.Text = "Apagar ultíma figura adicionada";
            btnApagarFigura.UseVisualStyleBackColor = false;
            btnApagarFigura.Click += btnApagarFigura_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(770, 450);
            Controls.Add(btnApagarFigura);
            Controls.Add(btnAreaPerimetroTriangulos);
            Controls.Add(btnCriarTriangulo);
            Controls.Add(btnAreaPerimetroRetangulos);
            Controls.Add(btnCriarRetangulo);
            Controls.Add(btnAreaPerimetroQuadrados);
            Controls.Add(btnAbrirArquivo);
            Controls.Add(btnCriarQuadrado);
            Name = "Form1";
            Text = "&";
            ResumeLayout(false);
        }

        #endregion
        private Button btnCriarQuadrado;
        private Button btnAbrirArquivo;
        private Button btnAreaPerimetroQuadrados;
        private Button btnCriarRetangulo;
        private Button btnAreaPerimetroRetangulos;
        private Button btnAreaPerimetroTriangulos;
        private Button btnCriarTriangulo;
        private Button btnApagarFigura;
    }
}
