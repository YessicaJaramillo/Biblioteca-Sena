namespace BibliotecaSena
{
    partial class FrmLibros
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
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnActualizarL = new System.Windows.Forms.Button();
            this.dgvDatosL = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(89, 93);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(228, 20);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Actualizar informacion de libros";
            // 
            // btnActualizarL
            // 
            this.btnActualizarL.Location = new System.Drawing.Point(345, 85);
            this.btnActualizarL.Name = "btnActualizarL";
            this.btnActualizarL.Size = new System.Drawing.Size(202, 38);
            this.btnActualizarL.TabIndex = 4;
            this.btnActualizarL.Text = "Actualizar datos";
            this.btnActualizarL.UseVisualStyleBackColor = true;
            this.btnActualizarL.Click += new System.EventHandler(this.btnActualizarL_Click);
            // 
            // dgvDatosL
            // 
            this.dgvDatosL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosL.Location = new System.Drawing.Point(61, 137);
            this.dgvDatosL.Name = "dgvDatosL";
            this.dgvDatosL.Size = new System.Drawing.Size(678, 235);
            this.dgvDatosL.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(620, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 34);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Biblioteca de libros";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(762, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 449);
            this.textBox1.TabIndex = 8;
            // 
            // FrmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnActualizarL);
            this.Controls.Add(this.dgvDatosL);
            this.Name = "FrmLibros";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.Libros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnActualizarL;
        private System.Windows.Forms.DataGridView dgvDatosL;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}