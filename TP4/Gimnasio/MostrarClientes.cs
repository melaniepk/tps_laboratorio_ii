using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Gimnasio
{
    public delegate void DelegadoEliminador(Cliente cliente);
    public partial class MostrarClientes : Form
    {
        public event DelegadoEliminador eliminador;

        /// <summary>
        /// </summary>
        public MostrarClientes()
        {
            InitializeComponent();
            eliminador += desactivarCliente;
            eliminador += NotificarEliminacion;
        }

        /// <summary>
        /// muestra un mensaje en el label Actulizar al agregarse un cliente nuevo
        /// </summary>
        /// <param name="cliente"></param>
        public void ClienteAgregado(string cliente) =>
            lblActualizar.Text = $"Se agregó recientemente al cliente {cliente}";

        /// <summary>
        /// si el usuario esta seguro de eliminar al cliente, llam al evento eliminador, 
        /// en caso contrario cancela la operacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows != null)
            {                 
                Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"Esta seguro de que desea eliminar a: \n{cliente.ToString()} (se cambiará el estado del cliente)", "Adevertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    if(eliminador != null)
                    {
                        eliminador(cliente);
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada","Cancelacion",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
            }
        }

        /// <summary>
        /// cambia el estado del campo EstaActivo del cliente,
        /// lo elimina logicamnete de la base de datos y vuelve a cargar el dgv
        /// </summary>
        /// <param name="cliente"></param>
        public void desactivarCliente(Cliente cliente)
        {
            cliente.EstaActivo = false;
            ClienteAccesoDatos.Eliminar(cliente.Dni);
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ClienteAccesoDatos.LeerClientes();
        }
        /// <summary>
        /// actualiza la label con la info del cliente que se acaba de eliminar
        /// </summary>
        /// <param name="cliente"></param>
        public void NotificarEliminacion(Cliente cliente)
        {
            EliminoCliente($"Se eliminó al cliente {cliente.Nombre} DNI: {cliente.Dni}.");
        }
       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        private void MostrarClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ClienteAccesoDatos.LeerClientes();            
        }

        public void EliminoCliente(string mensaje)
        {
           lblActualizar.Text = mensaje;
        }
        /// <summary>
        /// refresca el dgv (en realidad hace todo mas messy)
        /// </summary>
        public void Refrescar()
        {
            dgvClientes.Update();
            dgvClientes.Refresh();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ClienteAccesoDatos.LeerClientes();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refresh();
            Refrescar();
        }
    }
}
