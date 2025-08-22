using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Presupuesto
    {
        private int cantidadProductos;
        private double costoTotal;
        private string cliente;
        private string direccion;
        ArrayList presupuestados = new ArrayList(); //en el UML se identifica en "presupuestados - *", no se ve implicitamente en la clase
        public int CantidadProductos
        {
            get { return presupuestados.Count; } //readonly
            //set { cantidadProductos = value; }
        }

        public double CostoTotal
        {
            get 
            {
                double costo = 0;
                foreach(Producto p in presupuestados)
                {
                    costo += p.CalcularPrecio();
                }
                return costo; 
            }
            
            
            
            //set {  costoTotal = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set {  direccion = value; }
        }

        public Presupuesto(string cliente, string direccion)
        {
            this.cliente = cliente;
            this.direccion = direccion;
        }

        public void AgregarProducto(Producto nuevo)
        {
            presupuestados.Add(nuevo);
        }

        public Producto VerProducto(int idx)
        {
            if (idx >= 0 && idx < CantidadProductos)
                return presupuestados[idx] as Producto;
            return null;
        }
    }
}
