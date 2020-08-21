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
    public partial class IntAdmin : Form
    {
        public IntAdmin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void bttnIngresar_Click(object sender, EventArgs e)
        {
            int DNI = Convert.ToInt32(textEmpleado.Text);
            int Contraseña = Convert.ToInt32(textContraseña.Text);

            entEmpleado us = logEmpleado.Instancia.Login(DNI, Contraseña);
            if (us != null)
            {
                if (DNI == us.DNI && Contraseña == us.Contraseña)
                {
                    this.Hide();
                    IntPrincipal principal = new IntPrincipal();
                    principal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                    textEmpleado.Text = "";
                    textContraseña.Text = "";
                }

            }
            else
            {
                MessageBox.Show("El Usuario no existe, verifique.", "Usuario: Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }
    }
}
