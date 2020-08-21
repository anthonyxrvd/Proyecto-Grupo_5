using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;

namespace Proyecto_Grupo_5
{
    public partial class IntDespido : Form
    {
        public IntDespido()
        {
            InitializeComponent();
            LlenarcomboboxEmpleado();
            panelDatosPersonal.Width = 0;
            ListarDespido();
        }
        public List<entDespido> ListarDespido()
        {
            List<entDespido> listardespido = logDespidos.Instancia.ListarDespidos();
            if (listardespido.Count > 0)
            {
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = listardespido;
                dgvDespidos.DataSource = datosEnlazados;
            }
            return (listardespido);
        }
        private void IntDespido_Load(object sender, EventArgs e)
        {

        }

        private void LlenarcomboboxEmpleado()
        {
            textidEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
            textidEmpleado.DisplayMember = "idEmpleado";
            textidEmpleado.ValueMember = "idEmpleado";
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(textidEmpleado.Text);
            entEmpleado em = logEmpleado.Instancia.BuscarEmpleadoID(idEmpleado);
            if(em != null && (em.Estado == "CONTRATADO"))
            {
                textEmpleadoid.Text = Convert.ToString(em.idEmpleado);
                textPrimerNombre.Text = Convert.ToString(em.PrimerNombre);
                textSegundoNombre.Text = Convert.ToString(em.SegundoNombre);
                textPrimerApellido.Text = Convert.ToString(em.PrimerApellido);
                textSegundoApellido.Text = Convert.ToString(em.SegundoApellido);
                textDNI.Text = Convert.ToString(em.DNI);
                textEstado.Text = Convert.ToString(em.Estado);

            }else
            {
                MessageBox.Show("El cliente no se encuentra registrado o contratado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            IntPrincipal principal = new IntPrincipal();
            principal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

                entDespido des = new entDespido();
                des.EmpleadoID = (entEmpleado)textidEmpleado.SelectedItem;
                des.FechaDeDespido = DateTime.Parse(textFecha.Text);
                des.motivo = textMotivo.Text.Trim();
                logDespidos.Instancia.InsertarDespidos(des);
                
                entEmpleado em = new entEmpleado();
                em.idEmpleado = Convert.ToInt32(textEmpleadoid.Text);
                em.Estado = "DESPEDIDO";
                logEmpleado.Instancia.EditaEstadoEmpleado(em);
  
                ListarDespido();
                textEmpleadoid.Text = "";
                textPrimerApellido.Text = "";
                textSegundoNombre.Text = "";
                textPrimerApellido.Text = "";
                textSegundoApellido.Text = "";
                textDNI.Text = "";
                textEstado.Text = "";
           
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(panelDatosPersonal.Width == 251)
            {
                panelDatosPersonal.Width = 0;
                textEmpleadoid.Visible = false;
                textEstado.Visible = false;
                textDNI.Visible = false;
                textPrimerNombre.Visible = false;
                textSegundoNombre.Visible = false;
                textPrimerApellido.Visible = false;
                textSegundoApellido.Visible = false;
            }
            else
            {
                panelDatosPersonal.Width = 251;
                textEmpleadoid.Visible = true;
                textEstado.Visible = true;
                textDNI.Visible = true;
                textPrimerNombre.Visible = true;
                textSegundoNombre.Visible = true;
                textPrimerApellido.Visible = true;
                textSegundoApellido.Visible = true;
            }
        }

        private void textPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDespidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
