using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Silla:Producto
    {
        public Silla (string descripcion, double precioBase, int tipoMaterial):base(descripcion, precioBase, tipoMaterial)
        {
        }

        public override double CalcularPrecio()
        {
            double precioSilla = precioBase * (1 + tipoMaterial * 0.25);
            return precioSilla;
        }

        public override string VerDetalle()
        {
            string tipoProducto = "Silla";
            return $"{base.VerDetalle()}{tipoProducto,15}{CalcularPrecio(),10:f2}";
        }
    }
}
