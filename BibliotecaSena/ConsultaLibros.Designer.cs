namespace BibliotecaSena
{
    partial class FrmConsultaLibros
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
            this.dgvDatosL = new System.Windows.Forms.DataGridView();
            this.gbFdos = new System.Windows.Forms.GroupBox();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnExhibir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIInicial = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosL)).BeginInit();
            this.gbFdos.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosL
            // 
            this.dgvDatosL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosL.Location = new System.Drawing.Point(33, 152);
            this.dgvDatosL.Name = "dgvDatosL";
            this.dgvDatosL.Size = new System.Drawing.Size(664, 286);
            this.dgvDatosL.TabIndex = 8;
            // 
            // gbFdos
            // 
            this.gbFdos.BackColor = System.Drawing.Color.PapayaWhip;
            this.gbFdos.Controls.Add(this.btnDesc);
            this.gbFdos.Controls.Add(this.btnAsc);
            this.gbFdos.Controls.Add(this.lstLista);
            this.gbFdos.Location = new System.Drawing.Point(452, 11);
            this.gbFdos.Name = "gbFdos";
            this.gbFdos.Size = new System.Drawing.Size(245, 136);
            this.gbFdos.TabIndex = 7;
            this.gbFdos.TabStop = false;
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(142, 59);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(75, 23);
            this.btnDesc.TabIndex = 6;
            this.btnDesc.Text = "Desc";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.Location = new System.Drawing.Point(142, 19);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(75, 23);
            this.btnAsc.TabIndex = 5;
            this.btnAsc.Text = "Asc";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(6, 19);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(120, 95);
            this.lstLista.TabIndex = 5;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.PapayaWhip;
            this.gbFiltros.Controls.Add(this.txtMostrar);
            this.gbFiltros.Controls.Add(this.cbNombre);
            this.gbFiltros.Controls.Add(this.btnQuitar);
            this.gbFiltros.Controls.Add(this.btnExhibir);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.lbIInicial);
            this.gbFiltros.Location = new System.Drawing.Point(68, 11);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(332, 136);
            this.gbFiltros.TabIndex = 6;
            this.gbFiltros.TabStop = false;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(137, 16);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(100, 20);
            this.txtMostrar.TabIndex = 5;
            // 
            // cbNombre
            // 
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(137, 46);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(121, 21);
            this.cbNombre.TabIndex = 4;
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.cboEditorial_SelectedIndexChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(137, 91);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar ";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnExhibir
            // 
            this.btnExhibir.Location = new System.Drawing.Point(251, 11);
            this.btnExhibir.Name = "btnExhibir";
            this.btnExhibir.Size = new System.Drawing.Size(75, 23);
            this.btnExhibir.TabIndex = 2;
            this.btnExhibir.Text = "exhibir";
            this.btnExhibir.UseVisualStyleBackColor = true;
            this.btnExhibir.Click += new System.EventHandler(this.btnExhibir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editorial:";
            // 
            // lbIInicial
            // 
            this.lbIInicial.AutoSize = true;
            this.lbIInicial.Location = new System.Drawing.Point(18, 16);
            this.lbIInicial.Name = "lbIInicial";
            this.lbIInicial.Size = new System.Drawing.Size(76, 13);
            this.lbIInicial.TabIndex = 0;
            this.lbIInicial.Text = "Inicial del libro:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(703, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 34);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDatosL);
            this.Controls.Add(this.gbFdos);
            this.Controls.Add(this.gbFiltros);
            this.Name = "FrmConsultaLibros";
            this.Text = "ConsultaLibros";
            this.Load += new System.EventHandler(this.FrmConsultaLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosL)).EndInit();
            this.gbFdos.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosL;
        private System.Windows.Forms.GroupBox gbFdos;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnAsc;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnExhibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIInicial;
        private System.Windows.Forms.Button btnSalir;
    }
}