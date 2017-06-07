using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Frm_Solicitudes : Form
    {
        solicitudCN objEgresado = new solicitudCN(); 
        public Frm_Solicitudes()
        {
            InitializeComponent();
        }

        private void Frm_Solicitudes_Load(object sender, EventArgs e)
        {
            listarEgresado();
        }

        private void listarEgresado()
        {
            dataGridView1.DataSource = objEgresado.getEgresado();
        }
    }
}
