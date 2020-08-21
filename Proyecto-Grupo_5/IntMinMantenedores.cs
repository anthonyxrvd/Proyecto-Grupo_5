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
    public partial class IntMinMantenedores : Form
    {
        public IntMinMantenedores()
        {
            InitializeComponent();
            textidEstadoCivil.Enabled = false;
            textidGenero.Enabled = false;
            textidTurno.Enabled = false;
            textidAFP.Enabled = false;
            textidAseguradora.Enabled = false;
            textidCargo.Enabled = false;
            textidTipoContrato.Enabled = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IntMinMantenedores_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarG_Click(object sender, EventArgs e)
        {
            entGenero genero = new entGenero();
            genero.Genero = textGenero.Text.Trim();
            logGenero.Instancia.InsertarGenero(genero);
            textGenero.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            entOcupacion oc = new entOcupacion();
            oc.Ocupacion = textOcupacion.Text.Trim();
            logOcupacion.Instancia.InsertarOcupacion(oc);
            textOcupacion.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            IntPrincipal principal = new IntPrincipal();
            principal.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEC_Click(object sender, EventArgs e)
        {
            entEstadoCivil ec = new entEstadoCivil();
            ec.EstadoCivil = textEstadoCivil.Text.Trim();
            logEstadoCivil.Instancia.InsertarEstadoCivil(ec);
            textEstadoCivil.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entTipoContrato tc = new entTipoContrato();
            tc.Tipocontrato = textTipoContrato.Text.Trim();
            logTipoContrato.Instancia.InsertarTipoContrato(tc);
            textTipoContrato.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            entAseguradora a = new entAseguradora();
            a.Aseguradora = textAseguradora.Text.Trim();
            logAseguradora.Instancia.InsertarAseguradora(a);
            textAseguradora.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            entTurno t = new entTurno();
            t.Turno = textTurno.Text.Trim();
            logTurno.Instancia.InsertarTurno(t);
            textTurno.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            entAFP a = new entAFP();
            a.Afp = textAFP.Text.Trim();
            logAFP.Instancia.InsertarAFP(a);
            textAFP.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            entCargo a = new entCargo();
            a.Cargo = textCargo.Text.Trim();
            logCargo.Instancia.InsertarCargo(a);
            textCargo.Text = "";
        }

        private void textidEstadoCivil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
