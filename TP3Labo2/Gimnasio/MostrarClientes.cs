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
    public partial class MostrarClientes : Form
    {
        /// <summary>
        /// muestra los datos deseralizados de la lista de clientes en el dataGridView
        /// </summary>
        public MostrarClientes()
        {
            InitializeComponent();
            Serializador<List<Cliente>> serializadorCliente = new Serializador<List<Cliente>>();

            dgvClientes.DataSource = null;
            if (Base.clientes.Count > 0)
            {
                Base.clientes = serializadorCliente.Leer();
                dgvClientes.DataSource = Base.clientes;
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
        }

        /// <summary>
        /// cambia el estado del cliente de la row en la que esta parado el usuario
        /// de estaActivo = true a estaActivo = false y actualiza el dataGridView una vez confimada la operacion. En caso
        /// de cancelarla no cambia nada 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows != null)
            {
                Cliente cliente = this.dgvClientes.CurrentRow.DataBoundItem as Cliente;

                if (MessageBox.Show($"Esta seguro de que desea eliminar a: \n{cliente.ToString()} (se cambiará el estado del cliente)", "Adevertencia", MessageBoxButtons.YesNo,MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    cliente.EstaActivo = false;
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = Base.clientes;
                    Base.SerializarClientes();

                }
                else
                {
                    MessageBox.Show("Operación cancelada","Cancelacion",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
