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
        public delegate void DelActualizarActividad(string nombre);
        public DelActualizarActividad delActualizarActividad;
       
        /// <summary>
        /// carga las comboBoxes
        /// </summary>
        public NuevoCliente(DelActualizarActividad delActualizarActividad)
        {
            InitializeComponent();
            this.delActualizarActividad = delActualizarActividad;
        }


        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            txbNombre.Clear();
            txbApellido.Clear();
            txbDni.Clear();
            txbTelefono.Clear();
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
        /// caso contrario lanza una excepcion. si los datos son correctos, escribe al nuevo
        /// cliente en la base de datos, crea un ticket de compra y llama 
        /// al delegado para actualizar la label del form MostarClientes
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
                Membresia membresia = null;                
                nombre = txbNombre.Text;
                apellido = txbApellido.Text;
                int.TryParse(txbDni.Text, out dni);
                int.TryParse(txbTelefono.Text, out telefono);
                int cantidadLetrasN = nombre.ContarLetras();
                int cantidadLetrasA = apellido.ContarLetras();

                if (cmbMembresia.SelectedItem != null)
                {
                    membresia = Membresia.MembresiaCorrespondiente(cmbMembresia.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Error al detectar la membresia, revise el campo", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (cmbGenero.SelectedItem != null)
                {
                    genero = (EGenero)cmbGenero.SelectedItem;
                }
                else
                {
                    genero = 0;
                    MessageBox.Show("Error al detectar el genero, revise el campo", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                try
                {
                    if (!Cliente.ComprobarExistencia(dni))
                    {
                        if (!string.IsNullOrEmpty(nombre) && cantidadLetrasN <25 && !string.IsNullOrEmpty(apellido)
                            && cantidadLetrasA <25 && dni > 1000000 && dni < 99999999 && membresia != null)
                        {
                            ClienteAccesoDatos.Guardar(nombre, apellido, genero, dni, telefono, membresia.ToString(), true);
                            nuevoCliente = new Cliente(nombre, apellido, genero, dni, telefono, membresia.ToString(), true);
                            Archivo archivoTicket = new Archivo();
                            archivoTicket.EscribirArchivo(nuevoCliente.ToString(), $"Nuevo-Ticket.{nuevoCliente.Dni}");
                            if (delActualizarActividad != null)
                            {
                                this.delActualizarActividad(nombre);
                            }
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Imposible agregar cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
