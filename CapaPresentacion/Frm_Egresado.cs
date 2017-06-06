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
        
        public byte[] foto = null;
        public bool nuevo = true;
        int idConsulta;

        egresadoCN objEgresado = new egresadoCN();
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
            //asignado idEgresado al objeto egresado
            egresado egreConsult = datosEgresado();
            egreConsult.idEgresado = idConsulta;
            objEgresado.modificarEgresado(egreConsult);
        }

        public egresado consultarEgreado(int idEgre)
        {
            return objEgresado.consultarEgresado(idEgre);
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
                MessageBox.Show("Solo se permiten imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //EVENTOS DE BOTONES
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarFoto();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {
                registrarEgresado();
            }
            else
            {
                modificarEgresado();
            }
            
        }

        //rellenar la pestana con datos egresado
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idConsulta = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            egresado egresado = consultarEgreado(idConsulta);
            //rellenando campos
            txtNom.Text = egresado.nomEgresado;
            txtApePat.Text = egresado.apePatEgresado;
            txtApeMat.Text = egresado.apeMatEgresado;
            txtDni.Text = egresado.dniEgresado;
            txtCodMat.Text = egresado.codMatEgresado;
            //egresado.condicionEgresado = "I";
            txtDomi.Text = egresado.domicilioEgresado;
            txtCel.Text = egresado.celEgresado;
            txtEmail.Text = egresado.emailEgresado;
            picBoxFoto.Image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(egresado.fotografiaEgresado));
            //asignando valor al comboBox
            for (int i = 1; i < cmbFac.Items.Count; i++)
            {
                cmbFac.SelectedIndex = i;
                if (cmbFac.SelectedValue.ToString() == egresado.idFacultad)
                {
                    cmbFac.SelectedIndex = i;
                    break;
                }
            }

            tabControl1.SelectTab(tabPage2);
            nuevo = false;
        }
    }
}
