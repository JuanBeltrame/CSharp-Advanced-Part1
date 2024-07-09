namespace _10._1._01_AtrapameWindowsForms
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
            btnKilometro = new Label();
            btnLitros = new Label();
            textKilometros = new TextBox();
            textLitros = new TextBox();
            rtbCalculador = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // btnKilometro
            // 
            btnKilometro.AutoSize = true;
            btnKilometro.Location = new Point(121, 60);
            btnKilometro.Name = "btnKilometro";
            btnKilometro.Size = new Size(160, 41);
            btnKilometro.TabIndex = 0;
            btnKilometro.Text = "Kilometros";
            btnKilometro.Click += label1_Click;
            // 
            // btnLitros
            // 
            btnLitros.AutoSize = true;
            btnLitros.Location = new Point(121, 220);
            btnLitros.Name = "btnLitros";
            btnLitros.Size = new Size(90, 41);
            btnLitros.TabIndex = 1;
            btnLitros.Text = "Litros";
            // 
            // textKilometros
            // 
            textKilometros.Location = new Point(121, 104);
            textKilometros.Name = "textKilometros";
            textKilometros.Size = new Size(250, 47);
            textKilometros.TabIndex = 2;
            // 
            // textLitros
            // 
            textLitros.Location = new Point(121, 264);
            textLitros.Name = "textLitros";
            textLitros.Size = new Size(250, 47);
            textLitros.TabIndex = 3;
            // 
            // rtbCalculador
            // 
            rtbCalculador.Location = new Point(418, 114);
            rtbCalculador.Name = "rtbCalculador";
            rtbCalculador.Size = new Size(321, 334);
            rtbCalculador.TabIndex = 4;
            rtbCalculador.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(121, 390);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(250, 58);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 481);
            Controls.Add(btnCalcular);
            Controls.Add(rtbCalculador);
            Controls.Add(textLitros);
            Controls.Add(textKilometros);
            Controls.Add(btnLitros);
            Controls.Add(btnKilometro);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(821, 569);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btnKilometro;
        private Label btnLitros;
        private TextBox textKilometros;
        private TextBox textLitros;
        private RichTextBox rtbCalculador;
        private Button btnCalcular;
    }
}
