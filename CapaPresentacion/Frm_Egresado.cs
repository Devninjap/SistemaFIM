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
        egresadoCN objEgresado = new egresadoCN();
        public byte[] foto = null;


        egresadoCN obj = new egresadoCN();
        facultadCN objFacultad = new facultadCN();

        public Frm_Egresado()
        {
            InitializeComponent();
        }

        private void Frm_Egresado_Load(object sender, EventArgs e)
        {
            listarEgresado();

        }

        //LLAMADA A LOS METODOS
        private void listarEgresado()
        {
            dataGridView1.DataSource = objEgresado.getEgresado();
            cargarComboFacultades();
        }
        
        public void registrarEgresado()
        {
            objEgresado.registrarEgresado(datosEgresado());
        }

        public void modificarEgresado()
        {

        }

        public void consultarEgreado()
        {

        }

        //METODO DE CAPTURA DE VALORES
        public egresado datosEgresado()
        {
            egresado egre = new egresado
            {
                nomEgresado = txtNom.Text,
                apePatEgresado = txtApePat.Text,
                apeMatEgresado = txtApeMat.Text,
                dniEgresado = txtDni.Text,
                codMatEgresado = txtCodMat.Text,
                condicionEgresado = "I",
                domicilioEgresado = txtDomi.Text,
                celEgresado = txtCel.Text,
                emailEgresado = txtEmail.Text,
                fotografiaEgresado = foto,//validar
                idFacultad = cmbFac.SelectedValue.ToString()
            };

            return egre;
        }
        public void cargarFoto()
        {
            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = fileDialog.FileName;
                    picBoxFoto.Image = Image.FromFile(ruta);
                    foto = System.IO.File.ReadAllBytes(ruta);
                }
            }
            catch (Exception)
            {

                throw;
            }
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
