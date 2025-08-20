using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Mesa : Producto
    {
        private double largo;

        public Mesa(string descripcion,double precioBase,int tipoMaterial, double largo):base(descripcion, precioBase, tipoMaterial)
        {
            this.largo = largo;
        }

        public override double CalcularPrecio()
        {
            double precioMesa= (precioBase * largo) * (1 + tipoMaterial * 0.33);
            return precioMesa;
        }

        public override string VerDetalle()
        {
            string tipoProducto = $"Mesa({largo:f1})";
            return $"{base.VerDetalle()}{tipoProducto,15}{CalcularPrecio(),10:f2}";
        }
    }
}
