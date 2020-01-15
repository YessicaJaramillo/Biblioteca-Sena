using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSena
{
    public partial class FrmBiblioteca : Form
    {
        FrmLibros libros;
        FrmEditorial editorial;
        FrmConsultaLibros consulta;
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {

        }

        private void tsmArchivo_Click(object sender, EventArgs e)
        {

        }

        private void tsbLibro_Click(object sender, EventArgs e)
        {

            libros = FrmLibros.mostrarF();
            libros.MdiParent = this;
            libros.Show();
        }

        private void tsbEditorial_Click(object sender, EventArgs e)
        {
            editorial = FrmEditorial.mostrarE();
            editorial.MdiParent = this;
            editorial.Show();
        }

        private void tsbbiblioteca_Click(object sender, EventArgs e)
        {
            consulta = FrmConsultaLibros.mostrarC();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void tsmLibro_Click(object sender, EventArgs e)
        {
            libros = FrmLibros.mostrarF();
            libros.MdiParent = this;
            libros.Show();
        }

        private void tsmEditorial_Click(object sender, EventArgs e)
        {
            editorial = FrmEditorial.mostrarE();
            editorial.MdiParent = this;
            editorial.Show();
        }

        private void tsmBiblioteca_Click(object sender, EventArgs e)
        {
            consulta = FrmConsultaLibros.mostrarC();
            consulta.MdiParent = this;
            consulta.Show();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
