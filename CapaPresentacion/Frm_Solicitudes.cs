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
        solicitudCN objSolicitud = new solicitudCN();
        int idConsultaEgresado;

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
            dataGridView1.DataSource = objSolicitud.getEgresado();
        }

        //OPERACIONES CON EL DATAGRIDVIEW
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idConsultaEgresado = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            dataGridView2.DataSource = objSolicitud.listarSolicitudPorEgresado(idConsultaEgresado);

            tabControl1.SelectTab(tabPage3);
        }
    }
}
