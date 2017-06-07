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
<<<<<<< HEAD
        int idConsultaSolicitud;
=======
        int idConsultaEgresado;
>>>>>>> 6b554cc98c693fbbced66219c51124d2b408b193

        public Frm_Solicitudes()
        {
            InitializeComponent();
        }

        private void Frm_Solicitudes_Load(object sender, EventArgs e)
        {
            listarEgresado();
        }
        //LLAMADA A LOS METODOS
        private void listarEgresado()
        {
            dataGridView1.DataSource = objSolicitud.getEgresado();
        }
<<<<<<< HEAD
        private void agregarSol()
        {
            tabControl1.SelectTab(tabPage2);
            groupBoxDatosSol.Enabled = true;
        }
        private void registrarSol()
        {

        }
        //EVENTOS CLICK
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarSol();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objSolicitud.registrarSol(datosSolicitud());
        }
        //METODOS EXTRA
        private Solicitud datosSolicitud()
        {

            Solicitud sol = new Solicitud
            {
                asuntoSolicitud = cmbAsunto.SelectedItem.ToString(),
                numRegSolicitud = int.Parse(txtNumReg.Text),
                fechaRecSolicitud = DateTime.Now,//Testear
                obsSolicitud = txtObs.Text,
                reqSolicitud = "",
                validacionReqSolicitud = false,
                estadoSolicitud = true,
                atencionSolicitud = "SA",
                idReqProc = cmbAsunto.SelectedIndex,
                //idEgresado = idConsultaEgresado,
                idEgresado = 1,
                //idUsuario = Frm_Login2.idUsuarioActual
                idUsuario = 1
            };

            return sol;
=======

        //OPERACIONES CON EL DATAGRIDVIEW
        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idConsultaEgresado = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            dataGridView2.DataSource = objSolicitud.listarSolicitudPorEgresado(idConsultaEgresado);

            tabControl1.SelectTab(tabPage3);
>>>>>>> 6b554cc98c693fbbced66219c51124d2b408b193
        }
    }
}
