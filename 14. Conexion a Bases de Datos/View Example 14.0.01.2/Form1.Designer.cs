namespace View_Example_14._0._01._2
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
            dtgvPersonas = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dtgvPersonas
            // 
            dtgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPersonas.Location = new Point(62, 75);
            dtgvPersonas.Name = "dtgvPersonas";
            dtgvPersonas.RowHeadersWidth = 102;
            dtgvPersonas.Size = new Size(1365, 614);
            dtgvPersonas.TabIndex = 0;
            dtgvPersonas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(1239, 11);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 754);
            Controls.Add(button1);
            Controls.Add(dtgvPersonas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvPersonas;
        private Button button1;
    }
}
