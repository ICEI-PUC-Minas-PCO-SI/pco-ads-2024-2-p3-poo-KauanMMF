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
            SuspendLayout();
            // 
            // btnCriarQuadrado
            // 
            btnCriarQuadrado.Location = new Point(92, 98);
            btnCriarQuadrado.Name = "btnCriarQuadrado";
            btnCriarQuadrado.Size = new Size(288, 34);
            btnCriarQuadrado.TabIndex = 1;
            btnCriarQuadrado.Text = "Criar Quadrado";
            btnCriarQuadrado.UseVisualStyleBackColor = true;
            btnCriarQuadrado.Click += btnCriarQuadrado_Click;
            // 
            // btnAbrirArquivo
            // 
            btnAbrirArquivo.Location = new Point(92, 48);
            btnAbrirArquivo.Name = "btnAbrirArquivo";
            btnAbrirArquivo.Size = new Size(605, 34);
            btnAbrirArquivo.TabIndex = 2;
            btnAbrirArquivo.Text = "Abrir Arquivo";
            btnAbrirArquivo.UseVisualStyleBackColor = true;
            btnAbrirArquivo.Click += btnAbrirArquivo_Click;
            // 
            // btnAreaPerimetroQuadrados
            // 
            btnAreaPerimetroQuadrados.Location = new Point(409, 98);
            btnAreaPerimetroQuadrados.Name = "btnAreaPerimetroQuadrados";
            btnAreaPerimetroQuadrados.Size = new Size(288, 34);
            btnAreaPerimetroQuadrados.TabIndex = 3;
            btnAreaPerimetroQuadrados.Text = "Calcular Área e perímetro dos quadrados";
            btnAreaPerimetroQuadrados.UseVisualStyleBackColor = true;
            btnAreaPerimetroQuadrados.Click += btnAreaPerimetroQuadrados_Click;
            // 
            // btnCriarRetangulo
            // 
            btnCriarRetangulo.Location = new Point(92, 138);
            btnCriarRetangulo.Name = "btnCriarRetangulo";
            btnCriarRetangulo.Size = new Size(288, 34);
            btnCriarRetangulo.TabIndex = 4;
            btnCriarRetangulo.Text = "Criar Retângulo";
            btnCriarRetangulo.UseVisualStyleBackColor = true;
            btnCriarRetangulo.Click += btnCriarRetangulo_Click;
            // 
            // btnAreaPerimetroRetangulos
            // 
            btnAreaPerimetroRetangulos.Location = new Point(409, 138);
            btnAreaPerimetroRetangulos.Name = "btnAreaPerimetroRetangulos";
            btnAreaPerimetroRetangulos.Size = new Size(288, 34);
            btnAreaPerimetroRetangulos.TabIndex = 5;
            btnAreaPerimetroRetangulos.Text = "Calcular área e perímetro dos retângulos";
            btnAreaPerimetroRetangulos.UseVisualStyleBackColor = true;
            btnAreaPerimetroRetangulos.Click += btnAreaPerimetroRetangulos_Click;
            // 
            // btnAreaPerimetroTriangulos
            // 
            btnAreaPerimetroTriangulos.Location = new Point(409, 178);
            btnAreaPerimetroTriangulos.Name = "btnAreaPerimetroTriangulos";
            btnAreaPerimetroTriangulos.Size = new Size(288, 34);
            btnAreaPerimetroTriangulos.TabIndex = 7;
            btnAreaPerimetroTriangulos.Text = "Calcular área e perímetro dos triângulos";
            btnAreaPerimetroTriangulos.UseVisualStyleBackColor = true;
            btnAreaPerimetroTriangulos.Click += btnAreaPerimetroTriangulos_Click;
            // 
            // btnCriarTriangulo
            // 
            btnCriarTriangulo.Location = new Point(92, 178);
            btnCriarTriangulo.Name = "btnCriarTriangulo";
            btnCriarTriangulo.Size = new Size(288, 34);
            btnCriarTriangulo.TabIndex = 6;
            btnCriarTriangulo.Text = "Criar Triângulo";
            btnCriarTriangulo.UseVisualStyleBackColor = true;
            btnCriarTriangulo.Click += btnCriarTriangulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
