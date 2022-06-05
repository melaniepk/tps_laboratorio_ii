using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class Gimnasio : Form
    {
        public Gimnasio()
        {
            InitializeComponent();
            btnVerClientes.Enabled = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente frmNuevoCliente = new NuevoCliente();
            DialogResult resultado = frmNuevoCliente.ShowDialog();
            btnVerClientes.Enabled = true;               
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes frmMostrarClientes = new MostrarClientes();
            DialogResult  resultado = frmMostrarClientes.ShowDialog();
        }

        private void Gimnasio_Load(object sender, EventArgs e)
        {
            Base.CargarClientes();
        }


        private void btnVerPlanes_Click(object sender, EventArgs e)
        {
            MostrarMembresias frmMostarMem = new MostrarMembresias();
            frmMostarMem.ShowDialog();
        }

        private void btnVerActividades_Click(object sender, EventArgs e)
        {
            MostrarActividades frmAct = new MostrarActividades();
            frmAct.ShowDialog();
        }
    }
}
