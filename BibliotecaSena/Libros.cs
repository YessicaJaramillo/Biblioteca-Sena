using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BibliotecaSena
{


    public partial class FrmLibros : Form
    {
        Dato dato = new Dato();
        SqlDataAdapter adaptador = new SqlDataAdapter();
        DataSet data = new DataSet();

        private static FrmLibros libros;
        private FrmLibros()
        {
            InitializeComponent();
        }
        public static FrmLibros mostrarF()
        {
            if (libros == null)
            {
                libros = new FrmLibros();
            }
            return libros;
        }

        private void btnActualizarL_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder buil = new SqlCommandBuilder(adaptador);
            adaptador.Update(data, "Libros");
            MessageBox.Show("La información ha sido actualizada", "Prueba", MessageBoxButtons.OK);
            data.Clear();
            mostrarLibros();

        }

        private void Libros_Load(object sender, EventArgs e)
        {
            mostrarLibros();
        }
        public void mostrarLibros()
        {
            adaptador = dato.Actualizar();
            adaptador.Fill(data, "Libros");
            this.dgvDatosL.DataSource = data.Tables[0].DefaultView;
            this.dgvDatosL.Columns[0].HeaderText = "Código del libro";
            this.dgvDatosL.Columns[1].HeaderText = "Nombre del libro";
            this.dgvDatosL.Columns[2].HeaderText = "Código del editorial";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
