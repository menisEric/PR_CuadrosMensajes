using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prCuadrosMensajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre;
            
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre: ", "Registro de Datos", "Eric Menis", 100, 0);

            MessageBox.Show("Bienvenido Usuario: " + nombre, "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea salir de la aplicacion?", "Salir del programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcion == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
