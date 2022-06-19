using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class Gimnasio : Form
    {
        public MostrarClientes frmMostrarClientes;
        public  NuevoCliente frmNuevoCliente;
       
        public Gimnasio()
        {
            InitializeComponent();
            frmMostrarClientes = new MostrarClientes();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmNuevoCliente = new NuevoCliente(frmMostrarClientes.ClienteAgregado);
            frmNuevoCliente.ShowDialog();
        }

        
        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            frmMostrarClientes.ShowDialog();
        }

        /// <summary>
        /// crea una task y la corre 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gimnasio_Load(object sender, EventArgs e)
        {
            Base.CargarClientes();
            Task cambiarColor = new Task(() =>
            {
                CambiarColor(cancelTokenSource.Token);
            });           
            cambiarColor.Start();         
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

        
        CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

        /// <summary>
        /// cambia el color de fondo de todos los botones 
        /// y la imagen de fondo del form principal cada dos segundos
        /// en un loop infinito
        /// </summary>
        /// <param name="ct"></param>
        public void CambiarColor(CancellationToken ct)
        {
            while(true)
            {
                if (!ct.IsCancellationRequested)
                {
                    Thread.Sleep(2000);
                    this.btnNuevoCliente.BackColor = Color.MediumPurple;
                    this.btnVerActividades.BackColor = Color.MediumPurple;
                    this.btnVerClientes.BackColor = Color.MediumPurple;
                    this.btnVerPlanes.BackColor = Color.MediumPurple;
                    this.BackgroundImage = Properties.Resources.gim2;
                    Thread.Sleep(2000);
                    this.btnNuevoCliente.BackColor = Color.IndianRed;
                    this.btnVerActividades.BackColor = Color.IndianRed;
                    this.btnVerClientes.BackColor = Color.IndianRed;
                    this.btnVerPlanes.BackColor = Color.IndianRed;
                    this.BackgroundImage = Properties.Resources.fondo_gim2;
                }
            }          

        }
    }
}
