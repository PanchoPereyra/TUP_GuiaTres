using System.Collections;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList envios = new ArrayList();
        Presupuesto presupuesto;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DatosCliente formCliente = new DatosCliente();
            if (formCliente.ShowDialog() == DialogResult.OK) 
            {
                string nombre = formCliente.tbNombre.Text;
                string direccion = formCliente.tbDireccion.Text;
                presupuesto = new Presupuesto(nombre, direccion);
                lbCliente.Text = nombre;
                lbDireccion.Text = direccion;

            }
        }
    }
}
