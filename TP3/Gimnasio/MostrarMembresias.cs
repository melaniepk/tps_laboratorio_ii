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
    public partial class MostrarMembresias : Form
    {
        public MostrarMembresias()
        {
            InitializeComponent();
            DataGridMembresias();
        }
        /// <summary>
        /// actualiza el DataGridView de membresias deserializando el archivo json
        /// </summary>
        public void DataGridMembresias()
        {
            Serializador<List<Membresia>> membSerializar = new Serializador<List<Membresia>>();
            List<Membresia> listaMemb = membSerializar.LeerArchivo("MOCK_DATA.json");
            dgvMembresias.DataSource = listaMemb;
        }
    }
}
