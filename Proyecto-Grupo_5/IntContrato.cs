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
    public partial class IntContrato : Form
    {
        public IntContrato()
        {
            InitializeComponent();
            llenarComboboxEmpleado();
            llenarComboboxTipoContrato();
            panelDatosPersonales.Width = 0;
            ListarContrato();

        }

        private void llenarComboboxTipoContrato()
        {
            textidTipoDeContrato.DataSource = logTipoContrato.Instancia.ListarTipoContrato();
            textidTipoDeContrato.DisplayMember = "TipoContrato";
            textidTipoDeContrato.ValueMember = "idTipoContrato";
        }
        private void llenarComboboxEmpleado()
        {
            textidEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
            textidEmpleado.DisplayMember = "idEmpleado";
            textidEmpleado.ValueMember = "idEmpleado";
        }

        public List<entContrato> ListarContrato()
        {
            List<entContrato> listarcontrato = logContrato.Instancia.ListarContrato();
            if (listarcontrato.Count > 0)
            {
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = listarcontrato;
                dgvContratos.DataSource = datosEnlazados;
            }
            return (listarcontrato);
        }
        private void IntContrato_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelDatosPersonales.Width == 251)
            {
                panelDatosPersonales.Width = 0;
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
                panelDatosPersonales.Width = 251;
                textEmpleadoid.Visible = true;
                textEstado.Visible = true;
                textDNI.Visible = true;
                textPrimerNombre.Visible = true;
                textSegundoNombre.Visible = true;
                textPrimerApellido.Visible = true;
                textSegundoApellido.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(textidEmpleado.Text);
            entEmpleado em = logEmpleado.Instancia.BuscarEmpleadoID(idEmpleado);
            if (em != null && (em.Estado == "CONTRATADO" || em.Estado == ""))
            {
                textEmpleadoid.Text = Convert.ToString(em.idEmpleado);
                textPrimerNombre.Text = Convert.ToString(em.PrimerNombre);
                textSegundoNombre.Text = Convert.ToString(em.SegundoNombre);
                textPrimerApellido.Text = Convert.ToString(em.PrimerApellido);
                textSegundoApellido.Text = Convert.ToString(em.SegundoApellido);
                textDNI.Text = Convert.ToString(em.DNI);
                textEstado.Text = Convert.ToString(em.Estado);

            }
            else
            {
                MessageBox.Show("EL EMPLEADO SE ENCUENTRA DESPEDIDO");
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
            int idEmpleado = Convert.ToInt32(textidEmpleado.Text);
            entEmpleado em = logEmpleado.Instancia.BuscarEmpleadoID(idEmpleado);
            if (em != null &&(em.Estado != "CONTRATADO") )
            {
                if ((em.Estado != "DESPEDIDO"))
                {
                    entContrato c = new entContrato();
                    c.EmpleadoID = (entEmpleado)textidEmpleado.SelectedItem;
                    c.TipoContratoID = (entTipoContrato)textidTipoDeContrato.SelectedItem;
                    c.FechaInicio = DateTime.Parse(textFechaInicio.Text);
                    c.FechaFinal = DateTime.Parse(textFechafin.Text);

                    logContrato.Instancia.InsertarContrato(c);

                    em.idEmpleado = Convert.ToInt32(textEmpleadoid.Text);
                    em.Estado = "CONTRATADO";
                    logEmpleado.Instancia.EditaEstadoEmpleado(em);

                    ListarContrato();
                    textEmpleadoid.Text = "";
                    textPrimerApellido.Text = "";
                    textSegundoNombre.Text = "";
                    textPrimerApellido.Text = "";
                    textSegundoApellido.Text = "";
                    textDNI.Text = "";
                    textEstado.Text = "";
                }
                else
                {
                    MessageBox.Show("EL EMPLEADO SE ENCUENTRA DESPEDIDO");
                }
            }
            else
            {
                MessageBox.Show("EL EMPLEADO YA SE ENCUENTRA CONTRATADO");
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
        //    int idEmpleado = Convert.ToInt32(textidEmpleado.Text);
        //    entEmpleado em = logEmpleado.Instancia.BuscarEmpleadoID(idEmpleado);
        //    if (em != null && (em.Estado != ""))
        //    {
        //        if ((em.Estado != "DESPEDIDO"))
        //        {
        //            entContrato c = new entContrato();
        //            c.EmpleadoID = (entEmpleado)textidEmpleado.SelectedItem;
        //            c.TipoContratoID = (entTipoContrato)textidTipoDeContrato.SelectedItem;
        //            c.FechaInicio = DateTime.Parse(textFechaInicio.Text);
        //            c.FechaFinal = DateTime.Parse(textFechafin.Text);

        //            logContrato.Instancia.editarContrato(c);
        //            ListarContrato();
        //            textEmpleadoid.Text = "";
        //            textPrimerApellido.Text = "";
        //            textSegundoNombre.Text = "";
        //            textPrimerApellido.Text = "";
        //            textSegundoApellido.Text = "";
        //            textDNI.Text = "";
        //            textEstado.Text = "";
        //        }
        //        else
        //        {
        //            MessageBox.Show("EL EMPLEADO SE ENCUENTRA DESPEDIDO");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("EL EMPLEADO NO ESTA CONTRATADO");
        //    }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textidTipoDeContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
