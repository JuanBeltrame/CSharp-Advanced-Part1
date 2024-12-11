namespace _14._1._01_View
{
    partial class FrmPrincipal
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
            menu = new MenuStrip();
            altaToolStripMenuItem = new ToolStripMenuItem();
            testDelegadosToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(40, 40);
            menu.Items.AddRange(new ToolStripItem[] { altaToolStripMenuItem, mostrarToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1867, 52);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testDelegadosToolStripMenuItem, alumnosToolStripMenuItem });
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(93, 48);
            altaToolStripMenuItem.Text = "Alta";
            // 
            // testDelegadosToolStripMenuItem
            // 
            testDelegadosToolStripMenuItem.Name = "testDelegadosToolStripMenuItem";
            testDelegadosToolStripMenuItem.Size = new Size(448, 54);
            testDelegadosToolStripMenuItem.Text = "Test Delegados";
            testDelegadosToolStripMenuItem.Click += testDelegadosToolStripMenuItem_Click;
            // 
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(448, 54);
            alumnosToolStripMenuItem.Text = "Alumno";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(145, 48);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1867, 450);
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            Name = "FrmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem testDelegadosToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
    }
}
