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
        }
        
        public void RegistrarEgresado()
        {
            objEgresado.registrarEgresado(datosEgresado());
        }

        public void ModificarEgresado()
        {

        }

        public void ConsultarEgreado()
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
    }
}
