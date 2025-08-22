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
        {         }
         private void label3_Click(object sender, EventArgs e)
        {        }

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

        /*AGREGA UN PRODUCTO*/
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar fDatos = new FormAgregar();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int tipoProducto = fDatos.cbProducto.SelectedIndex;
                double precioBase = Convert.ToDouble(fDatos.tbPrecio.Text);
                string descripcion = fDatos.tbDescripcion.Text;
                int tipoMaterial = fDatos.cbMaterial.SelectedIndex;

                Producto nuevo = null;
                if (tipoProducto == 0)
                {
                    nuevo = new Silla(descripcion, precioBase, tipoMaterial);
                }
                else if (tipoProducto == 1)
                {
                    double largo = Convert.ToDouble(fDatos.tbLargo.Text);
                }

                if (nuevo != null)
                {
                    presupuesto.AgregarProducto(nuevo);
                }
                fDatos.Dispose();
            }
        }

        /*VER UN PRESUPUESTO*/
        private void btnVer_Click(object sender, EventArgs e)
        {
            VerPresupuesto fVer = new VerPresupuesto();
            fVer.tbPresupuesto.Clear();
            fVer.tbPresupuesto.Text += $@"Cliente: {presupuesto.Cliente} - Dirección: {presupuesto.Direccion}
            
            Items presupuestados:
            ";

            for (int n = 0; n < presupuesto.CantidadProductos; n++)
            {
                Producto producto = presupuesto.VerProducto(n);
                fVer.tbPresupuesto.Text += $"{producto.VerDetalle()}\r\n";
            }
            fVer.tbPresupuesto.Text += $"Total:{presupuesto.CostoTotal,54:f2}";
            fVer.ShowDialog();
            fVer.Dispose();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
