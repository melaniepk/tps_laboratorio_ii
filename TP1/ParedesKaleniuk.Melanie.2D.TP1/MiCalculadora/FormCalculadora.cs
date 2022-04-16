using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiCalculadora;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// en caso de que se hayan ingresado correctamente los dos opernaods, 
        /// llama al metodo operar y muestra el resultado en el label, 
        /// y la operacion completa en la lista. tambien hanilita las copines de convertir a binario o decimal.
        /// si se intenta dividir por 0, no lo permite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.txtNumero1.Text == "" || this.txtNumero2.Text == "")
            {
                string mensaje = "No se ingresaron los valores suficientes para realizar la operacion ";
                string titulo = "Error";
                MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (this.cmbOperator.SelectedIndex == -1)
                {
                    cmbOperator.Text = "+";
                }

                double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperator.Text);
                this.lblResultado.Text = resultado.ToString();
                this.lstOperaciones_SelectedIndexChanged(sender, e);

                if (cmbOperator.Text == "/" && this.txtNumero2.Text == "0" || resultado.Equals(double.MinValue))
                {
                    MessageBox.Show("Error al dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = true;
            }
        }

        /// <summary>
        /// limpia el form y carga la comboBox con las operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            cmbOperator.Items.Add("+");
            cmbOperator.Items.Add("-");
            cmbOperator.Items.Add("*");
            cmbOperator.Items.Add("/");

        }

        /// <summary>
        /// cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        /// <summary>
        /// lanza un messageBox al intentar cerrar la aplicacion 
        /// ofreciendo la opcion de cerrarla o no con un dialogResult
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonCerrar(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¡Seguro que quiere salir?";
            string titulo = "Salir";
            DialogResult resultado = MessageBox.Show(mensaje,titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// convierte el operando recibido a binario llamando al metodo decimalBinario
        /// y escribiendo el resultado en la label y en la lista. 
        /// en caso de no ser posible, lanza un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(lblResultado.Text, out aux))
            {
                Operando resultado = new Operando(lblResultado.Text);
                string numeroBinario = resultado.DecimalBinario(lblResultado.Text);
                if (aux >= 0)
                {
                    lstOperaciones.Items.Add($"{lblResultado.Text}D = {numeroBinario}B");
                }
                lblResultado.Text = numeroBinario;
            }
            else
            {
                string mensaje = "Imposible convetir el numero a binario";
                string titulo = "Error";
                MessageBox.Show(mensaje,titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// /convierte el operando recibido a decimal llamado al metodo BinarioDecimal
        /// y lo muestra en la label de resultado y en la lista.
        /// en caso de no ser posible, lanza un mensaje de error
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            double aux;

            if (double.TryParse(lblResultado.Text, out aux))
            {
                Operando resultado = new Operando(lblResultado.Text);
                string numeroDecimal = resultado.BinarioDecimal(lblResultado.Text);
                if (aux >= 0)
                {
                    lstOperaciones.Items.Add($"{lblResultado.Text}D = {numeroDecimal}B");
                }
                lblResultado.Text = numeroDecimal;
            }
            else
            {
                string mensaje = "Imposible convetir el numero a decimal";
                string titulo = "Error";
                MessageBox.Show(mensaje,titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// limpia el form de todas las operaciones anteriores
        /// </summary>
        public void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperator.Items.Clear();
            lblResultado.ResetText();
            lstOperaciones.Items.Clear();   

        }

        /// <summary>
        /// llama al metodo operar de Calculadora y realiza la operacion entre los operandos, devolviendo 
        /// un double como resultado
        /// </summary>
        /// <param name="numero1">primer numero string recibido por la txtNumero1</param>
        /// <param name="numero2">segundo numero string recibido por la txtNumero2</param>
        /// <param name="operador">operador seleccionado en la comboBox</param>
        /// <returns>resultado</returns>
        public static double Operar(string numero1, string numero2,string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(operador));
        }

        /// <summary>
        /// limpia el form y carga los items del comboBox de operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();

            cmbOperator.Items.Add(" ");
            cmbOperator.Items.Add("+");
            cmbOperator.Items.Add("-");
            cmbOperator.Items.Add("*");
            cmbOperator.Items.Add("/");
        }

        /// <summary>
        /// muestra las operaciones realizadas en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstOperaciones.Items.Add(txtNumero1.Text + " " + 
            cmbOperator.Text + " " + txtNumero2.Text + " = " + this.lblResultado.Text);
        }

        





    }
}
