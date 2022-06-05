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
    public partial class NuevoCliente : Form
    {
        Cliente nuevoCliente; 

        /// <summary>
        /// carga las comboBoxes
        /// </summary>
        public NuevoCliente()
        {
            InitializeComponent();
            cmbGenero.Items.Add(EGenero.Femenino);
            cmbGenero.Items.Add(EGenero.Masculino);
            cmbGenero.Items.Add(EGenero.NoBinario);

            Base.CargarClientes();
            foreach (Membresia memb in Base.membresias)
            {
                cmbMembresia.Items.Add(memb.Nombre);
            }
        }

        /// <summary>
        /// filtra los datos recibidos por el form y crea a un cliente si estos son correctos,
        /// caso contrario lanza una excepcion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, apellido;
                int dni, telefono;
                EGenero genero;
                Membresia membresia;
                nombre = txbNombre.Text;
                apellido = txbApellido.Text;
                int.TryParse(txbDni.Text, out dni);
                int.TryParse(txbTelefono.Text, out telefono);

                membresia = Membresia.MembresiaCorrespondiente(cmbMembresia.SelectedItem.ToString());
                genero = (EGenero)cmbGenero.SelectedItem;

                try
                {
                    if(Cliente.ComprobarExistencia(dni) == false)
                    {
                        nuevoCliente = Cliente.CrearCliente(nombre, apellido, genero, dni, telefono, membresia, true);
                        if (nuevoCliente != null)
                        {
                            Serializador<Cliente> serializarCliente = new Serializador<Cliente>();
                            Base.clientes.Add(nuevoCliente);
                            Base.SerializarClientes();
                            Archivo archivoTicket = new Archivo();
                            archivoTicket.EscribirArchivo(nuevoCliente.ToString(), $"Nuevo-Ticket.{nuevoCliente.Dni}");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Imposible agregar cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"No se pudo agregar al cliente, revise los campos. Excepcion: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                string mensaje = "No se pudo agregar al cliente, revise los campos";
                MessageBox.Show(mensaje, ex.Message);
            }
            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
