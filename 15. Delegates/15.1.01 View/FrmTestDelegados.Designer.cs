namespace _14._1._01_View
{
    partial class FrmTestDelegados
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
            txtNombre = new TextBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(618, 47);
            txtNombre.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(12, 94);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(618, 58);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmTestDelegados
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 177);
            Controls.Add(btnActualizar);
            Controls.Add(txtNombre);
            Name = "FrmTestDelegados";
            Text = "Mostrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnActualizar;
    }
}