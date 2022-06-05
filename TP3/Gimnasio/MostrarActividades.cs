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
    public partial class MostrarActividades : Form
    {
        public MostrarActividades()
        {
            InitializeComponent();
            DataGridActividades();
        }

        /// <summary>
        /// actualiza el dataGridView de actividades a partir de la lectura del archivo json
        /// </summary>
        public void DataGridActividades()
        {
            Serializador<List<Actividad>> actSerializar = new Serializador<List<Actividad>>();
            List<Actividad> listaActividades = actSerializar.LeerArchivo("MOCK_DATA_ACT.json");
            dgvActividades.DataSource = listaActividades;
        }
    }
}
