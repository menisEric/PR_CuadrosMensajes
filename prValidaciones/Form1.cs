using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prValidaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.txtNombre, "Ingrese nombre");
            this.toolTip1.SetToolTip(this.txtEdad, "Ingrese edad");
            this.toolTip1.SetToolTip(this.txtSalario, "Ingrese salario");
            this.toolTip1.SetToolTip(this.txtDescripcion, "Ingrese una descripcion");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (is_Validate())
            {
                errorProvider1.Clear();
                MessageBox.Show("Datos agregados correctamente", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool is_Validate()
        {
            bool not_error = true;

            if(txtNombre.Text == string.Empty)
            {
                errorProvider1.SetError(txtNombre, "Ingrese su nombre y apellido completo");
                not_error = false;
            }
            else
            {
                try
                {
                    int i = Convert.ToInt32(txtEdad.Text);
                }
                catch
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtEdad, "Ingrese edad");
                    return false;
                }
                try
                {
                    double j = Convert.ToInt32(txtSalario.Text);
                }
                catch
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtSalario, "Ingrese salario valido");
                    return false;
                }

            }
            return not_error;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtEdad.Clear();
            txtNombre.Clear();
            txtSalario.Clear();
        }

        private void lkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
