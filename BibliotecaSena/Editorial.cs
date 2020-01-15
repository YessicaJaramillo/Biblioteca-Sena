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
    public partial class FrmEditorial : Form
    {
        Dato dato = new Dato();
        SqlDataAdapter adaptador = new SqlDataAdapter();
        DataSet data = new DataSet();

        private static FrmEditorial editorial;
        private FrmEditorial()
        {
            InitializeComponent();
        }
        public static FrmEditorial mostrarE()
        {
            if (editorial == null)
            {
                editorial = new FrmEditorial();
            }
            return editorial;
        }

        private void FrmEditorial_Load(object sender, EventArgs e)
        {
            mostrarEditorial();
        }
        public void mostrarEditorial()
        {
            adaptador = dato.ActualizarDatos();
            adaptador.Fill(data, "Editorial");
            this.dgvDatosE.DataSource = data.Tables[0].DefaultView;
            this.dgvDatosE.Columns[0].HeaderText = "Código del editorial";
            this.dgvDatosE.Columns[1].HeaderText = "Nombre del editorial";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adaptador);
            adaptador.Update(data, "Editorial");
            MessageBox.Show("Los datos han sido actualizados", "Prueba", MessageBoxButtons.OK);
            data.Clear();
            mostrarEditorial();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
