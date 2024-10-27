namespace _14._1._01_View
{
    partial class FrmMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(12, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(885, 159);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "FRM MOSTRAR";
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 279);
            Controls.Add(lblNombre);
            Name = "FrmMostrar";
            Text = "Mostrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
    }
}