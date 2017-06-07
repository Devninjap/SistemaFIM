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
        public bool nuevo = true;
        int idConsulta;

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

        public void registrarResponsable()
        {
            //objEgresado.registrarEgresado(datosEgresado());
            objResponsable.registrarResponsable(datosResponsable());
        }

        public void modificarResponsable()
        {
            //asignado idResponsable al objeto egresado
            Responsable respConsult = datosResponsable();
            respConsult.idResponsable = idConsulta;
            objResponsable.modificarResponsable(respConsult);
        }

        public Responsable consultarResponsable(int idResp)
        {
            return objResponsable.consultarResponsable(idResp);
        }
        //METODO DE CAPTURA DE VALORES
        public Responsable datosResponsable()
        {
            Responsable resp = new Responsable
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
            List<Area> areas = objArea.getArea();
            //limpiando el combo box
            cmbArea.DataSource = null;
            cmbArea.Items.Clear();

            BindingList<AreaData> comboItems = new BindingList<AreaData>();
            comboItems.Add(new AreaData { Nombre = "Elegir area", Valor = 0 });
            foreach (Area area in areas)
            {
                comboItems.Add(new AreaData { Nombre = area.descArea, Valor = area.idArea });
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
            if (nuevo)
            {
                registrarResponsable();
            }
            else
            {
                modificarResponsable();
            }
            
        }

        private void dgvListadoResp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idConsulta = int.Parse(dgvListadoResp.CurrentRow.Cells[0].Value.ToString());
            Responsable responsable = consultarResponsable(idConsulta);
            //rellenando campos
            txtNom.Text = responsable.nomResponsable;
            txtApePat.Text = responsable.apePatResponsable;
            txtApeMat.Text = responsable.apeMatResponsable;
            txtCargo.Text = responsable.cargoResponsable;
            txtGrado.Text = responsable.gradoAcaResponsable;
            //asignando valor al comboBox
            for (int i = 1; i < cmbArea.Items.Count; i++)
            {
                cmbArea.SelectedIndex = i;
                if (cmbArea.SelectedValue.ToString() == responsable.idArea.ToString())
                {
                    cmbArea.SelectedIndex = i;
                    break;
                }
            }

            tabControl1.SelectTab(tabPage2);
            nuevo = false;
        }
    }
}
