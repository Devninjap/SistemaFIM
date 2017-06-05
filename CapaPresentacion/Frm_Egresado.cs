using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Frm_Egresado : Form
    {
        egresadoCN obj = new egresadoCN();
        public Frm_Egresado()
        {
            InitializeComponent();
        }

        private void Frm_Egresado_Load(object sender, EventArgs e)
        {
           ListarEgresado();
        }

        //LLAMADA A LOS METODOS
        private void ListarEgresado()
        {
            dataGridView1.DataSource = obj.GetEgresado();
        }
        
        public void RegistrarEgresado()
        {

        }

        public void ModificarEgresado()
        {

        }

        public void ConsultarEgreado()
        {

        }
    }
}
