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

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            Mesa nuevaMesa = null;
            double precioBase;
            string descripcion;
            double largo;
            int tipoMaterial;

            //Ejemplo 1 - creo una mesa
            precioBase = 12.5;
            descripcion = "Mesa de comedor";
            largo = 1;
            tipoMaterial = 1;
            nuevaMesa = new Mesa(descripcion, precioBase, tipoMaterial, largo);
            lista.Add(nuevaMesa);
            //Termina acá

            //Ejemplo 2 - creo una silla
            Silla nuevaSilla = null;
            precioBase = 5.9;
            descripcion = "Silla";
            tipoMaterial = 2;
            nuevaSilla = new Silla(descripcion, precioBase, tipoMaterial);
            //Hasta acá
            textBox1.Clear();

            foreach (Producto producto in lista)
            {
                //listBox1.Items.Add(producto.VerDetalle());
                textBox1.Text += $"{producto.VerDetalle()}\r\n";
            }
        }
    }
}
