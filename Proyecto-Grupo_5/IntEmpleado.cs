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
    public partial class IntEmpleado : Form
    {
        Boolean EDITAR = false;
        public IntEmpleado()
        {
            InitializeComponent();

            DateTime fhoy = DateTime.Now;
            textFechaDeNacimiento.Text = fhoy.ToString();
            textFechaRegistro.Text = fhoy.ToString(); 
            textidEmpleado.Enabled = false;
            textEstado.Enabled = false;        
            LLenarComboBoxOcupacion();
            LLenarComboBoxEstadoCivil();
            LLenarComboBoxTurno();
            LLenarComboBoxGenero();
            LLenarComboBoxCargo();
            LLenarComboBoxAseguradora();
            LLenarComboBoxAFP();
            ListarEmpleado();
        }


        private void LLenarComboBoxOcupacion()
        {
            textOcupacion.DataSource = logOcupacion.Instancia.ListarOcupacion();
            textOcupacion.DisplayMember = "Ocupacion";
            textOcupacion.ValueMember = "idOcupacion";
        }
        private void LLenarComboBoxEstadoCivil()
        {

            textEstadoCivil.DataSource = logEstadoCivil.Instancia.ListarEstadoCivil();
            textEstadoCivil.DisplayMember = "EstadoCivil";
            textEstadoCivil.ValueMember = "idEstadoCivil";

        }
        private void LLenarComboBoxTurno()
        {

            textTurno.DataSource = logTurno.Instancia.ListarTurno();
            textTurno.DisplayMember = "Turno";
            textTurno.ValueMember = "idTurno";

        }
        private void LLenarComboBoxGenero()
        {

            textGenero.DataSource = logGenero.Instancia.ListarGenero();
            textGenero.DisplayMember = "Genero";
            textGenero.ValueMember = "idGenero";

        }
        private void LLenarComboBoxCargo()
        {

            textCargo.DataSource = logCargo.Instancia.ListarCargo();
            textCargo.DisplayMember = "Cargo";
            textCargo.ValueMember = "idCargo";

        }
        private void LLenarComboBoxAFP()
        {

            textAFP.DataSource = logAFP.Instancia.ListarAFP();
            textAFP.DisplayMember = "AFP";
            textAFP.ValueMember = "idAFP";

        }
        private void LLenarComboBoxAseguradora()
        {

            textAseguradora.DataSource = logAseguradora.Instancia.ListarAseguradora();
            textAseguradora.DisplayMember = "Aseguradora";
            textAseguradora.ValueMember = "idAseguradora";

        }


        private void IntEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idEmpleado; DataGridViewRow fila = dgwEmpleado.CurrentRow;
            if (fila != null)
            {
                idEmpleado = int.Parse(fila.Cells[0].Value.ToString());
                
                entEmpleado em = logEmpleado.Instancia.BuscarEmpleadoID(idEmpleado);

                textidEmpleado.Text = Convert.ToString(em.idEmpleado);
                textidEmpleado.Enabled = false;
                textPrimerNombre.Text = Convert.ToString(em.PrimerNombre);
                textSegundoNombre.Text = Convert.ToString(em.SegundoNombre);
                textPrimerApellido.Text = Convert.ToString(em.PrimerApellido);
                textSegundoApellido.Text = Convert.ToString(em.SegundoApellido);
                textDni.Text = Convert.ToString(em.DNI);
                //textGenero.SelectedItem =Convert.ToString(em.GeneroID.Genero);  
                //textOcupacion.SelectedItem = Convert.ToString(em.OcupacionID.Ocupacion);
                //textEstadoCivil.SelectedItem = Convert.ToString(em.EstadoCivilID.EstadoCivil);
                //textAFP.SelectedItem = Convert.ToString(em.AFPID.Afp);
                //textAseguradora.SelectedItem = Convert.ToString(em.AseguradoraID.Aseguradora);
                textFechaDeNacimiento.Text = Convert.ToString(em.FechaDeNamiento);
                textEdad.Text = Convert.ToString(em.Edad);
                textDomicilio.Text = Convert.ToString(em.Domicilio);
                textFechaRegistro.Text = Convert.ToString(em.FechaRegistro);
                textRUC.Text = Convert.ToString(em.RUC);
                //textCargo.Text = Convert.ToString(em.CargoID.Cargo);
                textJerarquia.Text = Convert.ToString(em.Jerarquia);
                //textTurno.Text = Convert.ToString(em.TurnoID.Turno);
                textContrasena.Text = Convert.ToString(em.Contraseña);
                textSueldo.Text = Convert.ToString(em.Sueldo);
                textEstado.Text = Convert.ToString(em.Estado);
                textEstado.Enabled = false;
                EDITAR = true;

            }
            else
            {
                MessageBox.Show("Seleccione Usuario.", "cc: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            IntPrincipal principal = new IntPrincipal();
            principal.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            entEmpleado em = new entEmpleado();
            //em.idEmpleado = Convert.ToInt32(dr["EmpleadoID"]);
            em.PrimerNombre = textPrimerNombre.Text.Trim();
            em.SegundoNombre = textSegundoNombre.Text.Trim();
            em.PrimerApellido = textPrimerApellido.Text.Trim();
            em.SegundoApellido = textSegundoApellido.Text.Trim();
            em.DNI = int.Parse(textDni.Text);
            em.GeneroID = (entGenero)textGenero.SelectedItem;
            em.OcupacionID = (entOcupacion)textOcupacion.SelectedItem;
            em.EstadoCivilID = (entEstadoCivil)textEstadoCivil.SelectedItem;
            em.AFPID = (entAFP)textAFP.SelectedItem;
            em.AseguradoraID = (entAseguradora)textAseguradora.SelectedItem;
            em.FechaDeNamiento = DateTime.Parse(textFechaDeNacimiento.Text);
            em.Edad = int.Parse(textEdad.Text);
            em.Domicilio = textDomicilio.Text.Trim();
            em.FechaRegistro = DateTime.Parse(textFechaRegistro.Text);
            em.RUC = int.Parse(textRUC.Text);
            em.CargoID = (entCargo)textCargo.SelectedItem;
            em.Jerarquia = textJerarquia.Text.Trim();
            em.TurnoID = (entTurno)textTurno.SelectedItem;
            em.Contraseña = int.Parse(textContrasena.Text);
            em.Sueldo = float.Parse(textSueldo.Text);
            em.Estado = textEstado.Text.Trim();
            if (EDITAR)
            {
                em.idEmpleado = int.Parse(textidEmpleado.Text);
                logEmpleado.Instancia.EditaEmpleado(em);
            }
            else {
                logEmpleado.Instancia.InsertarEmpleado(em);
            }
            ListarEmpleado();

            textPrimerApellido.Text = "";
            textSegundoNombre.Text="";
            textPrimerApellido.Text="";
            textSegundoApellido.Text="";
            textDni.Text="";
            textEdad.Text="";
            textDomicilio.Text="";
            textRUC.Text="";
            textJerarquia.Text="";
            textContrasena.Text="";
            textSueldo.Text="";
            textEstado.Text = "";

        }
        public List<entEmpleado> ListarEmpleado()
        {
            List<entEmpleado> listarempleado = logEmpleado.Instancia.ListarEmpleado();
            if (listarempleado.Count > 0)
            {
                BindingSource datosEnlazados = new BindingSource();
                datosEnlazados.DataSource = listarempleado;
                dgwEmpleado.DataSource = datosEnlazados;
            }
            return (listarempleado);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textAFP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
