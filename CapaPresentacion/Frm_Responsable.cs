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
    public partial class Frm_Responsable : Form
    {
        responsableCN objResponsable = new responsableCN();
        areaCN objArea = new areaCN();

        public Frm_Responsable()
        {
            InitializeComponent();
        }

        //LLAMADA A LOS METODOS
        private void listarResponsable()
        {
            dgvListadoResp.DataSource = objResponsable.getResponsable();
            cargarComboArea();
        }

        public void registrarEgresado()
        {
            //objEgresado.registrarEgresado(datosEgresado());
            objResponsable.registrarResponsable(datosResponsable());
        }

        public void modificarEgresado()
        {

        }

        public void consultarEgreado()
        {

        }
        //METODO DE CAPTURA DE VALORES
        public responsable datosResponsable()
        {
            responsable resp = new responsable
            {
                nomResponsable = txtNom.Text,
                apePatResponsable = txtApePat.Text,
                apeMatResponsable = txtApeMat.Text,
                cargoResponsable = txtCargo.Text,
                gradoAcaResponsable = txtGrado.Text,
                idArea = int.Parse(cmbArea.SelectedValue.ToString())
            };

            return resp;
        }
        //Metodos auxiliares
        public void cargarComboArea()
        {
            List<area> areas = objArea.getArea();
            //limpiando el combo box
            cmbArea.DataSource = null;
            cmbArea.Items.Clear();

            BindingList<AreaData> comboItems = new BindingList<AreaData>();
            comboItems.Add(new AreaData { Nombre = "Elegir area", Valor = 0 });
            foreach (area area in areas)
            {
                comboItems.Add(new AreaData { Nombre = area.nomArea, Valor = area.idArea });
            }
            cmbArea.DataSource = comboItems;
            cmbArea.DisplayMember = "Nombre";
            cmbArea.ValueMember = "Valor";
        }
        public class AreaData
        {
            public string Nombre { get; set; }
            public int Valor { get; set; }
        }
        //Evento Load
        private void Frm_Responsable_Load(object sender, EventArgs e)
        {
            listarResponsable();
        }
        //Eventos click
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarEgresado();
        }
    }
}
