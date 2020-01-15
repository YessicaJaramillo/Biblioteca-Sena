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
    public partial class FrmConsultaLibros : Form
    {
        Dato dato = new Dato();
        private static FrmConsultaLibros consulta;
        private FrmConsultaLibros()
        {
            InitializeComponent();
        }

        public static FrmConsultaLibros mostrarC()
        {
            if (consulta == null)
            {
                consulta = new FrmConsultaLibros();
            }
            return consulta;
        }

        private void btnExhibir_Click(object sender, EventArgs e)
        {
            this.dgvDatosL.DataSource = dato.mostrarInicial(txtMostrar.Text.Trim().ToString()).Tables[0].DefaultView;
        }

        private void cboEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvDatosL.DataSource = dato.combo(cbNombre.Text.ToString()).Tables[0].DefaultView;
            
        }

        private void FrmConsultaLibros_Load(object sender, EventArgs e)
        {
            dato.mostrarNombre(ref cbNombre);
            this.dgvDatosL.DataSource = dato.mostrarLibros().Tables[0].DefaultView;
            this.dgvDatosL.Columns[0].HeaderText = "Código del libro";
            this.dgvDatosL.Columns[1].HeaderText = "Nombre del libro";
            this.dgvDatosL.Columns[2].HeaderText = "Código del editorial";

            lstLista.Items.Add("CodLibro");
            lstLista.Items.Add("NomLibro");
            lstLista.Items.Add("CodEdit");
            
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            this.dgvDatosL.DataSource = dato.ascendente(lstLista.Text.ToString()).Tables[0].DefaultView;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.dgvDatosL.DataSource = dato.mostrarLibros().Tables[0].DefaultView;

        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            this.dgvDatosL.DataSource = dato.descendente(lstLista.Text.ToString()).Tables[0].DefaultView;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
