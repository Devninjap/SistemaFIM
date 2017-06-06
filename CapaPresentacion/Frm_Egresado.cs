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
        facultadCN objFacultad = new facultadCN();
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
        //Metodos auxiliares
        private void cargarComboFacultades()
        {
            List<facultad> facultades = objFacultad.getFacultad();
            //limpiando el combo box
            cmbFac.DataSource = null;
            cmbFac.Items.Clear();

            BindingList<FacultadData> comboItems = new BindingList<FacultadData>();
            comboItems.Add(new FacultadData { Nombre = "Elegir facultad", Valor = null });
            foreach (facultad fac in facultades)
            {
                comboItems.Add(new FacultadData { Nombre = fac.nomFacultad, Valor = fac.idFacultad });
            }
            cmbFac.DataSource = comboItems;
            cmbFac.DisplayMember = "Nombre";
            cmbFac.ValueMember = "Valor";
        }
        //Clase para la carga de datos en el combo box Facultades
        public class FacultadData
        {
            public string Nombre { get; set; }
            public string Valor { get; set; }
        }
    }
}
