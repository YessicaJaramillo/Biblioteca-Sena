namespace BibliotecaSena
{
    partial class FrmBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiblioteca));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditorial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBiblioteca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLibro = new System.Windows.Forms.ToolStripButton();
            this.tsbEditorial = new System.Windows.Forms.ToolStripButton();
            this.tsbbiblioteca = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.tsmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLibro,
            this.tsmEditorial,
            this.tsmBiblioteca});
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmArchivo.Text = "&Archivo";
            this.tsmArchivo.Click += new System.EventHandler(this.tsmArchivo_Click);
            // 
            // tsmLibro
            // 
            this.tsmLibro.Name = "tsmLibro";
            this.tsmLibro.Size = new System.Drawing.Size(154, 22);
            this.tsmLibro.Text = "&Libro Sena";
            this.tsmLibro.Click += new System.EventHandler(this.tsmLibro_Click);
            // 
            // tsmEditorial
            // 
            this.tsmEditorial.Name = "tsmEditorial";
            this.tsmEditorial.Size = new System.Drawing.Size(154, 22);
            this.tsmEditorial.Text = "&Editorial Sena";
            this.tsmEditorial.Click += new System.EventHandler(this.tsmEditorial_Click);
            // 
            // tsmBiblioteca
            // 
            this.tsmBiblioteca.Name = "tsmBiblioteca";
            this.tsmBiblioteca.Size = new System.Drawing.Size(154, 22);
            this.tsmBiblioteca.Text = "&Biblioteca Sena";
            this.tsmBiblioteca.Click += new System.EventHandler(this.tsmBiblioteca_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(41, 20);
            this.tsmSalir.Text = "&Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLibro,
            this.tsbEditorial,
            this.tsbbiblioteca,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLibro
            // 
            this.tsbLibro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLibro.Image = ((System.Drawing.Image)(resources.GetObject("tsbLibro.Image")));
            this.tsbLibro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLibro.Name = "tsbLibro";
            this.tsbLibro.Size = new System.Drawing.Size(23, 22);
            this.tsbLibro.Text = "Libro";
            this.tsbLibro.Click += new System.EventHandler(this.tsbLibro_Click);
            // 
            // tsbEditorial
            // 
            this.tsbEditorial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditorial.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditorial.Image")));
            this.tsbEditorial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditorial.Name = "tsbEditorial";
            this.tsbEditorial.Size = new System.Drawing.Size(23, 22);
            this.tsbEditorial.Text = "Editorial";
            this.tsbEditorial.Click += new System.EventHandler(this.tsbEditorial_Click);
            // 
            // tsbbiblioteca
            // 
            this.tsbbiblioteca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbiblioteca.Image = ((System.Drawing.Image)(resources.GetObject("tsbbiblioteca.Image")));
            this.tsbbiblioteca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbiblioteca.Name = "tsbbiblioteca";
            this.tsbbiblioteca.Size = new System.Drawing.Size(23, 22);
            this.tsbbiblioteca.Text = "Biblioteca";
            this.tsbbiblioteca.Click += new System.EventHandler(this.tsbbiblioteca_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBiblioteca";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBiblioteca_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmLibro;
        private System.Windows.Forms.ToolStripMenuItem tsmEditorial;
        private System.Windows.Forms.ToolStripMenuItem tsmBiblioteca;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLibro;
        private System.Windows.Forms.ToolStripButton tsbEditorial;
        private System.Windows.Forms.ToolStripButton tsbbiblioteca;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}