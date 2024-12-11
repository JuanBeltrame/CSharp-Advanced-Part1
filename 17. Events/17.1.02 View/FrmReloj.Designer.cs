namespace _16._1._02_View
{
    partial class FrmReloj
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
            btnIniciar = new Button();
            btnDetener = new Button();
            lblHora = new Label();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnIniciar.Location = new Point(1300, 31);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(429, 58);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar reloj";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDetener.Location = new Point(1759, 31);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(429, 58);
            btnDetener.TabIndex = 1;
            btnDetener.Text = "Detener reloj";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(32, 31);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(337, 41);
            lblHora.TabIndex = 2;
            lblHora.Text = "DD/MM/YYYY HH:MI:SS";
            // 
            // richTextBox
            // 
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox.Location = new Point(32, 108);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(2156, 1036);
            richTextBox.TabIndex = 3;
            richTextBox.Text = "";
            // 
            // FrmReloj
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2214, 1172);
            Controls.Add(richTextBox);
            Controls.Add(lblHora);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Name = "FrmReloj";
            Text = "Reloj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnDetener;
        private Label lblHora;
        private RichTextBox richTextBox;
    }
}
